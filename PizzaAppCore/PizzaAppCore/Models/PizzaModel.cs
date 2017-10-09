using PizzaAppCore.Models.Enums;

namespace PizzaAppCore.Models
{
    public class PizzaModel
    {
        public int ID { get; set; }
        public PizzaNameEnum PizaNameEnum { get; set; }
        public CrustEnum CrustEnum { get; set; }
        public SizeEnum SizeEnum { get; set; }

        public int ExtraIngredientsModelID { get; set; }
        public ExtraIngredientsModel ExtraIngredientsModel { get; set; }

        public int OrderModelID { get; set; }
        public OrderModel OrderModel { get; set; }
    }
}
