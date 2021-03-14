using GameStore.Entity;
using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class BasketController : Controller
    {

        public ApplicationDbContext _context;

        public BasketController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Basket
        public ActionResult Index()
        {
            var date = _context.Purchases.Select(t => new PurchaseViewModel
            {
                IdPurchase = t.IdPurchase,
                IdUser = t.IdUser,
                IdGames = t.IdGames,
                Payment = t.Payment

            }).ToList();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreatePurchaseViewModel model)
        {
            _context.Purchases.Add(new Purchase
            {
                IdPurchase = model.IdPurchase,
                IdUser = model.IdUser,
                IdGames = model.IdGames,
                Payment = model.Payment
            });
            _context.SaveChanges();

            return RedirectToAction("Index", "Basket");
        }
    }
}