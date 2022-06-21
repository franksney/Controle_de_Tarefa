﻿using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastraComentario : Form
    {

        private int id_Tarefa;
        private int id_Usuario;
        public FormCadastraComentario(int _id_Tarefa, int _id_Usuario)
        {
            InitializeComponent();
            id_Tarefa = _id_Tarefa;
            id_Usuario = _id_Usuario;
        }

        private void FormCadastraComentario_Load(object sender, System.EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                ComentarioBLL comentarioBLL = new ComentarioBLL();
                Comentario comentario = new Comentario();
                comentario.Descricao = descricaoTextBox.Text;
                comentario.Id_Tarefa = id_Tarefa;
                comentario.Id_Usuario = id_Usuario;
                comentarioBLL.Inserir(comentario);
                MessageBox.Show("Comentário inserido com suceso!");
                Close();

            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
