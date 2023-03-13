namespace Adventure
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Initialisierung Welt
            Meer karibik = new Meer();
            karibik.SetName("Karibik");
            Insel melee = new Insel("Melee", new Kneipe(), new Strand());
            melee.GetStrand().SetName("Strand");
            melee.GetKneipe().SetName("Kneipe");
            karibik.AddInsel(melee);
            Insel monkeyIsland = new Insel("Monkey Island", new Kneipe(), new Strand());
            monkeyIsland.GetStrand().SetName("Strand");
            monkeyIsland.GetKneipe().SetName("Kneipe");
            karibik.AddInsel(monkeyIsland);

            Gegenstand holzbein = new Gegenstand();
            holzbein.SetName("Holzbein");
            melee.GetStrand().Addgegestand(holzbein);
            Gegenstand goldstueck = new Gegenstand();
            goldstueck.SetName("Goldstück ");
            melee.GetStrand().Addgegestand(goldstueck);
            Gegenstand schatzkarte = new Gegenstand();
            schatzkarte.SetName("Schatzkarte von Blakbeard");
            monkeyIsland.GetStrand().Addgegestand(schatzkarte);
            Gegenstand papagei = new Gegenstand();
            papagei.SetName("Polly");
            monkeyIsland.GetKneipe().Addgegestand(papagei);
            Gegenstand hut = new Gegenstand();
            hut.SetName("schwarzer Piratenhut");
            monkeyIsland.GetStrand().Addgegestand(hut);

            //Initialisierung NPCs
            Pirat barPirat_1 = new Pirat();
            barPirat_1.SetName("Holzauge");
            barPirat_1.SetOrt(melee.GetKneipe());
            Pirat beachPirat_1 = new Pirat();
            beachPirat_1.SetName("Käptn Iglo");
            beachPirat_1.SetOrt(melee.GetStrand());
            Pirat barPirat_2 = new Pirat();
            barPirat_2.SetName("Blaubart");
            barPirat_2.SetOrt(monkeyIsland.GetKneipe());
            Pirat beachPirat_2 = new Pirat();
            beachPirat_2.SetName("Freitag");
            beachPirat_2.SetOrt(monkeyIsland.GetStrand());

            //Initialisierung Spielerfigur
            Spielfigur player = new Spielfigur();
            player.SetName("Guybrush Threepwood");
            player.SetOrt(melee.GetStrand());
            player.SetInsel(melee);
            while (player.GetLebt())
            {
                string antwort;
                Console.Clear();
                Console.WriteLine($"Sie befinden sich an dem Ort {player.GetOrt().GetName()} auf der Insel {player.GetInsel().GetName()}.");
                Console.WriteLine("Was möchten Sie tun?:\n1) Print Piraten vor Ort\n2) Gegenstände nehmen\n3) Ort wechseln\n4)Gegenstände in Deiner Tasche auflisten");
                if (player.GetOrt().GetName() == "Kneipe")
                {
                    Console.WriteLine("5)Feiern");
                    antwort = Console.ReadLine();
                    switch (antwort)
                    {
                        case "1":
                            player.GetOrt().PrintPiraten();
                            Console.Read();
                            break;
                        case "2":
                            if (player.GetOrt().IsThereGegenstand())
                            {
                                player.GetOrt().PrintGegenstaende();
                                Console.WriteLine("Welchen Gegenstand willst Du nehmen?");
                                antwort = Console.ReadLine();
                                Gegenstand x = player.GetOrt().SearchGegenstand(antwort);
                                player.TakeGegenstand(x, player.GetOrt());
                            }
                            else
                            {
                                Console.WriteLine("Hier gibt es keinen Gegenstand.");
                            }
                            Console.Read();
                            break;
                        case "3":
                            if (player.GetOrt().GetName() == "Strand")
                            {
                                player.ChangeOrt(player.GetInsel().GetKneipe());
                            }
                            else
                            {
                                player.ChangeOrt(player.GetInsel().GetStrand());
                            }
                            Console.WriteLine("Ort wird gewechselt.");
                            Console.Read();
                            break;
                        case "4":
                            if (player.IsTascheLeer()) {
                                player.PrintGegenstand(); }
                            else
                            {
                                Console.WriteLine("Du hast keinen Gegenstand.");
                            }
                            Console.Read();
                            break;
                        case "5":
                            ((Kneipe)player.GetOrt()).Feiern(player);
                            Console.Read();
                            break;
                        default:
                            Console.WriteLine($"Sorry, die Eingabe: {antwort} war falsch");
                            Console.Read();
                            break;
                    }
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("5)Schiff benutzen");

                    antwort = Console.ReadLine();
                    switch (antwort)
                    {
                        case "1":
                            player.GetOrt().PrintPiraten();
                            Console.Read();
                            break;
                        case "2":
                            if (player.GetOrt().IsThereGegenstand())
                            {
                                player.GetOrt().PrintGegenstaende();
                                Console.WriteLine("Welchen Gegenstand willst Du nehmen?");
                                antwort = Console.ReadLine();
                                Gegenstand x = player.GetOrt().SearchGegenstand(antwort);
                                player.TakeGegenstand(x, player.GetOrt());
                            }
                            else
                            {
                                Console.WriteLine("Hier gibt es keinen Gegenstand.");
                            }
                            Console.Read();
                            break;
                        case "3":
                            if (player.GetOrt().GetName() == "Strand")
                            {
                                player.ChangeOrt(player.GetInsel().GetKneipe());
                            }
                            else
                            {
                                player.ChangeOrt(player.GetInsel().GetStrand());
                            }
                            Console.WriteLine("Ort wird gewechselt.");
                            Console.Read();
                            break;
                        case "4":
                            if (player.IsTascheLeer())
                            {
                                player.PrintGegenstand();
                            }
                            else
                            {
                                Console.WriteLine("Du hast keinen Gegenstand.");
                            }
                            Console.Read();
                            break;
                        case "5":
                            karibik.PrintInsel();
                            Console.WriteLine("Auf welche Insel willst Du reisen?");
                            antwort = Console.ReadLine();
                            Insel y = karibik.SearchInsel(antwort);
                            ((Strand)player.GetOrt()).ChangeInsel(y, player);
                            Console.Read();
                            break;
                        default:
                            Console.WriteLine($"Sorry, die Eingabe: {antwort} war falsch");
                            Console.Read();
                            break;
                    }
                    Console.Read();
                }
            }
        }
    }
}