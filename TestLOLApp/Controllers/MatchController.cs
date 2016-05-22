using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLOLApp.Content;
using TestLOLApp.Models;

namespace TestLOLApp.Controllers
{
    public class MatchController : Controller
    {
        // GET: Match
        public ActionResult Index(int id = 2038209760)
        {
            var model = APICalls.CallApi<MatchDetail>("https://na.api.pvp.net", "/api/lol/na/v2.2/match/" + id.ToString() + "?includeTimeline=true&api_key=");
            return View(model);
        }
    }
}