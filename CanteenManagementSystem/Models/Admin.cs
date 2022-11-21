using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanteenManagementSystem.Models
{
    [Table("Admin")]
    public class Admin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "username is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password should be Same.")]
        public string ConPassword { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}