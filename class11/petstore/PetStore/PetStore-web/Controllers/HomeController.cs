using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetStore_web.Models;

namespace PetStore_web.Controllers
{
    public class HomeController : Controller
    {
        private PetDBContext db = new PetDBContext();

        // GET: /Home/
        public ActionResult Index()
        {
            var pets = db.Pets.Include(p => p.person);
            return View(pets.ToList());
        }

        // GET: /Invetory/
        public ActionResult Inventory()
        {
            var pets = db.Pets.Include(p => p.person);
            return View(pets.ToList());
        }

        // GET: /Manage/Details/5
        public ActionResult View(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

    }
}
