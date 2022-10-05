using System;



namespace multifabriken_emilgltz{

    
    public class Bilar1{

        public string RegnummerABC;
           public string Regnummer123;
            public string Bilmärke;
            public string Färg;
        public void Bilar(){ 
            
            Console.WriteLine("Ange bilens registreringsnummer med tre bokstäver(Endast A-Z), t.ex ABC");
            RegnummerABC=  Console.ReadLine();
            Console.WriteLine("Ange bilens registreringsnummer med tre siffror, t.ex 123");
            Regnummer123 = Console.ReadLine();
            int Regnummer = Convert.ToInt32(Regnummer123);
            Console.WriteLine("Ange vilket märke bilen ska ha");
            Bilmärke = Console.ReadLine();
            Console.WriteLine("Ange ditt önskemål om färg på bilen");
            Färg = Console.ReadLine();

            Console.WriteLine("Din bil kommer att levereras som följande, " + "Märke: " + $"|{Bilmärke}| " + "Registreringsnummer: " + $"|{RegnummerABC}{Regnummer123}| " + "Färg: " + $"|{Färg}|");
            
        }
    }
}
