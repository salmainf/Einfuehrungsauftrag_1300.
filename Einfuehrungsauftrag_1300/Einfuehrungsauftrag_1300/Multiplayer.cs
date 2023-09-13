using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einfuehrungsauftrag_1300
{
    internal class Multiplayer
    {

        public void Multi()

        {
            try 
            { 
                do
                {
                  
                        int Versuche = 1;



                    

                        Console.WriteLine("Willkommen im Multiplayer Modus! Gebt eure Namen ein:");
                        Console.WriteLine("Spieler 1:");
                        string Name1 = Console.ReadLine();
                        Console.WriteLine("Spieler 2:");
                        string Name2 = Console.ReadLine();

                        Console.WriteLine("Spiel beginnen? [Ja/Nein]");
                        string begin=Console.ReadLine();

                    if (begin == "Ja")
                    {
                        Console.WriteLine(Name1 + " wähle eine Zufallszahl zwischen 1-100:");
                        int Mrnd = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine(Name2 + " errate die Zufallszahl zwischen 1-100:");
                        int rater = Convert.ToInt32(Console.ReadLine());

                        if (rater == Mrnd)
                        {

                            Console.WriteLine("Gratuliere, du hast es richtig erraten!");
                            Console.WriteLine("Anzahl Versuche:" + Versuche);

                            Console.WriteLine("Möchtet ihr nochmals spielen? [Ja/Nein]");
                            string antwort = Console.ReadLine();

                            if (antwort == "Ja")
                            {
                                Versuche = 1;
                                break;

                            }
                            if (antwort == "Nein")
                            {
                                Console.WriteLine("Danke fürs Spielen, bis zum nächsten Mal!");
                                return;
                            }

                        }
                        if (rater != Mrnd)
                        {


                            if (rater < Mrnd)
                            {
                                Versuche++;
                                Console.WriteLine("Die Zahl ist grösser!");
                            }
                            else
                            {
                                Versuche++;
                                Console.WriteLine("Die Zahl ist kleiner!");
                            }

                            Console.WriteLine("Falsch! Raten Sie nochmals:");
                            rater = Convert.ToInt32(Console.ReadLine());


                        }


                    }
                    
                } while (true);
            }
            catch
            {
                Console.WriteLine("Fehlerhafte Eingabe!");
            }
        }
    }
}
