using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class Conexao
    {
        //Singleton
        //set e get
        private static  MySqlConnection _instance;
        public static  MySqlConnection Instance {
            get { 
                if(_instance == null)
                {
                    _instance = new MySqlConnection(@"Server=127.0.0.1;Database=locadoraclassic;Uid=root;Pwd=");
                }
                return _instance; 
            } 
        }

      
    }
}


/*
 *       //se não existe conexão.
                if (_conn == null)
                {
                    //criar a conexão com MySQL   //nos parênteses -connection string
                    _conn = new MySqlConnection(@"Server = 127.0.0.1; Database = locadora; Uid = root; Pwd = ;");
                }
                //retorna a conexão
                return _conn;
 * 
 * 
 */ 