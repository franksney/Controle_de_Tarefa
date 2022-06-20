using System;
using System.Data;
using System.Windows.Forms;
using BLL;

namespace UIPrincipal
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            BindingSource usuarioBindingSource = new BindingSource();
            usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorNome(textBoxUsuario.Text);

            if (usuarioBindingSource.Count != 0)
            {

                String nome = ((DataRowView)usuarioBindingSource.Current).Row["nome"].ToString();
                String senha = ((DataRowView)usuarioBindingSource.Current).Row["senha"].ToString();

                if (nome == textBoxUsuario.Text && senha == textBoxSenha.Text)
                    Close();
                else
                {
                    MessageBox.Show("Usuario ou senha incorreta!");
                    textBoxSenha.Text = "";
                    textBoxSenha.Focus();
                }

            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreta!");
                textBoxSenha.Text = "";
                textBoxSenha.Focus();
            }
        }
    }
}
