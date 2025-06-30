using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TakeTheBest_Project.Models
{
    public class Restaurant
    {
        [Display(Name = "ID на ресторан")]
        public int restaurantID { get; set; }
        [Required(ErrorMessage = "Внесете име на ресторан!!!")]
        [Display(Name = "Име на ресторан")]
        public string restaurantName { get; set; }
        [Required(ErrorMessage = "Внесете адреса на ресторан!!!")]
        [Display(Name = "Адреса на ресторан")]
        public string restaurantAddress { get; set; }
        [Range(1, 5)]
        [Required(ErrorMessage = "Внесете оцена на ресторан!!!")]
        [Display(Name = "Оцена на ресторан")]
        public decimal restaurantRating { get; set; }
        [Display(Name = "Слика на ресторан")]
        public string restaurantImage { get; set; }
        [Display(Name = "Опис на ресторан")]
        public string restaurantDescription { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}