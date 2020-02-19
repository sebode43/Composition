using System;
using System.Collections.Generic;
using System.Text;

namespace Composition {

    class GoldWidget : IProduct {

       
        public Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();
           
        }

        public GoldWidget() {
            Product = new Product() {
                Code = "GW", Name = "GoldW", Model = ModelType.Gold
            };
        }

    }
}
