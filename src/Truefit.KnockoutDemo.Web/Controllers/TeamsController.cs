using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Truefit.KnockoutDemo.Web.Models;

namespace Truefit.KnockoutDemo.Web.Controllers
{
    public class TeamsController : Controller
    {
        //
        // GET: /Teams/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new TeamModel());
        }
    }
}
