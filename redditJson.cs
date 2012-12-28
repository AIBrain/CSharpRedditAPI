using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Runtime.Serialization; 
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
   
namespace RedditAPI
{
    public class redditJsonMediaEmbed
    {
        public string content { get; set; }
        public int? width { get; set; }
        public bool? scrolling { get; set; }
        public int? height { get; set; }
    }

    public class redditJsonOembed
    {
        public string provider_url { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public int thumbnail_width { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string html { get; set; }
        public string version { get; set; }
        public string provider_name { get; set; }
        public string thumbnail_url { get; set; }
        public string type { get; set; }
        public int thumbnail_height { get; set; }
    }

    public class redditJsonMedia
    {
        public string type { get; set; }
        public redditJsonOembed oembed { get; set; }
    }

    public class redditJsonChildData
    {
        public string domain { get; set; }
        public object banned_by { get; set; }
        public redditJsonMediaEmbed media_embed { get; set; }
        public string subreddit { get; set; }
        public object selftext_html { get; set; }
        public string selftext { get; set; }
        public object likes { get; set; }
        public string link_flair_text { get; set; }
        public string id { get; set; }
        public bool clicked { get; set; }
        public string title { get; set; }
        public int num_comments { get; set; }
        public int score { get; set; }
        public object approved_by { get; set; }
        public bool over_18 { get; set; }
        public bool hidden { get; set; }
        public string thumbnail { get; set; }
        public string subreddit_id { get; set; }
        public bool edited { get; set; }
        public object link_flair_css_class { get; set; }
        public string author_flair_css_class { get; set; }
        public int downs { get; set; }
        public bool saved { get; set; }
        public bool is_self { get; set; }
        public string permalink { get; set; }
        public string name { get; set; }
        public double created { get; set; }
        public string url { get; set; }
        public string author_flair_text { get; set; }
        public string author { get; set; }
        public double created_utc { get; set; }
        public redditJsonMedia media { get; set; }
        public object num_reports { get; set; }
        public int ups { get; set; }
    }

    public class redditJsonChild
    {
        public string kind { get; set; }
        public redditJsonChildData data { get; set; }
    }

    public class redditJsonData
    {
        public string modhash { get; set; }
        public List<redditJsonChild> children { get; set; }
        public string after { get; set; }
        public object before { get; set; }
    }

    public class redditJson
    {
        public string kind { get; set; }
        public redditJsonData data { get; set; }
    }
  }




