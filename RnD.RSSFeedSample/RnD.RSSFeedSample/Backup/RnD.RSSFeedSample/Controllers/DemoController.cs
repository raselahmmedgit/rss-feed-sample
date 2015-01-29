using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RnD.RSSFeedSample.ViewModels;
using System.Net;
using System.Xml.Linq;

namespace RnD.RSSFeedSample.Controllers
{
    public class DemoController : Controller
    {

        public ActionResult prothomalo()
        {
            var rssFeedViewModelList = new List<RssFeedViewModel>();

            try
            {
                string strRssFeedUrl = "http://blog.raselahmmed.com/feed/";
                rssFeedViewModelList = GetRssFeedData(strRssFeedUrl);

                return View(rssFeedViewModelList);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult ittefaq()
        {
            return View();
        }

        public ActionResult kalerkantho()
        {
            return View();
        }

        public ActionResult jugantor()
        {
            return View();
        }

        public ActionResult amardeshonline()
        {
            return View();
        }

        public ActionResult thedailystar()
        {
            return View();
        }

        public ActionResult newagebd()
        {
            return View();
        }

        public ActionResult thefinancialexpress()
        {
            return View();
        }

        public ActionResult theindependentbd()
        {
            return View();
        }

        private List<RssFeedViewModel> GetRssFeedData(string rssFeedUrl)
        {
            //var client = new WebClient();
            //client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            //var xmlData = client.DownloadString(rssFeedUrl);
            //XDocument xml = XDocument.Parse(xmlData);

            XDocument xml = XDocument.Load(rssFeedUrl);

            var test = xml.Descendants("item");

            List<RssFeedViewModel> rssFeedViewModelList = (from data in xml.Descendants("item")
                                                           select new RssFeedViewModel
                                                           {
                                                               Title = ((string)data.Element("title")),
                                                               Link = ((string)data.Element("link")),
                                                               Description = ((string)data.Element("description")),
                                                               PublishDate = ((string)data.Element("pubDate"))//,
                                                               //ImagePath = ((string)data.Element("enclosure").Attribute("url"))
                                                           }).Take(10).ToList();

            return rssFeedViewModelList;
        }
    }
}
