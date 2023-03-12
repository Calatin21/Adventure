using System.Collections;

namespace Adventure {
    internal class Meer {
        String name;
        ArrayList inseln = new ArrayList();
        ArrayList schiffe = new ArrayList();
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
            foreach (Insel i in inseln) {
                Console.WriteLine(i.GetName());
            }
        }
        public Insel SearchInsel(String s) {
            Insel rückgabe = null;
            for (int i = 0; i < inseln.Count; i++) {
                if (((Insel)inseln[i]).GetName() == s) {
                    rückgabe = ((Insel)inseln[i]);
                    break;
                }
            }
            return rückgabe;
        }
    }
}
