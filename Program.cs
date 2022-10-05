using System;
namespace multifabriken_emilgltz
{
    public class Program
    {
        
        static void Main(string[] args)
        {
         HuvudMeny();
        }
        static void HuvudMeny(){

            Console.Clear();
            Console.WriteLine("Välkommen till multifabriken!");
            Console.WriteLine("Nu kan man äntligen beställa produkter direkt från vår Fabrik.");
            Console.WriteLine("Tillgängliga produkter finner ni i listan nedanför.");
            Console.WriteLine("");
            Console.WriteLine("1.Bilar");
            Console.WriteLine("");
            Console.WriteLine("2.Snören");
            Console.WriteLine("");
            Console.WriteLine("3.Godis");
            Console.WriteLine("");
            Console.WriteLine("4.Tofu");
            Console.WriteLine("");
            Console.WriteLine("5.Avsluta");
            Console.WriteLine("");
            Console.WriteLine("Skriv in en siffra mellan 1-5 för att göra ett val");
            
            string MenyVal;
            MenyVal=Console.ReadLine();
            switch(MenyVal){
                case "1":
                Bilar2 ();
                break;
                case "2":
                Snören2 ();
                break;
                case "3":
                Godis2 ();
                break;
                case "4":
                Tofu2 ();
                break;
                case "5":
                Avsluta ();
                break;
                }
            
           static void Bilar2(){
               Bilar1 bilar1 = new Bilar1();
               bilar1.Bilar();
               }

           static void Snören2(){
               Snören1 snören1 = new Snören1();
               snören1.Snören();
               }

           static void Godis2(){
               Godis1 godis1 = new Godis1();
               godis1.Godis();
               }

           static void Tofu2(){
               Tofu1 tofu1 = new Tofu1();
               tofu1.Tofu();
               }

               static void Avsluta(){
               Console.WriteLine("Är du säker på att du vill avsluta programmet?");
               Console.WriteLine("Tryck på Enter för att avsluta");
               Console.ReadLine();
               System.Environment.Exit(1);
                }
                
             }
                 
        }
                 
 }
