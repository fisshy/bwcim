using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bwcim.Controllers
{
    public class TemplateController : Controller
    {
        //
        // GET: /Template/
        public ActionResult Get(string template)
        {
            if (string.IsNullOrEmpty(template))
            {
                return HttpNotFound();
            }
            return View(template);
        }
	}
}