using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas1
{
    internal class Film
    {
        private string cim1;
        private string rendezo;
        private int hossz;
        private string mufaj;
        private bool megjelent;



        public string Cim1 { get => cim1; set => cim1 = value; }
        public string Rendezo { get => rendezo; set => rendezo = value; }
        public int Hossz { get => hossz; set => hossz = value; }
        public string Mufaj { get => mufaj; set => mufaj = value; }
        public bool Megjelent { get => megjelent; set => megjelent = value; }


        public Film(string cim1, string rendezo, int hossz, string mufaj, bool megjelent)
        {
            this.cim1 = cim1;
            this.rendezo = rendezo;
            this.hossz = hossz;
            this.mufaj = mufaj;
            this.megjelent = megjelent;
        }


        public Film(string cim1, string rendezo)
        {
            this.cim1 = cim1;
            this.rendezo = rendezo;
            hossz = 120;
            mufaj = "ismeretlen";
            megjelent = false;
        }


        public void Jatszas()
        {
            Console.WriteLine($"A(z) {cim1} film elkezdődött.");
        }


        public void MufajModositasa(string ujMufaj)
        {
            mufaj = ujMufaj;
            Console.WriteLine($"A(z) {cim1} új műfaja: {mufaj}.");
        }

        public void HosszNovelese(int percek)
        {
            if (percek > 0)
            {
                hossz += percek;
                Console.WriteLine($"A(z) {cim1} film hossza most: {hossz} perc.");
            }
            else
            {
                Console.WriteLine("A hossznöveléshez pozitív számot kell megadni.");
            }
        }
        public override string ToString()
        {
            return $"Cím: {cim1}, Rendező: {rendezo}, Hossz: {hossz} perc, Műfaj: {mufaj}, Megjelent: {(megjelent ? "Igen" : "Nem")}";
        }



    }
}
