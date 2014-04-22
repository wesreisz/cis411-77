using MVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/
        [HttpGet]
        public ActionResult Index()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult GeoCodeAddress(AddressModel model)
        {
            if (ModelState.IsValid)
            {
                GeoResult geoResult = GeoUtil.geoMapAddress(model.InputAddress);
                model.DisplayAddress= String.Format("{0} geocoded at {1}, {2}", geoResult.results[0].formatted_address,
                    geoResult.results[0].geometry.location.lat,
                    geoResult.results[0].geometry.location.lng
               );
            }

            return View("Index", model);
        }

    }
}
