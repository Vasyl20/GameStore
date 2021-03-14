using GameStore.Entity;
using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Areas.Admin.Controllers
{
    public class AdminGamesController : Controller
    {
        public ApplicationDbContext _context;

        public AdminGamesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Admin/AdminGames
        public ActionResult Index()
        {
            var date = _context.Games.Select(t => new GameViewModel
            {
                Id = t.Id,
                NameGames = t.NameGames,
                GameIcon = t.GameIcon,
                Price = t.Price,
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
        public ActionResult CreateGame()
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
        public ActionResult CreateGame(CreateGameViewModel model)
        {
            _context.Games.Add(new Games
            {
                NameGames = model.NameGames,
                GameIcon = model.GameIcon,
                Price = model.Price,
                BriefDescription = model.BriefDescription,
                FullDescription = model.FullDescription,
                Category = model.Category,
                Picture1 = model.Picture1,
                Picture2 = model.Picture2,
                Picture3 = model.Picture3,
                Picture4 = model.Picture4,

            });
            _context.SaveChanges();

            return RedirectToAction("Index", "AdminGames");
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


        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var deleteGame = _context.Games.FirstOrDefault(t => t.Id == Id);
            if (deleteGame != null)
            {
                _context.Games.Remove(deleteGame);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "AdminGames");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var editGame = _context.Games.Select(s => new CreateGameViewModel
            {
                Id = s.Id,
                NameGames = s.NameGames,
                GameIcon = s.GameIcon,
                Price = s.Price,
                BriefDescription = s.BriefDescription,
                FullDescription = s.FullDescription,
                Category = s.Category,
                Picture1 = s.Picture1,
                Picture2 = s.Picture2,
                Picture3 = s.Picture3,
                Picture4 = s.Picture4
            }).FirstOrDefault(testc => testc.Id == Id);

            editGame.Categorys = new List<SelectListItem>();
            editGame.Categorys.Add(new SelectListItem
            {
                Value = "Shooter",
                Text = "Shooter"
            });

            editGame.Categorys.Add(new SelectListItem
            {
                Value = "RPG",
                Text = "RPG"
            });

            editGame.Categorys.Add(new SelectListItem
            {
                Value = "Strategy",
                Text = "Strategy"
            });

            editGame.Categorys.Add(new SelectListItem
            {
                Value = "Simulator",
                Text = "Simulator"
            });

            editGame.Categorys.Add(new SelectListItem
            {
                Value = "Horror",
                Text = "Horror"
            });

            if (editGame != null)
            {
                return View(editGame);
            }
            else
            {
                return RedirectToAction("Index", "AdminGames");
            }

        }

        [HttpPost]
        public ActionResult Edit(GameViewModel model)
        {
            var editGame = _context.Games.FirstOrDefault(testc => testc.Id == model.Id);
            if (editGame != null)
            {
                editGame.NameGames = model.NameGames;
                editGame.GameIcon = model.GameIcon;
                editGame.Price = model.Price;
                editGame.BriefDescription = model.BriefDescription;
                editGame.FullDescription = model.FullDescription;
                editGame.Category = model.Category;
                editGame.Picture1 = model.Picture1;
                editGame.Picture2 = model.Picture2;
                editGame.Picture3 = model.Picture3;
                editGame.Picture4 = model.Picture4;
                _context.SaveChanges();
                return RedirectToAction("Index", "AdminGames");
            }
            else
            {
                return RedirectToAction("Index", "AdminGames");
            }
           
        }

    }
}