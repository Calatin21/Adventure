using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure {
    internal class Strand: Ort {
        public void ChangeInsel(Insel i, Pirat p) {
            bool streitigkeit;
            Random r = new Random();
            int rInt = r.Next(0, 2);
            streitigkeit = Convert.ToBoolean(rInt);
            this.RemovePirat(p);
            p.SetInsel(i);
            p.SetOrt(i.GetStrand());
            if (streitigkeit) {
                Console.WriteLine($"Auf dem Schiff gab es einen Streit unter den Piraten. Du bist über Bord gegangen.\nDen rest des weges zur Insel {i.GetName()} musst Du schwimmen.");
                Console.Read();
            } else
            {
                Console.WriteLine("Die Überfahrt verläuft ruhig.");
            }
        }
    }
}
