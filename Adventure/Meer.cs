namespace Adventure {
    internal class Meer {
        String name;
        List<Insel> inseln = new List<Insel>();
        Schiff schiff;
        public void SetName(String s) {
            name = s;
        }
        public String Getname() {
            return name;
        }
        public void AddInsel(Insel i) {
            inseln.Add(i);
        }
        public void RemoveInsel(Insel i) {
            inseln.Remove(i);
        }
        public void PrintInsel() {
            int x = 1;
            foreach (Insel i in inseln) {
                Console.WriteLine($"{x}) {i.GetName()}");
                x++;
            }
        }
        public Insel GetInsel(int i) {
            Insel rückgabe = null;
            i = i - 1;
            rückgabe = inseln[i];
            return rückgabe;
        }
        public void AddSchiff(Schiff s) {
            schiff = s;
        }
        public Schiff GetSchiff() {
            return schiff;
        }
    }
}
