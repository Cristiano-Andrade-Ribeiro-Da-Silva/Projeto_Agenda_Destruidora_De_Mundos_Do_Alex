using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Data
{
     static public class ConexãoDB
    {
        static public MySqlConnection criador_conexao()
        {
            //String contendo as informações para a conexão
            string stringconexao = "server=127.0.0.1;Database=dbagenda;User ID=root;Password=root;";

            //Criando conexão
            MySqlConnection conexao = new MySqlConnection(stringconexao);

            return conexao;
        }
    }
}
