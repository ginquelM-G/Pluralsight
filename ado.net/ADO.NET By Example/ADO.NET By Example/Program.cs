using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NET_By_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SI2_Trabalho_1718i;Data Source=GINQUELM-E\\SQLSERVER";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            Console.WriteLine("Connection Establish Secuessfully...");
            Console.ReadKey();
        }

    }
}
