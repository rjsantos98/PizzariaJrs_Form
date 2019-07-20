using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Conexao
    {
        private MySqlConnection con;
        public MySqlConnection AbrirConexao()
        {
            con = new MySqlConnection("server=localhost;user id=jrdev;password=Pass*JR;persistsecurityinfo=True;database=pizzaria_jrs");
            con.Open();
            return con;
        }

        public MySqlConnection FecharConexao()
        {
            con = new MySqlConnection("server=localhost;user id=jrdev;password=Pass*JR;persistsecurityinfo=True;database=pizzaria_jrs");
            con.Close();
            return con;
        }
    }
}
