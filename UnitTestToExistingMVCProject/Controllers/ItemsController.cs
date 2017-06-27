using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestToExistingMVCProject.Repositories;

namespace UnitTestToExistingMVCProject.Controllers
{
    public class ItemsController : Controller
    {

        ItemRepository repo = new ItemRepository();


        // GET: Items
        public ActionResult Index(string searchTerm)
        {
            if (searchTerm != null)
            {
                return View(repo.Search(searchTerm));
            }
            else 
            {
                return View(repo.GetAll());
            }
            
        }
    }
}