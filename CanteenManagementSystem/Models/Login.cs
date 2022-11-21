using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanteenManagementSystem.Models
{
    [Table("Login")]
    public class Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int WaiterId { get; set; }
        [Required(ErrorMessage ="username is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password should be Same.")]
        public string ConPassword { get; set; }
        public string Firstname { get; set; }
        [Required(ErrorMessage ="Enter First Name")]
        public string Lastname { get; set; }
        public string Phonenumber { get; set; }
        public string TableNo { get; set; }

    }
}