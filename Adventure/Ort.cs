using System.Collections;

namespace Adventure {
    internal class Ort {
        String name;
        ArrayList piraten = new ArrayList();
        ArrayList gegenstaende = new ArrayList();
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
                if (((Gegenstand)gegenstaende[i]).GetName() == s) {
                    rückgabe = ((Gegenstand)gegenstaende[i]);
                    break;
                }
            }
            return rückgabe;
        }
    }
}
