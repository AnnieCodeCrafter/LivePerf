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
        private string naam;
        private int stemmen;
        private decimal percentage;
        private int zetels;

        private List<Partijen> partijen = new List<Partijen>();

        
        public string Naam
        {
            get { return naam; } 
        }

        public int Stemmen
        {
            get { return stemmen; }
        }

        public decimal Percentage
        {
            get { return percentage; }
        }

        public int Zetels
        {
            get { return zetels; }
        }



       public Uitslag(string naam, int stemmen, decimal percentage, int zetels)
        {
            this.naam = naam;
            this.stemmen = stemmen;
            this.percentage = percentage;
            this.zetels = zetels;
        }

        


    }
}
        

            

