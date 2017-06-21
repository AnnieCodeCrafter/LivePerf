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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void hello()
        {
            
        }

        private void btnCoal_Click(object sender, EventArgs e)
        {
            Coalitie C = new Coalitie();
            this.Visible = false;
            C.Show();
        }
    }
}
