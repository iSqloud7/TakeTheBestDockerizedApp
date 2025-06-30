using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TakeTheBest_Project.Models
{
    public class FoodCategory
    {
        [Key]
        [Display(Name = "ID на категориј    а")]
        public int categoryID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Име")]
        public string categoryName { get; set; }

        [Required]
        [Display(Name = "Опис")]
        public string categoryDescription { get; set; }

        [Display(Name = "Состојки")]
        public string categoryIngredients { get; set; }

        [Display(Name = "Потекло")]
        public string categoryOrigin { get; set; }

        [Range(0, 5)]
        [Display(Name = "Оцена")]
        public double categoryRating { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Цена")]
        public decimal categoryPrice { get; set; }

        [Display(Name = "Изглед")]
        public string categoryImage { get; set; }
    }
}