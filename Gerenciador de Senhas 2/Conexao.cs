using System.Data.SQLite;


namespace Gerenciador_de_Senhas_2
{
    internal class Conexao
    {

        public SQLiteConnection con = new SQLiteConnection("Data Source=DBSenhas.db");

        public void conectar()
        {
            con.Open();
        }
        public void desconectar()
        {
            con.Close();

        }


    }
}
