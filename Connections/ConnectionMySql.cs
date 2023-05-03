using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos.Connections
{
    public class ConnectionMySql
    {
        public static MySqlConnection connection = new MySqlConnection()
        {
            ConnectionString = "Server=localhost;Database=Cadastro;Uid=root;Pwd=34454541Vw@nem;"
        };
    }
}
