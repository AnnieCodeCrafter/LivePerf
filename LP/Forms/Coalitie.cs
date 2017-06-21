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




namespace LP
{
    public partial class Coalitie : Form
    {
        string connectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi364679;User ID=dbi364679;Password=Thorax1998";
        private List<Uitslag> uitslag = new List<Uitslag>();

        public Coalitie()
        {
            InitializeComponent();
            hello();
            

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


        private void hellerh()
        {

          



            //Int32 selectedRowCount =
            //    DgvRes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //if (selectedRowCount > 0)
            //{
            //    System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //    for (int i = 0; i < selectedRowCount; i++)
            //    {
            //        sb.Append("Row: ");
            //        sb.Append(DgvRes.SelectedRows[i].Index.ToString());
            //        sb.Append(Environment.NewLine);
            //    }

            //    sb.Append("Total: " + selectedRowCount.ToString());
            //    MessageBox.Show(sb.ToString(), "Selected Rows");
            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int bleh = DgvRes.SelectedRows.Count;
            int bluh = DgvRes.SelectedCells.Count;

            int bleugh = dvgRes




            foreach (DataGridViewRow row in DgvRes.SelectedRows)
            {
                foreach (DataGridViewCell cell in dvg)
                {
                    string naam = DgvRes.Rows[].Cells[0].Value.ToString();
                    string stemmen = DgvRes.Rows[].Cells[2].Value.ToString();
                    // DgvRes.Rows[blih].Cells[3].Value.ToString();

                    MessageBox.Show(naam);
                }
            }


        }

    }

}
