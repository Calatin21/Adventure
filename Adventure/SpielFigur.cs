using System.Collections;

namespace Adventure {
    internal class Spielfigur : Pirat {
        List<Gegenstand> tasche = new List<Gegenstand>();
        bool lebt = true;

        public void TakeGegenstand(Gegenstand g, Ort o) {
            if (g != null) {
                tasche.Add(g);
                o.RemoveGegenstand(g);
            }
        }
        public void PrintGegenstand() {
            foreach (Gegenstand g in tasche) {
                Console.WriteLine(g.GetName());
            }
        }
        public void ChangeOrt(Ort o) {
            this.GetOrt().RemovePirat(this);
            this.SetOrt(o);
        }
        public void SetLebt(bool b) {
            lebt = b;
        }
        public bool GetLebt() {
            return lebt;
        }
    }
}
