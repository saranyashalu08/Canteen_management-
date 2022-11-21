using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanteenManagementSystem.Models
{
    [Table]
    public class Admin
    {
        [Required(ErrorMessage = "username is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Required")]

        public string Password { get; set; }
    }
}