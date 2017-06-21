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
        private DateTime datum;
        private string partij;
        private int stemmen;
        private decimal percentage;
        private int zetels;

        private List<Partijen> partijen = new List<Partijen>();
        public List<Uitslag> LstUitslag = new List<Uitslag>();


        public string Naam
        {
            get { return naam; } 
            set { naam = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public string Partij
        {
            get { return partij; }
            set { partij = value; }
        }

        

        public int Stemmen
        {
            get { return stemmen; }
            set { stemmen = value; }
        }

        public decimal Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        public int Zetels
        {
            get { return zetels; }
            set { zetels = value; }
        }



       public Uitslag(string naam, DateTime datum, string partij, int stemmen, decimal percentage, int zetels)
        {
            this.naam = naam;
            this.datum = datum;
            this.partij = partij;
            this.stemmen = stemmen;
            this.percentage = percentage;
            this.zetels = zetels;
        }

        public Uitslag()
        {

        }

        public override string ToString()
        {

            return partij + ' ' + stemmen + " " + percentage + " " + zetels;
             
        }

  

    }
}
        

            

