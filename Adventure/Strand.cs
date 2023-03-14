namespace Adventure {
    internal class Strand : Ort {
        Schiff schiff;
        public void SetSchiff(Schiff s) {
            schiff = s;
        }
        public Schiff GetSchiff() {
            return schiff;
        }
    }
}
