using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnD.RSSFeedSample.ViewModels
{
    public class RssFeedViewModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImagePath { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
    }
}