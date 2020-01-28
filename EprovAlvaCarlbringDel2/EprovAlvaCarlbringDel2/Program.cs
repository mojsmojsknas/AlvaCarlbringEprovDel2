using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EprovAlvaCarlbringDel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            
        //jag fick hjärnsläpp och orkar inte slösa för mycket prov tid på att få mina while loopar att fungera 
        förlåt:
            Console.WriteLine("hur många bilar ska skapas?");
                      
            string ans = Console.ReadLine();
            

            //min fula lilla kontroll av att det är siffror 
                int result = 0;
               bool works = int.TryParse(ans, out result);

            if (works == true)
            {
                Console.WriteLine("du har " + result + " bilar");
            }

            if (works == false)
            {
                Console.WriteLine("skriv en siffra");
                goto förlåt;
            }

            //en lista där alla de bilar som skapas kommer att läggas i 
            List<Car> cars = new List<Car>();

            //Kommer att göra så många bilar som spelaren skriver in 
            //Slumpar även fram ifall de kommer att ha kontraband eller ej
            for (int i = 0; i < result; result--)
            {
                int number = generator.Next(1, 3);
                if (number == 1)
                {
                    CleanCar c = new CleanCar();
                    cars.Add(c);
                }
                else if (number != 1)
                {
                    ContrabandCar c = new ContrabandCar();
                    cars.Add(c);
                }
                Console.WriteLine(result);
                
                

            }
            





            

            Console.ReadKey();
        }
    }
}
//Wow jag har inte programerat tillräckligt mycket den här terminen