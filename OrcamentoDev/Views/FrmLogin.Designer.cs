namespace OrcamentoDev
{
    partial class FrmLogin
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
            btnEntrar = new Button();
            lblTitulo = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(0, 0, 192);
            btnEntrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(230, 248);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(119, 53);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Blue;
            lblTitulo.Location = new Point(140, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(268, 40);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Acesso ao Sistema";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(203, 114);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(205, 23);
            txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(0, 0, 192);
            lblUsuario.Location = new Point(125, 117);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 21);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(0, 0, 192);
            lblSenha.Location = new Point(125, 176);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(58, 21);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(203, 168);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(205, 23);
            txtSenha.TabIndex = 5;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 346);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(btnEntrar);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Orçamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label lblTitulo;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
    }
}
