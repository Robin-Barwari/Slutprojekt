using System;

namespace Slutprojekt
{
    class Program
    {
        // Vill användaren försöka igen?
        static string spelaIgen = "Vill du försöka igen? (j/n)";

        // Slumpar fram ett värde
        static Random slump = new Random();

        // Försök igen
        static string försökIgen = "";

        // Tryck på Enter för att fortsätta
        static string fortsättaMedspelet = "Tryck 'Enter' för att fortsätta!";

        // Användaren matar in fel
        static string förstodEj = "Jag förstod inte riktigt vad du sa, tryck på 'Enter' för att skriva igen!";

        static void Main(string[] args)
        {
            Titel();
        }

        /// <summary>
        /// Titel på spelet
        /// </summary>
        static void Titel()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Dr.Lagoos magiska Ö");
            Console.WriteLine(fortsättaMedspelet);
            Console.ReadLine();
            // Börjar spelet efter titel
            Del1();
        }

        /// <summary>
        /// Inledning till spelet med tre alternativa vägar
        /// </summary>
        static void Del1()
        {
            // Vad användaren väljer
            string användarensVal;

            // Intro till spelet
            Console.Clear();
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
                // Ifall användaren väljer brevet
                case "1":
                case "brevet":
                    {
                        BrevetsInnehåll();
                        Console.ReadLine();
                        Console.WriteLine("Du vänder på brevet och ser att det står:");
                        Console.WriteLine("'Kolla på kartan'");
                        UndersökerKarta();
                        Console.ReadLine();
                        HjälpaLagoo();
                        break;
                    }

                // Ifall användaren väljer telefonen
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

                // Ifall användaren väljer kartan
                case "3":
                case "kartan":
                    {
                        UndersökerKarta();
                        Console.WriteLine("Du undersöker fram och baksidan av kartan och märker att det står något på baksidan.");
                        Console.WriteLine("Det står:");
                        Console.WriteLine("'Läs brevet'");
                        Console.ReadLine();
                        Console.WriteLine("Du öppnar kuveret, och det står:");
                        BrevetsInnehåll();
                        Console.ReadLine();
                        HjälpaLagoo();
                        break;
                    }

                default:
                    {
                        Console.WriteLine(förstodEj);
                        Console.ReadLine();
                        Del1();
                        break;
                    }
            }
        }

        /// <summary>
        /// Vill användaren hjälpa Dr.Lagoo?
        /// </summary>
        static void HjälpaLagoo()
        {
            string hjälpaLagoo = "";

            // loopa igenom ifall koden ej känner igen det användaren matar in
            while (hjälpaLagoo != "nej" && hjälpaLagoo != "n" && hjälpaLagoo != "ja" && hjälpaLagoo != "j")
            {
                // alternativ när man förlorat
                Console.Clear();
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
                    Console.WriteLine("Du bestämmer dig för att ta en kort tupp lur.");
                    Console.WriteLine("Du vakna alldrig eftersom du dog av kylan.");
                    Console.ReadLine();
                    Förlust();
                }

                // användaren matar in fel svar
                else
                {
                    Console.WriteLine(förstodEj);
                    Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// Boris ställer en fråga till dig
        /// </summary>
        static void Del2()
        {
            Console.Clear();
            int ålder;

            Console.WriteLine("Du viker ihop pappret och stoppar ner den i fickan.");
            Console.WriteLine("Med bestämda steg så går du mot krysset som är ritad på kartan.");
            Console.WriteLine("När du kommer fram till din destination så ser du Boris sittande på en stol.");
            Console.WriteLine("Boris ser förvånad över att du kommit såhär långt och istället för att slås mot dig så säger han");

            // Hur gammal är du?
            Console.WriteLine("'Jag orkar inte slås mot dig just nu, jag tänker istället fråga dig en frågor, svarar du ärligt så ger jag dig nyckeln.'");
            Console.WriteLine("'Frågan lyder till såhär:'");
            Console.WriteLine("'Hur gammal är du?'");
            int.TryParse(Console.ReadLine(), out ålder);

            // Ifall du är mindre än 70
            while (ålder < 70)
            {
                // Ifall du är högre än 0 men mindre än 70
                if (ålder > 0)
                {
                    Console.WriteLine($"Sluta med dina lögner, du ser ut att vara äldre än {ålder} år.");

                    // Fråga om ålder igen
                    Console.WriteLine("Hur gammal är du igentligen?");
                    int.TryParse(Console.ReadLine(), out ålder);
                }
                else
                {
                    // Ifall du mater in något som inte är en siffra
                    Console.WriteLine("Förstod inte vad du sa.");
                    Console.WriteLine("Hur gammal är du?");
                    int.TryParse(Console.ReadLine(), out ålder);
                }
            }
            Del3();
        }

        static void Del3()
        {
            Console.Clear();
            Console.WriteLine("'Låter rimmligt, här får du nyckeln till kistan'");
            Console.WriteLine(fortsättaMedspelet);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Efter att du fått nyckeln från Boris så bestämmer du dig för att öppna kistan som ligger bakom honom.");
            Console.WriteLine("Kistan är proppfull med guld och olika smycken.");

            Console.WriteLine("Innan du hinner ta något så säger Boris: ");
            Console.WriteLine("'Dr.Lagoo väntar på dig där uppe'");
            Console.WriteLine("Du ser att det finns trappor som ledder upp mot toppen av ett berg.");
            Console.WriteLine(fortsättaMedspelet);
            Console.ReadLine();

            Console.WriteLine("Du går upp för trapporna och ser Lagoo står där uppe med ryggen vänd mot dig, han vekar stirra ut över kusten.");
            Console.WriteLine("Han märker din närvaro och säger:");
            Console.WriteLine("'Jag ser att du har fått tag på nyckeln till kistan du håller i.'");
            Console.WriteLine("'För att ta dig härifrån med min helikopter så måste du svara på en sista fråga.'");
            Console.WriteLine("'Kan du stava ut ditt namn?'");
            Console.WriteLine(fortsättaMedspelet);
            // kallar på metoden Skriv Vertikalt
            SkrivVertikalt(Console.ReadLine());

            Console.WriteLine(fortsättaMedspelet);
            Console.ReadLine();
            Vinst();
        }

        /// <summary>
        /// Skriver ut namnet bokstav för bokstav
        /// </summary>
        /// <param name="namn"></param>
        static void SkrivVertikalt(string namn)
        {
            Console.Clear();
            // Ifall meddelandet har ej tecken så loopas den
            if (String.IsNullOrEmpty(namn))
            {
                // Ifall meddelandet har ej tecken så loopas den
                while (String.IsNullOrEmpty(namn))
                {
                    Console.Clear();
                    Console.WriteLine("(Skriv in ditt namn för att konvertera det)");

                    // Det användaren matar in
                    namn = Console.ReadLine();
                    // Ifall meddelandet har ej tecken så skriver den "försök igen"
                    if (String.IsNullOrEmpty(namn))
                    {
                        Console.WriteLine(förstodEj);
                        Console.ReadLine();
                    }
                    // Om den har tecken så skriver den ut namnet vertikalt
                    else
                    {
                        // Loopa igenom namnet tecken för tecken
                        for (int i = 0; i < namn.Length; i++)
                        {
                            Console.WriteLine(namn[i]);
                        }
                    }
                }
            }
            // Om den har tecken så skriver den ut namnet vertikalt
            else
            {
                // Loopa igenom textan tecken för tecken
                for (int i = 0; i < namn.Length; i++)
                {
                    Console.WriteLine(namn[i]);
                }
            }
        }


        /// <summary>
        /// Du förlora spelet, vill du spela igen eller avsluta?
        /// </summary>
        static void Förlust()
        {
            // slumpar fram ett citat som ska stå på konsolen när du har förlorat
            string[] citatFörlust = {"Wow... det var intressant, visste inte man kunde dö så där.",
            "Du försökte åtminstonde", "Du suger, avinstallera programmet"};
            int slumpmässigNr = slump.Next(0, 3);
            string förlustText = citatFörlust[slumpmässigNr];

            // loopa igenom ifall koden ej känner igen det användaren matar in
            while (försökIgen != "nej" && försökIgen != "n")
            {
                // alternativ när man förlorat
                Console.Clear();
                Console.WriteLine(förlustText);
                Console.WriteLine(spelaIgen);
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
                    Console.WriteLine(förstodEj);
                    Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// Du vinner, vill du spela igen eller avsluta?
        /// </summary>
        static void Vinst()
        {
            while (försökIgen != "nej" && försökIgen != "n")
            {
                // Text när du vinner
                Console.WriteLine("'Jag gratulerar dig, du har lyckats vinna en väldigt kort och dum spel.'");
                Console.WriteLine("'Hoppas du hade det roligt.'");
                Console.WriteLine(spelaIgen);
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
                    Console.WriteLine(förstodEj);
                    Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// Du undersöker kartan
        /// </summary>
        static void UndersökerKarta()
        {
            Console.WriteLine("Du viker upp kartan för att se vart du befinner dig.");
            Console.WriteLine("Det verkar som att du är i hörnet av mappen och måste följa den röda linjen för att ta dig fram till krysset.");
        }


        /// <summary>
        /// Text som står i brevet
        /// </summary>
        static void BrevetsInnehåll()
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
            Console.WriteLine(fortsättaMedspelet);
        }


    }
}
