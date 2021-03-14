using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Areas.Admin.Controllers
{
    public class AdminPanelController : Controller
    {
        public ApplicationDbContext _context;

        public AdminPanelController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Admin/AdminPanel
        public ActionResult Dashboard()
        {
            return View();
        }

    }
}