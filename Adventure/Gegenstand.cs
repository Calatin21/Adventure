using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure {
    internal class Gegenstand {
        String Name;
        public void SetName(String s) {
            Name = s;
        }
        public String GetName() {
            return Name;
        }
    }
}
