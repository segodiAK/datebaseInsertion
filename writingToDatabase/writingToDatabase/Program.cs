using library;
using System.Data.SqlClient;

namespace writingToDatabase
{
    internal class Program
    {
       static void Main(string[] args)
        {
            string connection =("Server=LAPTOP-LKMUO7D3; Database=mimmosDB; Trusted_Connection=True");
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            enterValues(conn);
         
        }
        public static void enterValues(SqlConnection conn)
        {
            Console.Write("Please enter your name: ");
            string Name1 = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string Surname1 = Console.ReadLine();
            Console.Write("Please enter your full name: ");
            string FullName1 = Console.ReadLine();

            Class1.insertValues(Name1, Surname1, FullName1, conn);
        }
    }
}
