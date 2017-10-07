using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaAppCore.Models;
using PizzaAppCore.Models.Enums;
using System.Collections.Generic;

namespace PizzaAppCore.ViewModels
{
    public class PizzaViewModel
    {
        public PizzaModel PizzaModel { get; set; }
        public List<SelectListItem> PizzaNamesEnum { get; set; }

        public PizzaViewModel()
        {
            // <option value="0"></option>
            PizzaNamesEnum = new List<SelectListItem>();

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

        }
    }
}
