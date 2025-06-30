using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace TakeTheBest_Project.Models
{
    public class Customer
    {
        [Display(Name = "ID на клиент")]
        public int customerID { get; set; }
        [Required(ErrorMessage = "Внесете име на клиент")]
        [Display(Name = "Име на клиент")]
        public string customerName { get; set; }
        [Required(ErrorMessage = "Внесете име на клиент")]
        [Display(Name = "Презиме на клиент")]
        public string customerSurname { get; set; }
        [Range(0, 100)]
        [Required(ErrorMessage = "Внесете возраст на клиент")]
        [Display(Name = "Возраст на клиент")]
        public int customerAge { get; set; }
        [Display(Name = "Изглед на клиент")]
        public string customerImage { get; set; }
        private List<Menu> menu { get; set; }
        public Customer()
        {
            menu = new List<Menu>();
        }
        public int restaurantID { get; set; }
        public Restaurant Restaurant { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        [Display(Name = "Број на маса")]
        public int SelectedItemID { get; set; }
    }
}