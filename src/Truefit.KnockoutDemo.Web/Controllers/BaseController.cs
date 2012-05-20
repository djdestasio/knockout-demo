using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Truefit.KnockoutDemo.Domain;

namespace Truefit.KnockoutDemo.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        [Inject]
        public DemoContext Context { get; set; }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            Context.SaveChanges();
        }
    }
}
