namespace Adventure {
    internal class Insel {
        String name;
        Kneipe kneipe;
        Strand strand;
        public void SetName(String s) {
            name = s;
        }
        public String GetName() {
            return name;
        }
        public Insel(string name, Kneipe kneipe, Strand strand) {
            this.name = name;
            this.kneipe = kneipe;
            this.strand = strand;
        }
        public Kneipe GetKneipe() {
            return kneipe;
        }
        public Strand GetStrand() {
            return strand;
        }
    }
}
