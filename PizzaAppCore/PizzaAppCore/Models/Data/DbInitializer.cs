using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAppCore.Models.Data
{
    public class DbInitializer
    {
        public static void Initialize(PizzaAppContext context)
        {
            context.Database.EnsureCreated();

            var customers = new CustomerModel[]
            {
                new CustomerModel{Name="Jozef",Address="OP",Phone="0910200041"}
            };

            foreach (var cust in customers)
            {
                context.Customer.Add(cust);
            }

            context.SaveChanges();

            
            var order = new OrderModel[]
            {
                new OrderModel{CustomerModelID = 10015,Note="sth",OrderDate=DateTime.Now,OrderStatusEnum= Enums.OrderStatusEnum.Finished,PaymentEnum = Enums.PaymentEnum.Cash,TotalCost=12}
            };

            foreach (var or in order)
            {
                context.Order.Add(or);
            }

            context.SaveChanges();
            

            var ingredients = new ExtraIngredientsModel[]
            {
                new ExtraIngredientsModel{Bacon=true,Chcees=false}
            };

            foreach (var ing in ingredients)
            {
                context.ExtraIngredients.Add(ing);
            }

            context.SaveChanges();

            var pizza = new PizzaModel[]
            {
                new PizzaModel{OrderId=1, ExtraIngredientsModelID=1}
            };

            foreach (var p in pizza)
            {
                context.Pizza.Add(p);
            }

            context.SaveChanges();
        }   
    }
}
