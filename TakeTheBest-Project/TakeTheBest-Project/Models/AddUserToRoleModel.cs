using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TakeTheBest_Project.Models
{
    public class AddUserToRoleModel
    {
        [Required(ErrorMessage = "Внесете адреса за е-пошта!")]
        [EmailAddress(ErrorMessage = "Внесете валидна адреса за е-пошта!")]
        [Display(Name = "Внесете адреса за е-пошта!")]
        public string userEmail {  get; set; }

        public List<string> Roles { get; set; }
        [Display(Name = "Избери улога:")]
        public string selectedRole { get; set; }

        public AddUserToRoleModel()
        {
            Roles = new List<string>();
        }
    }
}