using System;

namespace Bank
{
    public class Konto
    {
        private static int kontoCount = 0;
        private double guthaben;
        private int kontoNr;

        public double Guthaben
        {
            get
            {
                return this.guthaben;
            }
        }

        public int KontoNr
        {
            get { return kontoNr; }
        }

        public Konto(double guthaben)
        {
            if(guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Eröffnungsbetrag darf nicht negativ sein.");
            }

            this.guthaben = guthaben;
            kontoCount++;
            this.kontoNr = kontoCount;
        }

        public void Einzahlen(double betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(double betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
