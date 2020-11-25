using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestAspMvc.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }
    }
}