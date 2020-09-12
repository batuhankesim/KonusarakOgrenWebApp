using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KonusarakOgrenWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Xml.Linq;
using HtmlAgilityPack;

namespace KonusarakOgrenWebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult CreateExam()
        {
            string RSSURL = "https://www.wired.com/feed/rss";
            WebClient wclient = new WebClient();
            string RSSData = wclient.DownloadString(RSSURL);

            XDocument xml = XDocument.Parse(RSSData);
            var RSSFeedData = (from x in xml.Descendants("item")
                               select new RssModel
                               {
                                   Title = ((string)x.Element("title")),
                                   Link = ((string)x.Element("link")),
                                   Description = ((string)x.Element("description")),
                                   PubDate = ((DateTime)x.Element("pubDate")).ToString("dd/MM/yyyy")
                               }).Take(5);
            ViewBag.RSSFeed = RSSFeedData;
            ViewBag.URL = RSSURL;
            return View();
        }
        public IActionResult Exam(string link)
        {
            var web = new HtmlWeb();
            var linkData = web.Load(link);

            var h1 = linkData.DocumentNode.SelectSingleNode("//h1");
            var p = linkData.DocumentNode.SelectSingleNode("//div[contains(@class, 'article__body')]");
            ViewBag.h1 = h1.InnerText;
            ViewBag.p = p.InnerText;

            return View();
        }

        [HttpPost]
        public JsonResult SinavEkle(ExamModel exam)
        {
            return Json(exam);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
