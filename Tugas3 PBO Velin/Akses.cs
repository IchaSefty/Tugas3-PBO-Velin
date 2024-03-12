// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Tugas3_PBO_Velin
{
    class Akses
    {
        static void Main(string[] args)
        {
            Otomobil mobil = new Otomobil();
            Sedan toyota = new Sedan();
            Truk hino = new Truk(); 
            SepedaMotor honda = new SepedaMotor();

            toyota.setSedan("Toyota Vios", "Hitam");
            hino.setTruk("Hino 500 Ranger", "Putih");
            honda.setSepedaMotor("Honda Stylo 160", "Hijau");

            (string, string)valuestoyota = toyota.getSedan();
            string toyota1 = valuestoyota.Item1;
            string toyota2 = valuestoyota.Item2;

            (string, string) valueshino = hino.getTruk();
            string hino1 = valueshino.Item1;
            string hino2 = valueshino.Item2;

            (string, string) valueshonda = honda.getSepedaMotor();
            string honda1 = valueshonda.Item1;
            string honda2 = valueshonda.Item2;

            Console.WriteLine($"\nOtomobil" +
                $"\n" +
                $"\nSedan" +
                $"\nModel : {toyota1}" +
                $"\nWarna : {toyota2}" +
                $"\n" +
                $"\nTruk" +
                $"\nModel : {hino1}" +
                $"\nWarna : {hino2}" +
                $"\n" +
                $"\nSepeda Motor" +
                $"\nModel : {honda1}" +
                $"\nWarna : {honda2}");
             


        }
    }
}