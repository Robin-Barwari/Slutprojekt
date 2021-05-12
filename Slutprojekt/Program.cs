using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Titel();
        }

        /// <summary>
        /// Titel på spelet
        /// </summary>
        static void Titel()
        {
            Console.WriteLine("Välkommen till Dr.Lagoos magiska Ö");
            Console.WriteLine("Tryck 'Enter' för att fortsätta!");
            Console.ReadLine();
            Console.Clear();
            // Börjar spelet efter titel asdddddddddddddddd
            Del1();
        }


        static void Del1()
        {
            string användarensVal;

            // Intro till spelet
            Console.WriteLine("Solen skinner på dig, du vaknar upp i en äng mitt ute i ingenstans.");
            Console.WriteLine("Du känner att det ligger några saker i dina fickor, du lägger ut de framför dig.");
            Console.WriteLine("Du har:");
            Console.WriteLine("Ett brev, en telefon och en karta.");

            Console.WriteLine("Välj en utav dessa tre föremål att examinera:");
            Console.WriteLine("1. Brevet");
            Console.WriteLine("2. Telefonen");
            Console.WriteLine("3. Kartan");

            Console.WriteLine("Ditt val: ");
            användarensVal = Console.ReadLine().ToLower();
            Console.Clear();

            switch (användarensVal)
            {
                case "1":
                case "brevet":
                {
                    Console.WriteLine("Välkommen till min mystiska Ö!");
                    Console.WriteLine("Jag hetter Dr.Lagoo och jag äger allt du ser på denna Ö");
                    Console.WriteLine("Du undrar säkert varför just du är här, sanningen är att jag kidnappa fel person.");
                    Console.WriteLine("Hur som helst, jag behöver din hjälp med att ta tillbaka en nyckel som Boris har stulit.");
                    Console.WriteLine("Nyckeln tillhör en kista som är full med guld");
                    Console.WriteLine("Du måste besegra Boris för att ta tillbaka nyckeln från honom.");
                    Console.WriteLine("Självklart så kommer jag att ge dig hälften av det som ligger i kistan samt en resa tillbaka hem.");
                    Console.WriteLine("Jag förväntar mig din hjälp!");
                    Console.WriteLine("Mvh");
                    Console.WriteLine("Dr.Lagoo");
                    Console.WriteLine("Tryck 'Enter' för att fortsätta!");
                    Console.ReadLine();
                    Alternativ1();
                    break;
                }

                case "2":
                case "telefonen":
                    {
                        Console.WriteLine("Du bestämmer dig för att examinera telefonen.");
                        Console.WriteLine("Det värkar som att den är avstängd, du testar att hålla ner på On/Off knappen och telefonen slås på!");
                        Console.WriteLine("Hurra! Nu kan jag ringa efter hjälp! (tänker du)");
                        Console.WriteLine("Du knappar in siffrorna '112' i telefonen och trycker på call.");
                        Console.WriteLine("Mobilen sprängs i örat på dig och du dör på plats!");  
                        Console.ReadLine();
                        Förlust();
                        break;
                    }

                case "3":
                case "kartan":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Mata in ett giltigt val!");
                        Console.WriteLine("Tryck 'Enter' för att börja om.");
                        Console.ReadLine();
                        Del1();
                        break;
                    }
            }
        }

        static void Alternativ1()
        {
            string hjälpaLagoo = "";

            // loopa igenom ifall koden ej känner igen det användaren matar in
            while (hjälpaLagoo != "nej" && hjälpaLagoo != "n" && hjälpaLagoo != "ja" && hjälpaLagoo != "j")
            {
                // alternativ när man förlorat
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Tänker du hjälpa Dr.Lagoo? (j/n)");
                hjälpaLagoo = Console.ReadLine().ToLower();
                
                // användaren dras tillbaka till början
                if (hjälpaLagoo == "ja" || hjälpaLagoo == "j")
                {
                    Del2();
                }

                // användaren avslutar programmet
                else if (hjälpaLagoo == "nej" || hjälpaLagoo == "n")
                {
                    Console.WriteLine("Du krossar brevet i din hand och rullar ihop det till en liten boll.");
                    Console.WriteLine("Du ställer dig upp för att kasta den så långt som möjligt, sedan sätter du dig ner igen.");
                    Console.WriteLine("Du bestämmer dig för att ta en kort tupp lur");
                    Console.WriteLine("Du vakna alldrig eftersom du dog av hypotermi");
                    Console.ReadLine();
                    Förlust();
                }

                // användaren matar in fel svar
                else
                {
                    Console.WriteLine("Jag förstod inte riktigt vad du sa, tryck på enter för att skriva igen!");
                    Console.ReadLine();
                }
            }
        }

        static void Del2()
        {
            Console.WriteLine("Du viker ihop papret och stoppar ner den i fickan");
        }

        static void Del3()
        {

        }

        /// <summary>
        /// Du förlora spelet och väljer att avsluta eller ej
        /// </summary>
        static void Förlust()
        {
            string försökIgen = "";

            // slumpar fram ett citat som ska stå på konsolen när du har förlorat
            Random rnd = new Random();
            string[] citatFörlust = {"Wow... det var intressant, visste inte man kunde dö så där.",
            "Du försökte åtminstonde", "Du suger, avinstallera programmet"};
            int slumpmässigNr = rnd.Next(0,3);
            string förlustText = citatFörlust[slumpmässigNr];

            // loopa igenom ifall koden ej känner igen det användaren matar in
            while (försökIgen != "nej" && försökIgen != "n")
            {
                // alternativ när man förlorat
                Console.Clear();
                Console.WriteLine(förlustText);
                Console.WriteLine("Vill du försöka igen? (j/n)");
                försökIgen = Console.ReadLine().ToLower();
                
                // användaren dras tillbaka till början
                if (försökIgen == "ja" || försökIgen == "j")
                {
                    Titel();
                }

                // användaren avslutar programmet
                else if (försökIgen == "nej" || försökIgen == "n")
                {
                    Console.WriteLine("Bättre lycka nästa gång!");
                }

                // användaren matar in fel svar
                else
                {
                    Console.WriteLine("Jag förstod inte riktigt vad du sa, tryck på enter för att skriva igen!");
                    Console.ReadLine();
                }
            }
        }

        static void Vinst()
        {
            string försökIgen = "";

            while (försökIgen != "nej" && försökIgen != "n")
            {
                Console.Clear();
                Console.WriteLine("Jag gratulerar dig, du har lyckats vinna en väldigt kort och dum spel.");
                Console.WriteLine("Hoppas du hade det roligt.");
                Console.WriteLine("Vill du spela igen?");
                försökIgen = Console.ReadLine().ToLower();

                // användaren dras tillbaka till början
                if (försökIgen == "ja" || försökIgen == "j")
                {
                    Titel();
                }

                // användaren avslutar programmet
                else if (försökIgen == "nej" || försökIgen == "n")
                {
                    Console.WriteLine("Tack och hej, leverpastej!");
                }

                // användaren matar in fel svar
                else
                {
                    Console.WriteLine("Jag förstod inte riktigt vad du sa, tryck på enter för att skriva igen!");
                    Console.ReadLine();
                }
            }
        }
    }
}
