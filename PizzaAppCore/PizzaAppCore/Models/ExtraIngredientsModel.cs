using System.Collections.Generic;

namespace PizzaAppCore.Models
{
    public class ExtraIngredientsModel
    {
        public int ID { get; set; }
        public bool Chcees { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool Bacon { get; set; }
        public bool Sausage { get; set; }

        public int PizzaModelID { get; set; }
        public PizzaModel PizzaModel { get; set; }
    }
}
