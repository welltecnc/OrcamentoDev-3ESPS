namespace OrcamentoDev.Views
{
    partial class FrmOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            lblCliente = new Label();
            txtCliente = new TextBox();
            chkUrgente = new CheckBox();
            lblProjeto = new Label();
            lblHoras = new Label();
            lblValorHora = new Label();
            lblResultado = new Label();
            txtValorHora = new TextBox();
            txtHora = new TextBox();
            txtProjeto = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Black;
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.ForeColor = Color.Yellow;
            btnCalcular.Location = new Point(213, 368);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(187, 45);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Caclular Valor";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCliente.Location = new Point(219, 42);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(143, 21);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Nome do Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(393, 40);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(242, 23);
            txtCliente.TabIndex = 2;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkUrgente.ForeColor = Color.FromArgb(0, 0, 192);
            chkUrgente.Location = new Point(219, 278);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(273, 25);
            chkUrgente.TabIndex = 3;
            chkUrgente.Text = "Projeto Urgente (Adicional de 20%)";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // lblProjeto
            // 
            lblProjeto.AutoSize = true;
            lblProjeto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProjeto.Location = new Point(219, 82);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(168, 21);
            lblProjeto.TabIndex = 4;
            lblProjeto.Text = "Descrição do Projeto";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHoras.Location = new Point(219, 128);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(135, 21);
            lblHoras.TabIndex = 5;
            lblHoras.Text = "Horas Estimadas";
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValorHora.Location = new Point(219, 164);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(130, 21);
            lblValorHora.TabIndex = 6;
            lblValorHora.Text = "Valor Hora (R$):";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.FromArgb(0, 192, 0);
            lblResultado.Location = new Point(219, 222);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(236, 32);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Valor Total: R$ 0,00";
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(393, 165);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(242, 23);
            txtValorHora.TabIndex = 9;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(393, 129);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(242, 23);
            txtHora.TabIndex = 10;
            // 
            // txtProjeto
            // 
            txtProjeto.Location = new Point(393, 80);
            txtProjeto.Name = "txtProjeto";
            txtProjeto.Size = new Size(242, 23);
            txtProjeto.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Font = new Font("Segoe UI", 12F);
            btnSalvar.ForeColor = Color.Yellow;
            btnSalvar.Location = new Point(422, 368);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(189, 45);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar Orçamento";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtProjeto);
            Controls.Add(txtHora);
            Controls.Add(txtValorHora);
            Controls.Add(lblResultado);
            Controls.Add(lblValorHora);
            Controls.Add(lblHoras);
            Controls.Add(lblProjeto);
            Controls.Add(chkUrgente);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(btnCalcular);
            Name = "FrmOrcamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Orçamento de Desenvolvimento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblCliente;
        private TextBox txtCliente;
        private CheckBox chkUrgente;
        private Label lblProjeto;
        private Label lblHoras;
        private Label lblValorHora;
        private Label lblResultado;
        private TextBox txtValorHora;
        private TextBox txtHora;
        private TextBox txtProjeto;
        private Button btnSalvar;
    }
}