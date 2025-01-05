using System.Data.SqlClient;

namespace AppAgendaContatosCurso
{
    public class Program
    {
        public static readonly string connectionString = "Server=Localhost;Database=AGENDA;Integrated Security=True;";
        static void Main(string[] args)
        {
            ExecutarSelect();
        }
        public static void ExecutarSelect()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT ID, NOME, EMAIL, DT_INC FROM CONTATO";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Forma 1 
                                //Console.WriteLine(reader.GetInt32(0));
                                //Console.WriteLine(reader.GetString(1));
                                //Console.WriteLine(reader.GetString(2));
                                //Console.WriteLine(reader.GetDateTime(3));

                                // Forma 2
                                Console.WriteLine($"ID: {reader["ID"]}");
                                Console.WriteLine($"NOME: {reader["NOME"]}");
                                Console.WriteLine($"EMAIL: {reader["EMAIL"]}");
                                Console.WriteLine($"DATA DE CRIAÇÃO: {reader["DT_INC"]}");

                            }
                        }
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao estabelecer conexão com o banco de dados.{ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
