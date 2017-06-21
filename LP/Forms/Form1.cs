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
    public partial class btnCoalRtrn : Form
    {
        public btnCoalRtrn()
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
            C.ShowDialog();
            this.Visible = true;

           
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Form3a F3 = new Form3a();
            this.Visible = false;
            F3.ShowDialog();
            this.Visible = true;
        }
    }
}
