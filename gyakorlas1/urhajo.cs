using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas1
{
    internal class Urhajo
    {
        private string nev;
        private int sebesseg;
        private int utaskapacitas;
        private double uzemanyagSzint;

        public string Nev { get => nev; set => nev = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
        public double UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }

        public Urhajo(string nev, int sebesseg, int utaskapacitas, double uzemanyagSzint)
        {
            this.nev = nev;
            this.sebesseg = sebesseg;
            this.utaskapacitas = utaskapacitas;
            this.uzemanyagSzint = uzemanyagSzint;
        }

        public Urhajo(string nev, int utaskapacitas)
        {
            this.Nev = nev;
            Sebesseg = 0;
            this.Utaskapacitas=utaskapacitas;
            UzemanyagSzint = 100;
        }



        public void Indulas()
        {
            sebesseg += 10;
            uzemanyagSzint -= 5; 

            if (uzemanyagSzint < 0)
            {
                uzemanyagSzint = 0;
            }
        }

        
        public void Tankolas(int mennyiseg)
        {
            uzemanyagSzint += mennyiseg;

            if (uzemanyagSzint > 100)
            {
                uzemanyagSzint = 100;
            }
        }

        public void Landolas()
        {
            sebesseg = 0;
        }

       
        public override string ToString()
        {
            return $"urhajo neve: {nev}, sebesseg: {sebesseg}, utkapacitas: {utaskapacitas}, uzemanyagszint: {uzemanyagSzint}%";
        }
    }
}
