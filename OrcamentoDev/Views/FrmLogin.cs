using OrcamentoDev.Views;

namespace OrcamentoDev
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text =="Admin" && txtSenha.Text == "1234")
            {
                //Instânciando a tela menu
                FrmMenu menu = new FrmMenu();
                //Chamando a tela menu
                menu.Show();
                // Ocultando a tela de login
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário / Senha inválidos", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
