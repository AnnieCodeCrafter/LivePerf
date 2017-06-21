using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
           
            InitializeComponent();
        }

     

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi364679;User ID=dbi364679;Password=Thorax1998";

            Pen VarPen;

         
            Pen BlackPen = new Pen(Brushes.Black);
            Graphics g = pnlDraw.CreateGraphics();

            for (int i = 0; i <11; i++)
            {
                g.DrawLine(BlackPen, 10, 10 + 20 * i, 310, 10 + 20 * i);
               
            }  
            
            for (int i = 0; i<16; i++)
            {
                g.DrawLine(BlackPen, 10 + 20 * i, 10, 10 +  20 * i, 210);
            }


            //using (SqlConnection Conn = new SqlConnection(connectionString))
            //{
            //    Conn.Open();
            //    int x;
            //    int PartijID = 1;
                
            //    string query = $"SELECT Zetels FROM Uitslag WHERE PartijID = @partijID";
            //    using (SqlCommand cmd = new SqlCommand(query, Conn))
            //    {
            //        for (int i = 0; i < 13; i ++)
            //        {
            //            cmd.Parameters.AddWithValue("@PartijID", PartijID + i);

            //            using (SqlDataReader reader = cmd.ExecuteReader())
            //            {
            //                while (reader.Read())
            //                {

            //                    x = ((int)reader["Zetels"]);
            //                    for (int j = 0; j < x; j++)
            //                    {
            //                       VarPen = new Pen(Color.Blue, 5);
            //                        g.DrawRectangle(VarPen, 13 + i * 5, 13 + i*5, 2, 2);



            //                    }

            //                }
            //            }
            //        }
            //    }
            //}


            BlackPen.Dispose();
        }

        OpenFileDialog choose = new OpenFileDialog();




       private void btnExp_Click(object sender, EventArgs e)
        {
                    //{

        //    // Create a string array with the lines of text
        //    string[] lines = { "First line", "Second line", "Third line" };

        //    // Set a variable to the My Documents path.
        //    string mydocpath =
        //        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //    // Write the string array to a new file named "WriteLines.txt".
           

        }
    }
}
