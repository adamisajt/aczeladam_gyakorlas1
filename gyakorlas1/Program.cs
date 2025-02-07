namespace gyakorlas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv1=new("A Kis Herceg","Antione", 1943,96,2500);
            Konyv konyv2 = new("Ez még készül", "én");


            Film film1 = new("oppenheimer", "christopher nolan",180,"történelem",true);
            Film film2 = new("nemtudoooom", "christopher nolan");

            Videojatek videojatek1 = new("xd",17, 40,100);
            Videojatek videojatek2 = new("józsef", 4021);


            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

            konyv1.Kedvezmeny(20);
            konyv1.Arnoveles(1000);

            Console.WriteLine(konyv1.ToString() + "\n" + konyv1.HanyOldalMAradt(20));

            film1.MufajModositasa("dráma");
            film2.HosszNovelese(140);

            Console.WriteLine(film1.ToString() + "\n" + film2.ToString());



            Console.WriteLine(videojatek1.ToString() + "\n" + videojatek2.ToString());



        }
    }
}
