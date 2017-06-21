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
    public partial class Form3a : Form
    {

        Uitslag uit = new Uitslag();

        public Form3a()
        {
            InitializeComponent();
            getIt();
            
        }

        public void getIt()
        {
            foreach (Uitslag uit in uit.LstUitslag)
            {
                lbData.Items.Add(uit.Datum + " " + uit.Naam);
            }
        }
    }
}
