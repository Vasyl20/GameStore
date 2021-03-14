using GameStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStore.Entity
{
    [Table("tbPurchase")]
    public class Purchase
    {
        [Key]
        public int IdPurchase { get; set; }
        [ForeignKey("User")]
        public string IdUser { get; set; }
        [ForeignKey("Games")]
        public int IdGames{ get; set; }
        [Required]
        public bool Payment { get; set; }
        
        public virtual Games Games { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}