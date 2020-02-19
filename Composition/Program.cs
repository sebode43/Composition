using System;
using System.Collections.Generic;

namespace Composition {
    class Program {
        static void Main(string[] args) {

            var medals = new List<IProduct>();
          for (var idx = 0; idx < 3; idx++) {
                medals.Add(new BronseWidget());
            }
            for (var idx2 = 0; idx2 < 7; idx2++) {
                medals.Add(new SilverWidget());
            }
            for (var idx3 = 0; idx3 < 9; idx3++) {
                medals.Add(new GoldWidget());
            }

            var total = 0.0;
            foreach(var medal in medals) {
                total += medal.GetPrice();
                Console.WriteLine(medal.GetModelName());
                Console.WriteLine(medal.GetStateName());
            }

            Console.WriteLine(total);

        }
    }
}
