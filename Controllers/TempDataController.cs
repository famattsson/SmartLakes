using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Logic;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult GetData(string fromDate, string toDate)
        {
            List<string> locations = new List<string>();
            if(Session["locations"] != null)
            {
                foreach (string location in ((string)Session["locations"]).Split(','))
                {
                    locations.Add(location);
                }
            }
            return View("TempDataView", TempDataHandler.GetRecords(fromDate, toDate, locations));
        }

        public ActionResult ChooseLocation(string id)
        {
            Session["locations"] = id;
            return new EmptyResult();
        }
    }
}