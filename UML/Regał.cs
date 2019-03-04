using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Regał
    {
        public string nazwa;
        private int szerokosc;
        private int dlugosc;
        private int wysokosc;
        protected byte wytrzymalosc;
        public Magazyn magazyn;
        public Regał()
        {

        }
        public Regał(Magazyn magazyn)
        {
            this.magazyn = magazyn;
            var regał = new Regał(magazyn);
            magazyn.RegalList.Add(regał);
        }
        public void Zaladuj()
        {

        }
        public void Oproznij ()
        {

        }

    
    }
}
