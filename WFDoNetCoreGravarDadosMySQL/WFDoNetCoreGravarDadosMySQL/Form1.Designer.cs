namespace WFDoNetCoreGravarDadosMySQL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lstContatos = new System.Windows.Forms.ListView();
            this.lblBuscarContato = new System.Windows.Forms.Label();
            this.txtBuscarContato = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 130);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(245, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(15, 146);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(245, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.Location = new System.Drawing.Point(164, 190);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lstContatos
            // 
            this.lstContatos.HideSelection = false;
            this.lstContatos.Location = new System.Drawing.Point(268, 59);
            this.lstContatos.Name = "lstContatos";
            this.lstContatos.Size = new System.Drawing.Size(435, 363);
            this.lstContatos.TabIndex = 7;
            this.lstContatos.UseCompatibleStateImageBehavior = false;
            // 
            // lblBuscarContato
            // 
            this.lblBuscarContato.AutoSize = true;
            this.lblBuscarContato.Location = new System.Drawing.Point(265, 9);
            this.lblBuscarContato.Name = "lblBuscarContato";
            this.lblBuscarContato.Size = new System.Drawing.Size(83, 13);
            this.lblBuscarContato.TabIndex = 8;
            this.lblBuscarContato.Text = "Buscar Contato:";
            // 
            // txtBuscarContato
            // 
            this.txtBuscarContato.Location = new System.Drawing.Point(268, 32);
            this.txtBuscarContato.Name = "txtBuscarContato";
            this.txtBuscarContato.Size = new System.Drawing.Size(332, 20);
            this.txtBuscarContato.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(606, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 447);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarContato);
            this.Controls.Add(this.lblBuscarContato);
            this.Controls.Add(this.lstContatos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Agenda de Contatos C# com MySQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListView lstContatos;
        private System.Windows.Forms.Label lblBuscarContato;
        private System.Windows.Forms.TextBox txtBuscarContato;
        private System.Windows.Forms.Button btnBuscar;
    }
}

