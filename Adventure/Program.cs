namespace Adventure {
    internal class Program {

        static void Main(string[] args) {
            //Deklaration & Initialisierung Welt
            Meer karibik = new Meer();
            karibik.SetName("Karibik");
            Insel melee = new Insel();
            melee.SetName("Mêlée");
            melee.GetStrand().SetName("Strand");
            melee.GetKneipe().SetName("Kneipe");
            karibik.AddInsel(melee);
            Insel monkeyIsland = new Insel();
            monkeyIsland.SetName("Monkey Island");
            monkeyIsland.GetStrand().SetName("Strand");
            monkeyIsland.GetKneipe().SetName("Kneipe");
            karibik.AddInsel(monkeyIsland);
            karibik.AddSchiff(new Schiff());
            karibik.GetSchiff().SetName("Black Pearl");
            melee.GetStrand().AddSchiff(karibik.GetSchiff());

            //Deklaration & Initialisierung von Gegenständen
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

            //Deklaration & Initialisierung NPCs
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

            //Deklaration & Initialisierung Spielerfigur
            Spielfigur player = new Spielfigur();
            player.SetName("Guybrush Threepwood");
            player.SetOrt(melee.GetStrand());
            player.SetInsel(melee);

            //while loop gibt immer wieder das Menu zur auswahl der aktionen des Spielers zur auswahl
            while (player.GetLebt()) {
                string antwort;
                ConsoleKeyInfo ant;
                int x = 0;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Sie befinden sich an dem Ort: {player.GetOrt().GetName()} auf der Insel: {player.GetInsel().GetName()}.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("Was möchten Sie tun?:\n1) Print Piraten vor Ort\n2) Gegenstände nehmen\n3) Ort wechseln\n4)Gegenstände in Deiner Tasche");
                if (player.GetOrt().GetName() == "Kneipe") {
                    Console.WriteLine("5)Feiern");
                    ant = Console.ReadKey();
                    if (Char.IsDigit(ant.KeyChar)) {
                        x = int.Parse(ant.KeyChar.ToString());
                        switch (x) {
                            case 1:
                            Console.WriteLine();
                            player.GetOrt().PrintPiraten();
                            Console.Read();
                            break;
                            case 2:
                            Console.WriteLine();
                            if (player.GetOrt().IsThereGegenstand()) {
                                player.GetOrt().PrintGegenstaende();
                                Console.WriteLine("Welchen Gegenstand willst Du nehmen?");
                                ant = Console.ReadKey();
                                if (Char.IsDigit(ant.KeyChar)) {
                                    x = int.Parse(ant.KeyChar.ToString());
                                    Gegenstand g = player.GetOrt().GetGegenstand(x);
                                    player.TakeGegenstand(g, player.GetOrt());
                                }
                                else {
                                    Console.WriteLine("Bitte eine Zahl eingeben.");
                                    Console.Read();
                                }
                            }
                            else {
                                Console.WriteLine("Hier gibt es keinen Gegenstand.");
                            }
                                Console.Read();
                            
                            break;
                            case 3:
                            Console.WriteLine();
                            if (player.GetOrt().GetName() == "Strand") {
                                player.ChangeOrt(player.GetInsel().GetKneipe());
                            }
                            else {
                                player.ChangeOrt(player.GetInsel().GetStrand());
                            }
                            Console.WriteLine("Ort wird gewechselt.");
                            Console.Read();
                            break;
                            case 4:
                            Console.WriteLine();
                            if (player.IsTascheLeer()) {
                                player.PrintGegenstand();
                            }
                            else {
                                Console.WriteLine("Du hast keinen Gegenstand.");
                            }
                            Console.Read();
                            break;
                            case 5:
                            Console.WriteLine();
                            ((Kneipe)player.GetOrt()).Feiern(player);
                            Console.Read();
                            break;
                            default:
                            Console.WriteLine();
                            Console.WriteLine($"Sorry, die Eingabe: {ant} war falsch");
                            Console.Read();
                            break;
                        }
                        Console.Read();
                    }
                    else {
                        Console.WriteLine("Bitte eine Zahl eingeben.");
                        Console.Read();
                    }
                }
                else {
                    Console.WriteLine("5)Schiff benutzen");

                    ant = Console.ReadKey();
                    if (Char.IsDigit(ant.KeyChar)) {
                        x = int.Parse(ant.KeyChar.ToString());
                        switch (x) {
                            case 1:
                            Console.WriteLine();
                            player.GetOrt().PrintPiraten();
                            Console.Read();
                            break;
                            case 2:
                            Console.WriteLine();
                            if (player.GetOrt().IsThereGegenstand()) {
                                player.GetOrt().PrintGegenstaende();
                                Console.WriteLine("Welchen Gegenstand willst Du nehmen?");
                                ant = Console.ReadKey();
                                if (Char.IsDigit(ant.KeyChar)) {
                                    x = int.Parse(ant.KeyChar.ToString());
                                    Gegenstand g = player.GetOrt().GetGegenstand(x);
                                    player.TakeGegenstand(g, player.GetOrt());
                                }
                                else {
                                    Console.WriteLine("Bitte eine Zahl eingeben.");
                                    Console.Read();
                                }
                            }
                            else {
                                Console.WriteLine("Hier gibt es keinen Gegenstand.");
                            }
                            Console.Read();

                            break;
                            case 3:
                            Console.WriteLine();
                            if (player.GetOrt().GetName() == "Strand") {
                                player.ChangeOrt(player.GetInsel().GetKneipe());
                            }
                            else {
                                player.ChangeOrt(player.GetInsel().GetStrand());
                            }
                            Console.WriteLine("Ort wird gewechselt.");
                            Console.Read();
                            break;
                            case 4:
                            Console.WriteLine();
                            if (player.IsTascheLeer()) {
                                player.PrintGegenstand();
                            }
                            else {
                                Console.WriteLine("Du hast keinen Gegenstand.");
                            }
                            Console.Read();
                            break;
                            case 5:
                            Console.WriteLine();
                            Console.WriteLine();
                            karibik.PrintInsel();
                            Console.WriteLine("Auf welche Insel willst Du reisen?");
                            ant = Console.ReadKey();
                            if (Char.IsDigit(ant.KeyChar)) {
                                x = int.Parse(ant.KeyChar.ToString());
                                Insel y = karibik.GetInsel(x, player.GetInsel());
                                ((Strand)player.GetOrt()).GetSchiff().AddPirat(player);
                                karibik.GetSchiff().SchiffFahrt(y, player);
                                Console.Read();
                            }
                            else {
                                Console.WriteLine("Bitte eine Zahl eingeben.");
                                Console.Read();
                            }
                            break;
                            default:
                            Console.WriteLine();
                            Console.WriteLine($"Sorry, die Eingabe: {ant} war falsch");
                            Console.Read();
                            break;
                        }
                        Console.Read();
                    }
                    else {
                        Console.WriteLine("Bitte eine Zahl eingeben.");
                        Console.Read();
                    }
                }
            }
        }
    }
}