using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Adventure {
    internal class Program {
                
        static void Main(string[] args) {
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

           //Initialisierung NPC 1 in Strand
            Pirat barPirat_1 = new Pirat();
            barPirat_1.SetName("Holzauge");
            barPirat_1.SetOrt(melee.GetKneipe());

           //Initialisierung NPC 1 in Kneipe
            Pirat beachPirat_1 = new Pirat();
            beachPirat_1.SetName("Käptn Iglo");
            beachPirat_1.SetOrt(melee.GetStrand());
           
            //Initialisierung Spielerfigur
            Spielfigur player = new Spielfigur();
            player.SetName("Guybrush Threepwood");
            player.SetOrt(melee.GetStrand());
            player.SetInsel(melee);
            while (player.GetLebt()) {
                string antwort;
                Console.Clear();
                Console.WriteLine($"Sie befinden sich an dem Ort {player.GetOrt().GetName()} auf der Insel {player.GetInsel().GetName()}.");
                Console.WriteLine("Was möchten Sie tun?:\n1) Print Piraten vor Ort\n2) Gegenstände nehmen\n3) Ort wechseln\n4)Gegenstände in Deiner Tasche auflisten");
                if (player.GetOrt().GetName() == "Kneipe") {
                    Console.WriteLine("5)Feiern");
                    antwort = Console.ReadLine();
                    switch (antwort) {
                        case "1":
                        player.GetOrt().PrintPiraten();
                        break;
                        case "2":
                        if (player.GetOrt().IsThereGegenstand()) {
                            player.GetOrt().PrintGegenstaende();
                            Console.WriteLine("Welchen Gegenstand willst Du nehmen?");
                            antwort = Console.ReadLine();
                            Gegenstand x = player.GetOrt().SearchGegenstand(antwort);
                            player.TakeGegenstand(x, player.GetOrt());
                        }
                        else {
                            Console.WriteLine("Hier gibt es keine Gegenstände mehr.");
                        }
                        Console.Read();
                        break;
                        case "3":
                        if (player.GetOrt().GetName() == "Strand") {
                            player.ChangeOrt(player.GetInsel().GetKneipe());
                        }
                        else {
                            player.ChangeOrt(player.GetInsel().GetStrand());
                        }
                        Console.WriteLine("Ort wird gewechselt.");
                        Console.Read();
                        break;
                        case "4":
                        player.PrintGegenstand();
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
                else {
                    Console.WriteLine("5)Schiff benutzen");

                    antwort = Console.ReadLine();
                    switch (antwort) {
                        case "1":
                        player.GetOrt().PrintPiraten();
                        break;
                        case "2":
                        if (player.GetOrt().IsThereGegenstand()) {
                            player.GetOrt().PrintGegenstaende();
                            Console.WriteLine("Welchen Gegenstand willst Du nehmen?");
                            antwort = Console.ReadLine();
                            Gegenstand x = player.GetOrt().SearchGegenstand(antwort);
                            player.TakeGegenstand(x, player.GetOrt());
                        } else {
                            Console.WriteLine("Hier gibt es keine Gegenstände mehr.");
                        }
                        Console.Read();
                        break;
                        case "3":
                        if (player.GetOrt().GetName() == "Strand") {
                            player.ChangeOrt(player.GetInsel().GetKneipe());
                        }
                        else {
                            player.ChangeOrt(player.GetInsel().GetStrand());
                        }
                        Console.WriteLine("Ort wird gewechselt.");
                        Console.Read();
                        break;
                        case "4":
                        player.PrintGegenstand();
                        break;
                        case "5":
                        karibik.PrintInsel();
                        Console.WriteLine("Auf welche Insel willst Du reisen?");
                        antwort= Console.ReadLine();
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