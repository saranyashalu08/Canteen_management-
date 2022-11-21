using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CanteenManagementSystem.Models
{
    [Table("MenuItems")]
    public class MenuItems
    {
        [Key]
        [Required(ErrorMessage = "Enter Item Id")]
        public int ItemId { get; set; }
        [Required(ErrorMessage ="Enter Item Name")]
        public string ItemName { get; set; }
        [Required(ErrorMessage ="Enter Catalog Name")]
        public string CatalogName { get; set; }
        [Required(ErrorMessage ="Enter Price")]
        public float ItemPrice { get; set;}
        public string ItemDesc { get; set; }

    }
}