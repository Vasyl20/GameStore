using GameStore.Entity;
using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {

        private ApplicationDbContext _context;

        public GameController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Game
        public ActionResult Index()
        {
            var date = _context.Games.Select(t => new GameViewModel
            {
                Id = t.Id,
                NameGames = t.NameGames,
                GameIcon = t.GameIcon,
                BriefDescription = t.BriefDescription,
                FullDescription = t.FullDescription,
                Category = t.Category,
                Picture1 = t.Picture1,
                Picture2 = t.Picture2,
                Picture3 = t.Picture3,
                Picture4 = t.Picture4

            }).ToList();
            return View(date);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CreateGameViewModel model = new CreateGameViewModel();
            model.Categorys = new List<SelectListItem>();

            model.Categorys.Add(new SelectListItem
            {
                Value = "Shooter",
                Text = "Shooter"
            });

            model.Categorys.Add(new SelectListItem
            {
                Value = "RPG",
                Text = "RPG"
            });

            model.Categorys.Add(new SelectListItem
            {
                Value = "Strategy",
                Text = "Strategy"
            });

            model.Categorys.Add(new SelectListItem
            {
                Value = "Simulator",
                Text = "Simulator"
            });

            model.Categorys.Add(new SelectListItem
            {
                Value = "Horror",
                Text = "Horror"
            });


            return View(model);
        }


        [HttpPost]
        public ActionResult Create(CreateGameViewModel model)
        {
            _context.Games.Add(new Games
            {
                NameGames = model.NameGames,
                GameIcon = model.GameIcon,
                BriefDescription = model.BriefDescription,
                FullDescription = model.FullDescription,
                Category = model.Category,
                Picture1 = model.Picture1,
                Picture2 = model.Picture2,
                Picture3 = model.Picture3,
                Picture4 = model.Picture4
            });
            _context.SaveChanges();

           return RedirectToAction("Index", "Game");
        }



        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                Games games = _context.Games.FirstOrDefault(p => p.Id == id);
                if (games != null)
                {
                    return View(games);
                }
            }

            return HttpNotFound();
        }



    }
}