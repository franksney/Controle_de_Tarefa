using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class ComentarioBLL
    {

        public Comentario Inserir(Comentario _comentario)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Inserir(_comentario);
        }
        public DataTable Buscar(int _filtro)
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
