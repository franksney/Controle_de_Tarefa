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
            tarefa.Descricao = descricaoTextBox.Text;
            tarefa.Estatus = textBox1.Text;
            tarefa.Id_Usuario = 1;
            tarefaBLL.Inserir(tarefa);
            MessageBox.Show("Registro Salvo com sucesso!");
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
