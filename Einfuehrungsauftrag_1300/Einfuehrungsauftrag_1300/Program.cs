namespace Einfuehrungsauftrag_1300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiplayer multiplayer = new Multiplayer();
            Limitiert limitiert = new Limitiert();
            try
            {
                int AZVersuche = 1;

                
                

                   


                    

                    int rnd = new Random().Next(1, 100);
                    Console.WriteLine("Wilkommen beim Numberguesser! Errate so schnell wie möglich die Zufallszahl zwischen 1-100.");
                    Console.WriteLine("Möchtest du im Multiplayer oder im Singleplayer Modus spielen?");
                    string Modus = Console.ReadLine();
                    if (Modus == "Multiplayer")
                    {
                        multiplayer.Multi();
                    }
                    while (Modus == "Singleplayer")
                    {
                        Console.WriteLine("Möchten sie im Limitierten Modus[L] mit begrenzten Versuchen oder im normalen Modus[N] spielen?");
                        string Modus2 = Console.ReadLine();
                        while (Modus2 == "L")
                        {
                            limitiert.Limit();

                        }
                       





                            Console.Clear();
                            Console.WriteLine("Ich denke die Zahl ist:");
                            int rater = Convert.ToInt32(Console.ReadLine());


                            if (rater == rnd)
                            {

                                Console.WriteLine("Richtig!! Gratuliere, Sie haben die Zahl richtig erraten.");


                                Console.WriteLine("Ihre Anzahl Versuche: " + AZVersuche);
                                Console.WriteLine("Danke fürs Spielen, bis zum nächsten mal!");
                                break;

                            }
                            else
                            {


                                if (rater < rnd)
                                {
                                    AZVersuche++;
                                    Console.WriteLine("Die Zahl ist grösser!");
                                }
                                else
                                {
                                    AZVersuche++;
                                    Console.WriteLine("Die Zahl ist kleiner!");
                                }

                                Console.WriteLine("Falsch! Raten Sie nochmals:");
                                rater = Convert.ToInt32(Console.ReadLine());
                            }
                        





                       
                        
                    }

                

                

            }
            catch
            {
                Console.WriteLine("Fehlerhafte Eingabe!");
            }


        }
    }
}