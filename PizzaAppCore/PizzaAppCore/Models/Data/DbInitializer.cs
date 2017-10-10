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
            /*
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
                new OrderModel{CustomerModelID = 10029,Note="sth else",OrderDate=DateTime.Now,OrderStatusEnum= Enums.OrderStatusEnum.Todo,PaymentEnum = Enums.PaymentEnum.Credit,TotalCost=14},
                new OrderModel{CustomerModelID = 10029,Note="sth",OrderDate=DateTime.Now,OrderStatusEnum= Enums.OrderStatusEnum.Finished,PaymentEnum = Enums.PaymentEnum.Cash,TotalCost=12}
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
                new PizzaModel{OrderModelID=24, ExtraIngredientsModelID=3019,CrustEnum = Enums.CrustEnum.thick, PizaNameEnum = Enums.PizzaNameEnum.Al_Capone, SizeEnum = Enums.SizeEnum.small},
                new PizzaModel{OrderModelID=24, ExtraIngredientsModelID=3019,CrustEnum = Enums.CrustEnum.thick, PizaNameEnum = Enums.PizzaNameEnum.Al_Capone, SizeEnum = Enums.SizeEnum.small}
            };

            foreach (var p in pizza)
            {
                context.Pizza.Add(p);
            }

            context.SaveChanges();
           */
        }   
    }
}
