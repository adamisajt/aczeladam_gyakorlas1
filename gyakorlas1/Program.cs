namespace gyakorlas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv1=new("A Kis Herceg","Antione", 1943,96,2500);
            Konyv konyv2 = new("Ez még készül", "én");
            
            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

            konyv1.Kedvezmeny(20);
            konyv1.Arnoveles(1000);

            Console.WriteLine(konyv1.ToString() + "\n" + konyv1.HanyOldalMAradt(20));
            
            




        }
    }
}
