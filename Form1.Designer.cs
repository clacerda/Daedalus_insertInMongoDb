namespace mongoDbUpload
{
    partial class Daedalus
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daedalus));
            this.btnProcessar = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCollection = new System.Windows.Forms.TextBox();
            this.lblExecucao = new System.Windows.Forms.Label();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(256, 279);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(122, 43);
            this.btnProcessar.TabIndex = 0;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(12, 30);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(366, 23);
            this.txtCaminho.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "String Connection";
            // 
            // txtConn
            // 
            this.txtConn.Location = new System.Drawing.Point(12, 81);
            this.txtConn.Name = "txtConn";
            this.txtConn.Size = new System.Drawing.Size(366, 23);
            this.txtConn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(12, 136);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(366, 23);
            this.txtBase.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Collection";
            // 
            // txtCollection
            // 
            this.txtCollection.Location = new System.Drawing.Point(12, 190);
            this.txtCollection.Name = "txtCollection";
            this.txtCollection.Size = new System.Drawing.Size(366, 23);
            this.txtCollection.TabIndex = 7;
            // 
            // lblExecucao
            // 
            this.lblExecucao.AutoSize = true;
            this.lblExecucao.Enabled = false;
            this.lblExecucao.Location = new System.Drawing.Point(12, 256);
            this.lblExecucao.Name = "lblExecucao";
            this.lblExecucao.Size = new System.Drawing.Size(13, 15);
            this.lblExecucao.TabIndex = 9;
            this.lblExecucao.Text = "  ";
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(12, 219);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(366, 23);
            this.prgBar.TabIndex = 10;
            this.prgBar.Visible = false;
            // 
            // Daedalus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 334);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.lblExecucao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCollection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnProcessar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Daedalus";
            this.Text = "Daedalus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnProcessar;
        private TextBox txtCaminho;
        private Label label1;
        private Label label2;
        private TextBox txtConn;
        private Label label3;
        private TextBox txtBase;
        private Label label4;
        private TextBox txtCollection;
        private Label lblExecucao;
        private ProgressBar prgBar;
    }
}