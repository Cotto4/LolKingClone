using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TestLOLApp.Models;
using Newtonsoft.Json;
using TestLOLApp.DAL;
using TestLOLApp.Content;

namespace TestLOLApp.Controllers
{
    public class ChampionController : Controller
    {
        // GET: Champion
        public ActionResult Index(string name)
        {
            Context db = new Context();
            return View(db.Champions.ToList<ChampionIDMap>());
        }

        // GET: ViewChampion
        public ActionResult ViewChampion(int id = 1)
        {
            var c = APICalls.CallApi<ChampionModel>("https://global.api.pvp.net/", "/api/lol/static-data/na/v1.2/champion/" + id.ToString() + "?champData=all&api_key="); 
            return View(c);
        }

    }
}