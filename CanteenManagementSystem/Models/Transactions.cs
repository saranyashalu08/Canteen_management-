using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanteenManagementSystem.Models
{
    [Table("Transactions")]
    public class Transactions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Transactionsid{get;set;}
        public int Itemid { get;set;}
        public int WaiterId { get;set;}
        public string ItemName { get;set;}
        public float Price { get;set;}
    }
}