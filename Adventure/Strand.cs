using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure {
    internal class Strand: Ort {
        Schiff schiff;
        public void AddSchiff(Schiff s) {
            schiff = s;
        }
        public void RemoveSchiff(Schiff s) {
            schiff = null;
        }
        public Schiff GetSchiff() {
            return schiff;
        }
    }
}
