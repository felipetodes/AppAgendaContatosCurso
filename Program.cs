using System.Data.SqlClient;

namespace AppAgendaContatosCurso
{
    public class Program
    {
        public static readonly string connectionString = "Server=Localhost;Database=AGENDA;Integrated Security=True;";
        static void Main(string[] args)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                try { 
                
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro ao estabelecer conexão com o banco de dados");
                }
                finally 
                { 
                    con.Close();
                }
            }
        }
    }
}
