using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Data.OleDb;




namespace LP
{
    public partial class Coalitie : Form
    {

        Uitslag uit = new Uitslag();

        string connectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi364679;User ID=dbi364679;Password=Thorax1998";


        public Coalitie()
        {
            InitializeComponent();
            hello();
            //SelectNumbers();


        }



        public void hello()
        {

            using (SqlConnection Conn = new SqlConnection(connectionString))
            {
                Conn.Open();
                string query = "SELECT Partij.Naam, Uitslag.Stemmen, Uitslag.Percentage, Uitslag.Zetels FROM Uitslag INNER JOIN Partij ON Uitslag.PartijID = Partij.ID";
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {

                    BindingSource BS = new BindingSource();
                    DgvRes.DataSource = BS;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    BS.DataSource = table;
                    DgvRes.AutoResizeColumns(
                        DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            uit.Datum = DtpCoal.Value;
            uit.Naam = txtCoalNaam.Text;

            int bluh = DgvRes.CurrentRow.Index;

            foreach (DataGridViewRow row in DgvRes.SelectedRows)
            {
                foreach (DataGridViewCell cell in DgvRes.SelectedCells)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        uit.Partij = DgvRes.Rows[bluh].Cells[0].Value.ToString();
                        uit.Stemmen = Convert.ToInt32(DgvRes.Rows[bluh].Cells[1].Value);
                        uit.Percentage = Convert.ToDecimal(DgvRes.Rows[bluh].Cells[2].Value);
                        uit.Zetels = Convert.ToInt32(DgvRes.Rows[bluh].Cells[3].Value);


                    }

                }
            }

            Uitslag Uut = new Uitslag(uit.Naam, uit.Datum, uit.Partij, uit.Stemmen, uit.Percentage, uit.Zetels);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            // Create a string array with the lines of text
            string[] Line = { uit.Naam + " " + uit.Datum.ToString() + " " + uit.Partij + " " + uit.Stemmen.ToString() + " " + uit.Percentage.ToString() + " " + uit.Zetels.ToString() };

            // Set a variable to the My Documents path.
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(mydocpath + $@"\{uit.Naam}.txt"))
            {
                foreach (string line in Line)
                    outputFile.WriteLine(line);
            }



            MessageBox.Show("De file is opgeslagen.");

            Form2 f = new LP.Form2();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }


      



     


        //double click on the cell that you want to change or it won't pick it up
        private void DgvRes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = DgvRes.CurrentRow.Index + 1;

            using (SqlConnection Conn = new SqlConnection(connectionString))
            {
                Conn.Open();

                string query = $"SELECT Stemmen FROM Uitslag WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {

                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal stemmen = ((int)reader["Stemmen"]);
                            NudStem.Value = stemmen;
                        }
                    }
                }
            }
        }
        private void btnStem_Click(object sender, EventArgs e)
        {
            int id = DgvRes.CurrentRow.Index + 1;
            using (SqlConnection Conn = new SqlConnection(connectionString))
            {
                Conn.Open();

                string query = "UPDATE Uitslag SET Stemmen = @Stemmen WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Stemmen", Convert.ToInt32(NudStem.Value));

                    cmd.ExecuteNonQuery();

                
                }
                    

              

            }

            


        }


    }
}
    


