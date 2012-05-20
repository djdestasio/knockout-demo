using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Truefit.KnockoutDemo.Domain.Entities;
using Truefit.KnockoutDemo.Domain.Services;
using Truefit.KnockoutDemo.Web.Models;

namespace Truefit.KnockoutDemo.Web.Controllers
{
    public class PeopleController : BaseController
    {
        public IPeopleService PeopleService { get; set; }

        public PeopleController(IPeopleService peopleService)
        {
            PeopleService = peopleService;
        }

        //
        // GET: /People/

        public ActionResult Index()
        {
            var people = PeopleService.All;
            var model = Mapper.Map<IEnumerable<Person>, IEnumerable<PersonModel>>(people);
            return View(model);
        }

        public JsonResult SaveAll(IEnumerable<PersonModel> people)
        {
            return Json("success");
        }

    }
}
