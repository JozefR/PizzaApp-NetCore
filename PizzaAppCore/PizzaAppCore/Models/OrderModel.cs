using PizzaAppCore.Models.Enums;
using System;
using System.Collections.Generic;

namespace PizzaAppCore.Models
{
    public class OrderModel
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatusEnum OrderStatusEnum { get; set; }
        public PaymentEnum PaymentEnum { get; set; }

        public byte TotalCost { get; set; }
        public string Note { get; set; }

        public int CustomerModelID { get; set; }
        public CustomerModel CustomerModel { get; set; }

        public ICollection<PizzaModel> PizzasModel { get; set; }
    }
}
