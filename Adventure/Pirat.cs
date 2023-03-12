namespace Adventure {
    internal class Pirat {
        String name;
        Ort ort;
        Insel insel;
        public void SetName(String s) {
            name = s;
        }
        public String GetName() {
            return name;
        }
        public void SetOrt(Ort o) {
            ort = o;
            o.AddPirat(this);
        }
        public Ort GetOrt() {
            return ort;
        }
        public void SetInsel(Insel i) {
            insel = i;
        }
        public Insel GetInsel() {
            return insel;
        }
    }
}
