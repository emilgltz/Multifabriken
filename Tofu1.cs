using System;
namespace multifabriken_emilgltz{
    public class Tofu1{

        public string kryddning;
        public string volym;
        public void Tofu(){
            Console.WriteLine("Var vänlig och ange den önskade kryddningen på tofun");
            kryddning = Console.ReadLine();
            Console.WriteLine("Var vänlig och ange den önskade volymen i liter (endast heltal)");
            volym = Console.ReadLine();
            int convertAntal = Convert.ToInt32(volym);
            
            Console.WriteLine("Din tofubeställning kommer levereras efter följande specifikation, " + "Volym i liter: " + $"|{volym}| " + "Kryddning: " + $"|{kryddning}|");

        }
        
    }
}