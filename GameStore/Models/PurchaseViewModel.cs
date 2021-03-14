using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class PurchaseViewModel
    {
        public int IdPurchase { get; set; }
        public string IdUser { get; set; }
        public int IdGames { get; set; }
        public bool Payment { get; set; }
    }

    public class CreatePurchaseViewModel
    {
        public int IdPurchase { get; set; }
        public string IdUser { get; set; }
        public int IdGames { get; set; }
        public bool Payment { get; set; }
    }
}