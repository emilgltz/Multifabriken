using System;
namespace multifabriken_emilgltz{
    public class Snören1{
        public string Längd;
        public string Färg;

        public void Snören(){
            Console.WriteLine("Var vänlig och ange den önskade längden på snöret i centimeter");
            Längd = Console.ReadLine();
            int convertLängd = Convert.ToInt32(Längd);
            Console.WriteLine("Var vänlig och ange den önskade färgen på snöret");
            Färg = Console.ReadLine();
            Console.WriteLine($"Din beställning av ett snöre kommer att levereras i längden {convertLängd} " + "centimeter" + $" och vara i färgen {Färg}");
            
        }
        
    }
}