using System.Collections;

namespace Adventure {
    internal class Ort {
        String name;
        List<Pirat> piraten = new List<Pirat>();
        List<Gegenstand> gegenstaende = new List<Gegenstand>();
        public void SetName(String s) {
            name = s;
        }
        public String GetName() {
            return name;
        }
        public void AddPirat(Pirat p) {
            piraten.Add(p);
        }
        public void RemovePirat(Pirat p) {
            piraten.Remove(p);
        }
        public void PrintPiraten() {
            foreach (Pirat p in piraten) {
                Console.WriteLine(p.GetName());
            }
        }
        public void Addgegestand(Gegenstand g) {
            gegenstaende.Add(g);
        }
        public void RemoveGegenstand(Gegenstand g) {
            gegenstaende.Remove(g);
        }
        public void PrintGegenstaende() {
            foreach (Gegenstand g in gegenstaende) {
                Console.WriteLine(g.GetName());
            }
        }
        public Gegenstand SearchGegenstand(String s) {
            Gegenstand rückgabe = null;
            for (int i = 0; i < gegenstaende.Count; i++) {
                if (gegenstaende[i].GetName() == s) {
                    rückgabe = gegenstaende[i];
                    break;
                }
            }
            return rückgabe;
        }
        public bool IsThereGegenstand() {
            bool ergebnis = false;
            if (gegenstaende.Count() > 0) {
                ergebnis = true;
            }
            return ergebnis;
        }
    }
}
