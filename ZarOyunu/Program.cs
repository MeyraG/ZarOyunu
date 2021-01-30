using System;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        // ClassAdı - objeninAdı 
        {
            TavlaZari tavlaZari1 = new TavlaZari(10);
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt() + "-" +tavlaZari1.ZarAt());
           
       
            TavlaZari2 tavlaZari2 = new TavlaZari2(10);
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt() + "-" + tavlaZari2.ZarAt());


            HileliZar hileliZar = new HileliZar(1);
            Console.WriteLine("Zar 3: " + hileliZar.ZarAt() + "-" + hileliZar.ZarAt());

        }
    }
}
