using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TakeTheBest_Project.Models
{
    public class Menu
    {
        [Display(Name = "ID на ставка")]
        public int menuID { get; set; }
        [Required(ErrorMessage = "Внесете име на ставка")]
        [Display(Name = "Име на ставка")]
        public string menuName { get; set; }
        [Required(ErrorMessage = "Внесете состојки на ставка")]
        [Display(Name = "Состојки")]
        public string menuIngredients { get; set; }
        [Required(ErrorMessage = "Внесете слика на ставка")]
        [Display(Name = "Изглед на ставка")]
        public string menuImage { get; set; }
        [Required(ErrorMessage = "Внесете цена на ставка")]
        [Display(Name = "Цена на ставка")]
        public decimal menuPrice { get; set; }
        [Display(Name = "Препорака за ставка?")]
        public string menuRecommendation { get; set; }
    }
}