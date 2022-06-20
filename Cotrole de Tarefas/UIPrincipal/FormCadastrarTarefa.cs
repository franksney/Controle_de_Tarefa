using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastrarTarefa : Form
    {
        public FormCadastrarTarefa()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            TarefaBLL tarefaBLL = new TarefaBLL();
            Tarefa tarefa = new Tarefa();
            tarefa.Id = Convert.ToInt32(idTextBox.Text);
            tarefa.Descricao = descricaoTextBox.Text;
            tarefa.Estatus = textBox1.Text;
            tarefa.Id_Usuario = 1;
            tarefaBLL.Inserir(tarefa);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
