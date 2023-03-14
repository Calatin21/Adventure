namespace Adventure {
    internal class Insel {
        String name;
        Kneipe kneipe = new Kneipe();
        Strand strand = new Strand();
        public void SetName(String s) {
            name = s;
        }
        public String GetName() {
            return name;
        }
        public Kneipe GetKneipe() {
            return kneipe;
        }
        public Strand GetStrand() {
            return strand;
        }
    }
}
