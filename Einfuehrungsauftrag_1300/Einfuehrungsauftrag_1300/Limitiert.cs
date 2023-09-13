using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einfuehrungsauftrag_1300
{
    internal class Limitiert
    {
        public void Limit()
        {
           


                do
                {
                try
                {



                    int maxAttempts = 5;
                int attempts = 1;


                    
                    
                        Console.Clear();

                        int rnd = new Random().Next(1, 100);
                        Console.WriteLine("Errate die Zahl mit nur mit 5 Versuchen!");
                        Console.WriteLine("Ich denke die Zahl ist:");
                        int rater = Convert.ToInt32(Console.ReadLine());

                        if(rater == rnd)
                        {

                            Console.WriteLine("Richtig!! Gratuliere, Sie haben die Zahl richtig erraten, mit nur 5 Versuchen.");
                            break;
                        }
                        else
                        {
                            if(rater < rnd)
                            {

                                Console.WriteLine("Falsch! Die Zahl ist grösser!");
                            }
                            else 
                            {

                                Console.WriteLine("Falsch! Die Zahl ist kleiner!");

                            }while (attempts != maxAttempts) ;

                        }

                        while (attempts == maxAttempts)
                        {
                            Console.WriteLine("Verloren!! Du hast alle Versuche aufgebraucht");
                        }
                    

                }
                catch
                {
                Console.WriteLine("Fehlerhafte Eingabe!");
                }

             } while (true);
        }    
    }
}
    





            



        
    


