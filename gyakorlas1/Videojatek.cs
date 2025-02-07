using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas1
{
    internal class Videojatek
    {
        private string nev;
        private int szint;
        private int eletero;
        private int ero;

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int Ero { get => ero; set => ero = value; }
       


        public Videojatek(string nev, int szint, int eletero, int ero)
        {
            this.Nev = nev;
            this.Szint = szint;
            this.Eletero = eletero;
            this.Ero = ero;
        }

        public Videojatek(string nev, int ero)
        {
            this.Nev = nev;
            Szint = 1;
            Eletero = 100;
            this.Ero = ero;
        }

        
       

        
        public void Tamadas()
        {
            Console.WriteLine($"{Nev} megtámad {Ero} erővel!");
        }

        public void Gyogyulas(int mennyiseg)
        {
            Eletero += mennyiseg;
            Console.WriteLine($"{Nev} gyógyult {mennyiseg} életerővel. Új életereje: {Eletero}");
        }

        public void Szintlepes()
        {
            Szint++;
            Ero += 10; 
            Console.WriteLine($"{Nev} szintet lépett! Új szintje: {Szint}, új ereje: {Ero}");
        }

        public override string ToString()
        {
            return $"Név: {Nev}, Szint: {Szint}, Életerő: {Eletero}, Erő: {Ero}";
        }
    }
}
