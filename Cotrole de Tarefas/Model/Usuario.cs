namespace Model
{
    public class Usuario
    {
        private int id;
        private string nomeUsuario;
        private string senha;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}

