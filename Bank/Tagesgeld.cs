using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Tagesgeld
    {
        private Konto verrechnungskonto;
        private int kontoNr;
        private double guthaben;
        private double zinssatz;


        public int VerrechnungsKontoNr
        {
            get { return this.verrechnungskonto.KontoNr; }
        }

        public double Zinssatz
        {
            get { return this.zinssatz; }
            set { this.zinssatz = value; }
        }

        public int KontoNr
        {
            get { return this.kontoNr; }
        }

        public double Guthaben
        {
            get { return this.guthaben; }
        }

        public Tagesgeld(Konto verrechnungskonto)
        {
            this.verrechnungskonto = verrechnungskonto;
            this.kontoNr = this.verrechnungskonto.KontoNr;
            this.guthaben = 0.0;
            this.zinssatz = 0.0;
        }


    }
}
