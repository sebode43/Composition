using System;
using System.Collections.Generic;
using System.Text;

namespace Composition {
    public enum ModelType { Bronse, Silver, Gold };

    public class Product {

        public string Code { get; set; }
        public string Name { get; set; }
        public ModelType Model { get; set; }

        public double GetPrice() {
            return Model switch
            {
                ModelType.Bronse => 20,
                ModelType.Silver => 90,
                ModelType.Gold => 500,
                _ => 0 // everything else
            };
        }

        public Product() { }
    }
}
