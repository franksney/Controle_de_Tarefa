﻿using DAL;
using Model;
using System.Data;

namespace BLL
{
    class ComentarioBLL
    {

        public Comentario Inserir(Comentario _comentario)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Inserir(_comentario);
        }
        public DataTable Buscar(string _filtro)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Buscar(_filtro);
        }
        public void Excluir(int _id)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            comentarioDAL.Excluir(_id);
        }
    }
}
