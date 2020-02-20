using System;

namespace ClassAndObjectsBuildings
{
    class Program
    {
        static void Main(string[] args)
        {
            Imobil imobil1 = new Imobil();

            imobil1.tipCasa = "apartamanet";
            imobil1.nrEtaje = 1;
            imobil1.pret = 50000;
            Console.WriteLine("Imobilul este: " + imobil1.tipCasa + "\nAre " + imobil1.nrEtaje + " etaje \nCosta: " + imobil1.pret);

            Imobil imobil2 = new Imobil("casa");
            imobil2.nrEtaje = 2;
            imobil2.pret = 75000;
            Console.WriteLine();
            Console.WriteLine("Imobilul este: " + imobil2.tipCasa + "\nAre " + imobil2.nrEtaje + " etaje \nCosta: " + imobil2.pret);

            Imobil imobil3 = new Imobil("bloc", 10, 10000000);
            Console.WriteLine();
            Console.WriteLine("Imobilul este: " + imobil3.tipCasa + "\nAre " + imobil3.nrEtaje + " etaje \nCosta: " + imobil3.pret);
        }
    }
}
