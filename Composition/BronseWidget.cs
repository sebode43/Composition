using System;
using System.Collections.Generic;
using System.Text;

namespace Composition {
    class BronseWidget : IProduct {

        public Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();

        }

        public string GetModelName() {
            return Product.GetModelName();

        }

        public string GetStateName() {
            return Product.GetStateName();

        }

        public BronseWidget() {
            Product = new Product() {
                Code = "BW", Name = "BronseW", Model = ModelType.Bronse
            };
        }

    }
}