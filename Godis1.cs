using System;
namespace multifabriken_emilgltz{
    public class Godis1{

        public string smak;
        public string antal;
        public void Godis(){
             Console.WriteLine("Var vänlig och ange den önskade smaken på godiset");
            smak = Console.ReadLine();
            Console.WriteLine("Var vänlig och ange den önskade mängden (en låda innehåller 1kg godis)");
            antal = Console.ReadLine();
            int convertAntal = Convert.ToInt32(antal);
            
            Console.WriteLine("Din godisbeställning kommer levereras efter följande specifikation, " + "Antal lådor: " + $"|{antal}| " + "Smak: " + $"|{smak}|");
            
            
        }
    }
}