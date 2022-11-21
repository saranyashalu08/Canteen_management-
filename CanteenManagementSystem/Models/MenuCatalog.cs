using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CanteenManagementSystem.Models
{
    [Table("MenuCatalog")]
    public class MenuCatalog
    {
        [Key]
        [Required(ErrorMessage ="Enter Id")]
        public int CatalogId { get; set; }
        [Required(ErrorMessage ="Enter Item name")]
        public string Catalogname { get; set; }

    }
}