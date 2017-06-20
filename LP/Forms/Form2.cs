using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void uitslagBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uitslagBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbi364679DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbi364679DataSet.Uitslag' table. You can move, or remove it, as needed.
            this.uitslagTableAdapter.Fill(this.dbi364679DataSet.Uitslag);

        }
    }
}
