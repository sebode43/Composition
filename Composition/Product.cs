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

        public string GetModelName() {
            return Model switch
            {
                ModelType.Bronse => "Bronse",
                ModelType.Silver => "Silver",
                ModelType.Gold => "Gold",
                _=> "No Medal Found"
            };
        }

        public string GetStateName() {
            var stateName = "";
            switch (Model) {
                case ModelType.Gold:
                    stateName = "Ohio";
                    break;
                case ModelType.Silver:
                    stateName = "Indiana";
                    break;
                case ModelType.Bronse:
                    stateName = "Kentucky";
                    break;
                default:
                    stateName = "No State Name Found";
                    break;
            }
            return stateName;
        }

        public Product() { }
    }
}
