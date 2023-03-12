using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Adventure {
    internal class Kneipe: Ort {
        public void Feiern(Pirat p) {
            Console.WriteLine($"{p.GetName()} gibt sich ein Grog nach dem anderen und wacht am nächsten Morgen mit brummenden Schädel auf.");
        }
        
    }
}
