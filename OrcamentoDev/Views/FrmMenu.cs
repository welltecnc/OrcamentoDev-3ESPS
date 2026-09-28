using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrcamentoDev.Views
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnNovoOrcamento_Click(object sender, EventArgs e)
        {
            FrmOrcamento orcamento = new FrmOrcamento();
            orcamento.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            //Aponta o caminho para o mesmo diretorio do sistema
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orcamento.txt");

            if (File.Exists(caminho))
            {
                string relatorio = File.ReadAllText(caminho);
                MessageBox.Show(relatorio, "Relatório de Orçamentos", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Arquivo não foi encontrado{caminho}", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FrmLogin"]?.Show();
            this.Close();
        }
    }
}
