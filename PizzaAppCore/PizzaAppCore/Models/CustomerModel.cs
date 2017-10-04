using System.Collections.Generic;

namespace PizzaAppCore.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<OrderModel> OrdersModel { get; set; }
    }
}
