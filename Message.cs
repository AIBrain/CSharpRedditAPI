using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedditAPI
{
    public class redditMessageChildData
    {
        public string body { get; set; }
        public bool was_comment { get; set; }
        public int? first_message { get; set; }
        public string name { get; set; }
        public double created { get; set; }
        public string dest { get; set; }
        public string author { get; set; }
        public double created_utc { get; set; }
        public string body_html { get; set; }
        public object subreddit { get; set; }
        public string parent_id { get; set; }
        public string context { get; set; }
        public string replies { get; set; }
        public bool @new { get; set; }
        public string id { get; set; }
        public string subject { get; set; }
    }

    public class redditMessageChild
    {
        public string kind { get; set; }
        public redditMessageChildData data { get; set; }
    }

    public class redditMessageData
    {
        public string modhash { get; set; }
        public List<redditMessageChild> children { get; set; }
        public object after { get; set; }
        public object before { get; set; }
    }

    public class redditMessage 
    {
        public string kind { get; set; }
        public redditMessageData data { get; set; }
    }
}
