using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LP
{


    class Uitslag
    {
        private string connectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi364679;User ID=dbi364679;Password=Thorax1998";
        private string Naam;
        private string Percentage;
        private string Zetels;

        private List<string> stuffs = new List<string>();

        public void hello()
        {

            using (SqlConnection Conn = new SqlConnection(connectionString))
            {
                Conn.Open();
                string query = "SELECT Partij.Naam, Uitslag.Stemmen, Uitslag.Percentage, Uitslag.Zetels FROM Uitslag INNER JOIN Partij ON Uitslag.PartijID = Partij.ID";
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                       
                    }



                }

            }
        }
    }
}
        

            

