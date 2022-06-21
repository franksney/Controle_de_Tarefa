using BLL;
using System;
using System.Data;
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
        private void buttonAdicionarComentaro_Click(object sender, EventArgs e)
        {
            int id_Tarefa = Convert.ToInt32(((DataRowView)tarefaBindingSource.Current).Row["Id"]);
            int id_Usuario = Convert.ToInt32(((DataRowView)tarefaBindingSource.Current).Row["Id_Usuario"]);
            using (FormCadastraComentario frm = new FormCadastraComentario(id_Tarefa, id_Usuario))
            {
                frm.ShowDialog();
            }
        }
        private void tarefaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (tarefaBindingSource.Count > 0)
            {
                ComentarioBLL comentarioBLL = new ComentarioBLL();
                int id_Tarefa = Convert.ToInt32(((DataRowView)tarefaBindingSource.Current).Row["Id"]);
                comentarioBindingSource.DataSource = comentarioBLL.Buscar(id_Tarefa);
            }
        }
    }
}