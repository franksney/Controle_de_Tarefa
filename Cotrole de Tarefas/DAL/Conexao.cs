using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Conexao
    {
        public static string StringDeConexao
        {
            get
            {
                return @"User ID=SA;Initial Catalog=Controle_de_Tarefas;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
            }
        }
    }
}
