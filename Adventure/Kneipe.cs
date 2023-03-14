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
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{p.GetName()} bestellt einen Grog, ext ihn, hustet, kriegt kaum Luft und ist sofort betrunken.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
