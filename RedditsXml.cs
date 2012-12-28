using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Runtime.Serialization;
using System.Xml;

namespace RedditAPI
{

    [Serializable()]
    public sealed class redditChildrenDataItem
    {
        [System.Xml.Serialization.XmlElement("domain")]
        public string Domain { get; set; }

        [System.Xml.Serialization.XmlElement("banned_by")]
        public string BannedBy { get; set; }

        [System.Xml.Serialization.XmlElement("media_embed")]
        public string MediaEmbed { get; set; }

       [System.Xml.Serialization.XmlElement("selftext_html")]
       public string SelfTextHtml { get; set; }

       [System.Xml.Serialization.XmlElement("selftext")]
       public string SelfText { get; set; }

       [System.Xml.Serialization.XmlElement("likes")]
       public string Likes { get; set; }

       [System.Xml.Serialization.XmlElement("link_flair_text")]
       public string LinkFlairText { get; set; }

       [System.Xml.Serialization.XmlElement("id")]
       public string ID { get; set; }

       [System.Xml.Serialization.XmlElement("clicked")]
       public string Clicked { get; set; }

       [System.Xml.Serialization.XmlElement("title")]
       public string Title { get; set; }

       [System.Xml.Serialization.XmlElement("num_comments")]
       public string NumberComments { get; set; }

       [System.Xml.Serialization.XmlElement("score")]
       public string Score { get; set; }

       [System.Xml.Serialization.XmlElement("approved_by")]
       public string ApprovedBy { get; set; }

       [System.Xml.Serialization.XmlElement("over_18")]
       public string Over18 { get; set; }

       [System.Xml.Serialization.XmlElement("hidden")]
       public string isHidden { get; set; }

       [System.Xml.Serialization.XmlElement("thumbnail")]
       public string Thumbnail { get; set; }

       [System.Xml.Serialization.XmlElement("subreddit_id")]
       public string SubRedditID { get; set; }

       [System.Xml.Serialization.XmlElement("subreddit")]
       public string SubReddit { get; set; }

       [System.Xml.Serialization.XmlElement("edited")]
       public string Edited { get; set; }

       [System.Xml.Serialization.XmlElement("link_flair_css_class")]
       public string LinkFlairCssClass { get; set; }

       [System.Xml.Serialization.XmlElement("author_flair_css_class")]
       public string AuthorFlairCssClass { get; set; }

       [System.Xml.Serialization.XmlElement("downs")]
       public string DownVotes { get; set; }

       [System.Xml.Serialization.XmlElement("saved")]
       public string Saved { get; set; }

       [System.Xml.Serialization.XmlElement("is_self")]
       public string isSelf { get; set; }
       
       [System.Xml.Serialization.XmlElement("permalink")]
       public string Permalink { get; set; }

       [System.Xml.Serialization.XmlElement("name")]
       public string Name { get; set; }

       [System.Xml.Serialization.XmlElement("created")]
       public string Created {get; set; }

       [System.Xml.Serialization.XmlElement("url")]
       public string Url { get; set; }

       [System.Xml.Serialization.XmlElement("author_flair_text")]
       public string AuthorFlairText { get; set; }

       [System.Xml.Serialization.XmlElement("author")]
       public string Author { get; set; }

       [System.Xml.Serialization.XmlElement("created_utc")]
       public string CreatedUtc { get; set; }
       
       [System.Xml.Serialization.XmlElement("media")]
       public string Media { get; set; }

       [System.Xml.Serialization.XmlElement("num_reports")]
       public string NumberReports { get; set; }

       [System.Xml.Serialization.XmlElement("ups")]
       public string UpVotes { get; set; }
       
    }

    [Serializable()]
    public sealed class redditChildren
    {
        [System.Xml.Serialization.XmlElement("data")]
        public redditChildrenDataItem ChildrenData { get; set; }

        [System.Xml.Serialization.XmlElement("kind")]
        public string Kind { get; set; }
    }

    [Serializable()]
    public class redditData
    {
        [System.Xml.Serialization.XmlElement("modhash")]
        public string ModHash { get; set; }

        [System.Xml.Serialization.XmlElement("children")]
        public List<redditChildren> Children { get; set; }

        [System.Xml.Serialization.XmlElement("before")]
        public string Before { get; set; }

        [System.Xml.Serialization.XmlElement("after")]
        public string After { get; set; }
     }

    [Serializable()]
    [System.Xml.Serialization.XmlRoot("xml")]
    public class redditRss
    {
        [System.Xml.Serialization.XmlElement("kind")]
        public string RedditKind { get; set; }

        [System.Xml.Serialization.XmlElement("data")]
        public redditData SubReddits { get; set; }

        [System.Xml.Serialization.XmlElement("error")]
        public string Error { get; set; }
    }









}


