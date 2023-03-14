namespace Adventure {
    internal class Schiff {
        String name;
        List<Pirat> piraten = new List<Pirat>();
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
        public List<Pirat> PrintPiraten() {
            return piraten;
        }
        public void SchiffFahrt(Insel i, Pirat p) {
            bool streitigkeit;
            Random r = new Random();
            int rInt = r.Next(0, 2);
            streitigkeit = Convert.ToBoolean(rInt);
            this.RemovePirat(p);
            p.GetOrt().RemovePirat(p);
            ((Strand)p.GetOrt()).RemoveSchiff(this);
            i.GetStrand().AddSchiff(this);
            p.SetInsel(i);
            p.SetOrt(i.GetStrand());
            Console.WriteLine();
            if (streitigkeit) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Auf dem Schiff: {this.GetName()} gab es einen Streit unter den Piraten. Du bist über Bord gegangen.\nDen rest des weges zur Insel {i.GetName()} musstest Du schwimmen.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Die Überfahrt der {this.GetName()} verläuft ruhig.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
