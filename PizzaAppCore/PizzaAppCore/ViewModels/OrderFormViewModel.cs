using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaAppCore.Models;
using PizzaAppCore.Models.Enums;
using System;
using System.Collections.Generic;

namespace PizzaAppCore.ViewModels
{
    public class OrderFormViewModel
    {
        public CustomerModel CustomerModel { get; set; }
        public ExtraIngredientsModel ExtraIngredients { get; set; }
        public PizzaModel PizzaModel { get; set; }
        public OrderModel OrderModel { get; set; }

        public List<SelectListItem> PizzaNamesEnum { get; set; }
        public List<SelectListItem> PizzaCrustEnum { get; set; }
        public List<SelectListItem> PizzaSizeEnum { get; set; }
        public List<SelectListItem> PaymentEnumm { get; set; }

        public OrderFormViewModel()
        {
            // <option value="0"></option>
            PizzaNamesEnum = new List<SelectListItem>();
            PizzaCrustEnum = new List<SelectListItem>();
            PizzaSizeEnum = new List<SelectListItem>();
            PaymentEnumm = new List<SelectListItem>();

            PizzaNamesEnum.Add(new SelectListItem
            {
                Value = ((int)PizzaNameEnum.Margarita).ToString(),
                Text = PizzaNameEnum.Margarita.ToString()
            });

            PizzaNamesEnum.Add(new SelectListItem
            {
                Value = ((int)PizzaNameEnum.Salami).ToString(),
                Text = PizzaNameEnum.Salami.ToString()
            });

            PizzaNamesEnum.Add(new SelectListItem
            {
                Value = ((int)PizzaNameEnum.Al_Capone).ToString(),
                Text = PizzaNameEnum.Al_Capone.ToString()
            });

            PizzaNamesEnum.Add(new SelectListItem
            {
                Value = ((int)PizzaNameEnum.Hawai).ToString(),
                Text = PizzaNameEnum.Hawai.ToString()
            });

            PizzaCrustEnum.Add(new SelectListItem
            {
                Value = ((int)CrustEnum.thin).ToString(),
                Text = CrustEnum.thin.ToString()
            });

            PizzaCrustEnum.Add(new SelectListItem
            {
                Value = ((int)CrustEnum.thick).ToString(),
                Text = CrustEnum.thick.ToString()
            });

            PizzaSizeEnum.Add(new SelectListItem
            {
                Value = ((int)SizeEnum.small).ToString(),
                Text = SizeEnum.small.ToString()
            });

            PizzaSizeEnum.Add(new SelectListItem
            {
                Value = ((int)SizeEnum.medium).ToString(),
                Text = SizeEnum.medium.ToString()
            });

            PizzaSizeEnum.Add(new SelectListItem
            {
                Value = ((int)SizeEnum.large).ToString(),
                Text = SizeEnum.large.ToString()
            });

            PaymentEnumm.Add(new SelectListItem
            {
                Value = ((int)PaymentEnum.Cash).ToString(),
                Text = PaymentEnum.Cash.ToString()
            });

            PaymentEnumm.Add(new SelectListItem
            {
                Value = ((int)PaymentEnum.Credit).ToString(),
                Text = PaymentEnum.Credit.ToString()
            });
        }
    }
}