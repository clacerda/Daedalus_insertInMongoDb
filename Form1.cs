using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver; 

namespace mongoDbUpload
{
    public partial class Daedalus : Form
    {
        public Daedalus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = txtConn.Text;               //stringConnection
            string path = txtCaminho.Text;           //Caminho do arquivo a ser upado (somente pasta)
            string dbase = txtBase.Text;             //dataBase
            string collections = txtCollection.Text; //Collections

            if (con != null && con != "" && path != null && path != "" && dbase != null && dbase != "" && collections != null && collections != "")
            {
                //Cria arch, lista de string, que terá domínio de todos os arquivos da pasta.
                List<string> arch = leituraDePasta(path);
                int i = 0;

                foreach (var item in arch)
                {
                    prgBar.Visible = true;
                    prgBar.Maximum = arch.Count;
                    prgBar.Value = i++;
                    //Lê arquivo.txt e recebe o array de arquivos texto/json
                    List<string> rows = new List<string>(File.ReadAllLines(item));

                    geraInsert(rows, con, dbase, collections);

                    // Sinalizador de execução.
                    if (i < arch.Count)
                    {
                        lblExecucao.ForeColor = Color.Yellow;
                        lblExecucao.Text = @"Em processamento.";
                    }
                    else
                    {
                        prgBar.Visible = false;
                        lblExecucao.ForeColor = Color.DarkGreen;
                        lblExecucao.Text = @"Execução concluída.";
                        return;
                    }
                }
            }
            else
            {
                lblExecucao.ForeColor = Color.Red;
                lblExecucao.Text = @"É necessário preencher todos os campos.";
                return;
            } 
        }

        public void geraInsert(List<string> rows, string con, string dbase, string collections)
        { 
            List<string> errorList = new List<string>();
            foreach (var row in rows)
            { 
                if (row.Length > 0)
                {
                    var getNome = "";
                    //Tratamento do arquivo do formato que foi gerado.
                    var json = row.Replace("db.getCollection('fs.files').insert(", "").Replace(");", "");
                    
                    // Pegar nome do arquivo de forma dinâmica.
                    foreach (var item in json.Split(","))
                    {
                        if(item.Length >= 13)
                        {
                            if (item.Trim().Substring(0, 13).Replace("'", "").Replace(":", "").Replace("{", "") == "NOMEARQUIVO")
                            {
                                getNome = item.Replace("'", "").Replace("{", "").Replace("}", "");
                            }
                        }                        
                    }
                    // Caso o nome não esteja em branco
                    if(getNome != "" && getNome.Length > 0)
                    { 
                        lblExecucao.Enabled  = true;
                        lblExecucao.Text = "" + getNome;
                    }
                    else
                    {
                        lblExecucao.Enabled = false;
                    } 
                    //Executa insert no banco de dados.            
                    var returnInsert = executeInsert(json, con, dbase, collections);
                    lblExecucao.Text = "";

                    if (!returnInsert)
                    { 
                        errorList.Add(lblExecucao.Text);
                    } 
                }
                else
                {
                    return;
                }
            }
            if (errorList.Count > 0)
            {
                // se a lista de erro não for zero, gera arquivo de erro.
                geraArquivo(errorList);
            }
        }

        public void geraArquivo(List<string> file)
        { 
            // Gerar um arquivo no "C:\" com a linha que deu erro.
            var nomeArquivo = @"C:\" + "Erros_" + DateTime.Now.ToString() + ".txt";

            File.WriteAllLines(nomeArquivo, file);
        }

        public  Boolean executeInsert(string row, string con, string dbase, string collections)
        {
            //Inicia a conexão...
            var client = new MongoClient(con);
            var database = client.GetDatabase(dbase);
           
            
            /*
             * Gera o doc (bson) à partir de uma linha do arquivo "json" selecionado;
             * Gera o Bson serializado;
             * Gera a var collections retornando a coleção passada no início do programa;
             * tenta efetuar o insert do "doc" na coleção desejada.
            */
            BsonDocument doc = BsonDocument.Parse(row);
            BsonSerializer.Deserialize<BsonDocument>(doc); 
            var collection = database.GetCollection<BsonDocument>(collections);
            try
            {
                collection.InsertOne(doc);
                 
                return true;
            }
            catch (MongoWriteException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            } 
        }
         
        public List<string> leituraDePasta(string path)
        { 
            //Lê pasta e os arquivos dentro dela gerando array de arquivos.
            string[] arquivos = Directory.GetFiles(path);
            //Adiciona o array dentro da lista.
            List<string> arch = new List<string>(arquivos);
            return arch;
        }
    }
}