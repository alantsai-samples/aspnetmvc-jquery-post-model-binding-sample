using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JQueryPostModelBinding.Web.Models;

namespace JQueryPostModelBinding.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(List<FormPostModel> model)
        {
            if (model == null)
            {
                model = new List<FormPostModel>();
            }

            if (model.Count == 0)
            {
                model.Add(new FormPostModel());
                model.Add(new FormPostModel());
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult JqueryPost(List<FormPostModel> model)
        {
            return PartialView(model);
        }
    }
}