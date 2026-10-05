using OrcamentoDev.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrcamentoDev.Views
{
    public partial class FrmOrcamento : Form
    {
        //váriavel global na tela para guardar o ultimo calculo feito e poder salvar depois
        private decimal valorTotalCalculado = 0;

        public FrmOrcamento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Tratamento de Erros
            try
            {
                string cliente = txtCliente.Text;
                int horas = int.Parse(txtHora.Text);
                decimal valorHora = decimal.Parse(txtValorHora.Text);
                bool Urgente = chkUrgente.Checked;

                //APlicanodo Orientação a Objetos (Herança e Polimorfismo)
                Orcamento meuOrcamento = Urgente
                    ? new OrcamentoUrgente(cliente, horas, valorHora, true)
                    : new Orcamento(cliente, horas, valorHora);

                valorTotalCalculado = meuOrcamento.CalcularTotal();

                lblResultado.Text = $"Valor total: R$ {valorTotalCalculado:N2}";

              


            }
            catch (FormatException)
            {
                MessageBox.Show("Por Favor, Preencha os campos corretament ", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtCliente.Text) || string.IsNullOrWhiteSpace(txtHora.Text))
                {
                    MessageBox.Show("Preencha os dados Corretamente ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string cliente = txtCliente.Text;
                string projeto = txtProjeto.Text;
                string horas = txtHora.Text;
                string valorHora = txtValorHora.Text;
                bool urgente = chkUrgente.Checked;

                string conteudo = "-------------------------------------------------\n" +
                    $"Data/Hora:{DateTime.Now}\n" +
                    $"Cliente: {cliente}\n" +
                    $"Projeto: {projeto}\n" +
                    $"Horas: {horas}h | Valor Hora: R$ {valorHora}\n" +
                    $"Prioridade: {(urgente ? "Sim" : "Não")}\n" +
                    $"Total: R$ {valorTotalCalculado:N2}\n" +
                    $"";
                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orcamento.txt");
                File.AppendAllText(caminho, conteudo);

                MessageBox.Show("Orçamento salvo com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //limpar campos
                txtCliente.Clear();
                txtHora.Clear();
                txtProjeto.Clear();
                txtValorHora.Clear();
                this.Close();

            }
            catch (FormatException)
            {
                MessageBox.Show("Erro ao salvar arquivo ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
