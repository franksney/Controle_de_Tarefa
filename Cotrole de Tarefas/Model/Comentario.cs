namespace Model
{
    public class Comentario
    {
        private int id;
        private string id_Usuario;
        private string id_Tarefa;
        private bool descricao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Id_Usuario
        {
            get { return id_Usuario; }
            set { id_Usuario = value; }
        }
        public string Id_Tarefa
        {
            get { return id_Tarefa; }
            set { id_Tarefa = value; }
        }
       public bool Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
