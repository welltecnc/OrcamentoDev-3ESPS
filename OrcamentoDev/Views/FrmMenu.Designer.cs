namespace OrcamentoDev.Views
{
    partial class FrmMenu
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
            btnNovoOrcamento = new Button();
            lblBoasVindas = new Label();
            btnRelatorios = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnNovoOrcamento
            // 
            btnNovoOrcamento.Location = new Point(215, 147);
            btnNovoOrcamento.Name = "btnNovoOrcamento";
            btnNovoOrcamento.Size = new Size(117, 52);
            btnNovoOrcamento.TabIndex = 0;
            btnNovoOrcamento.Text = "Novo Orçamento";
            btnNovoOrcamento.UseVisualStyleBackColor = true;
            btnNovoOrcamento.Click += btnNovoOrcamento_Click;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Location = new Point(334, 28);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(211, 15);
            lblBoasVindas.TabIndex = 1;
            lblBoasVindas.Text = "Bem-Vindo ao Sistema de Orçamentos";
            // 
            // btnRelatorios
            // 
            btnRelatorios.Location = new Point(372, 147);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(90, 52);
            btnRelatorios.TabIndex = 2;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(506, 147);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(90, 52);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 432);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorios);
            Controls.Add(lblBoasVindas);
            Controls.Add(btnNovoOrcamento);
            Name = "FrmMenu";
            Text = "Menu Principal-Orçamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovoOrcamento;
        private Label lblBoasVindas;
        private Button btnRelatorios;
        private Button btnSair;
    }
}