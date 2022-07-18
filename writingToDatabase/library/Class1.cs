using System.Data.SqlClient;


namespace library
{
    public class Class1
    {
        public static void insertValues(string fName, string lName, string fullName, SqlConnection conn)
        {
            

            string query = "INSERT INTO Customer(FirstName,Surname,FullName,isActive)" +
                " VALUES(@name,@surname,@fullname,1)";

            SqlCommand cmd = new SqlCommand(query,conn);
           

            cmd.Parameters.AddWithValue("@name", fName);
            cmd.Parameters.AddWithValue("@surname", lName);
            cmd.Parameters.AddWithValue("@fullname", fullName);


            cmd.ExecuteNonQuery();

            conn.Close();
            
        }
    }
}