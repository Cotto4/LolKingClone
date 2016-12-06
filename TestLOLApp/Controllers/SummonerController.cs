using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using TestLOLApp.Content;
using TestLOLApp.Models;

namespace TestLOLApp.Controllers
{
    public class SummonerController : Controller
    {
        // GET: Summoner
        public ActionResult Index(string name)
        {
            Dictionary<string,SummonerDTO> p = APICalls.CallApi<Dictionary<string, SummonerDTO>>("https://na.api.pvp.net", "/api/lol/na/v1.4/summoner/by-name/" + name + "?api_key=");
            SummonerDTO play = p.First().Value;
            var model = APICalls.CallApi<RankedStatsDTO>("https://na.api.pvp.net", "/api/lol/na/v1.3/stats/by-summoner/" + play.id.ToString() + "/ranked?season=SEASON2016&api_key=");
            return View(model);
        }

    }
}