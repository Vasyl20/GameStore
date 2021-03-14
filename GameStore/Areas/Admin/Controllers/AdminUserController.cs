using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Areas.Admin.Controllers
{
    public class AdminUserController : Controller
    {

        public ApplicationDbContext _context;

        public AdminUserController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Admin/AdminUser
        public ActionResult Index()
        {
            //var date = _context.Users.Select(t => new GameViewModel
            //{
            //    Full
                
                
            //}).ToList();

            return View();
        }



    }
}