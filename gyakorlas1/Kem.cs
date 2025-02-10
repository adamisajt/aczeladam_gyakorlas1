using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas1
{
    internal class Kem
    {
        private string kodnev;
        private string orszag;
        private int veszelySzint;
        private int sikerEsej;

        public string Kodnev { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public int SikerEsej { get => sikerEsej; set => sikerEsej = value; }

        public Kem(string kodnev, string orszag, int veszelySzint, int sikerEsej)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = veszelySzint;
            this.sikerEsej = sikerEsej;
        }

        public Kem(string kodnev, string orszag)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = 5;
            this.sikerEsej = 50;
        }

        
        public void KuldetesInditasa()
        {
            Console.WriteLine("A küldetés elkezdődött!");
        }

        public void VeszelySzintNovelese(int mennyiseg)
        {
            veszelySzint += mennyiseg;
        }

        public void SikerEsejNovelese(int szazalek)
        {
            sikerEsej += szazalek;
        }

        public override string ToString()
        {
            return $"Kódnév: {kodnev}, Ország: {orszag}, Veszélyszint: {veszelySzint}, Siker esély: {sikerEsej}%";
        }
    }
}
