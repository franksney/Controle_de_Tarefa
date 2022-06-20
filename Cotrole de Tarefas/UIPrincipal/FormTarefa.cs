using BLL;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormTarefa : Form
    {
        public object TarefaBLL { get; private set; }

        public FormTarefa()
        {
            InitializeComponent();
        }

        private void TelaInicial_Login_Load(object sender, EventArgs e)
        {
            using (TelaLogin frm = new TelaLogin())
            {
                Login();
            }
        }

        private void Login()
        {
            using (TelaLogin frm = new TelaLogin())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            TarefaBLL tarefaBLL = new TarefaBLL();
            tarefaBindingSource.DataSource = tarefaBLL.Buscar(textBoxbuscar.Text);
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastrarTarefa frm = new FormCadastrarTarefa())
            {
                frm.ShowDialog();
            }
        }
    }
}