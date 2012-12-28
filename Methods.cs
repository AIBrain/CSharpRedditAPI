using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Data;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;

namespace RedditAPI
{
    public class RedditMethods
    {

        public static redditJson GetChannel(string RedditName = "all")
        {
            redditJson rss = null;
            try
            {
                string url = "http://www.reddit.com/r/" + RedditName + ".json";
                WebRequest request = WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = string.Empty;
                    using (response)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        json = reader.ReadToEnd();
                    }
                    rss = JsonConvert.DeserializeObject<redditJson>(json);
                }
            }
            catch (Exception exp)
            {
                throw ;
            }
            return rss;
        }

        public static redditJson GetChannelAfterId( string Id, string RedditName = "all")
        {
            redditJson rss = null;
            string bufferId = string.Empty; 
            int page = 25;
            try
            {
                if (!Id.Contains("t3_"))
                {
                    bufferId = "t3_" + Id;
                }

                string url = string.Empty;
                switch (RedditName.ToLower())
                {
                    case "all":
                    case "hot":
                        url = "http://www.reddit.com/r/" + RedditName + "/.json?count=" + page + "&after=" + bufferId;
                    break;

                    default :
                    url = "http://www.reddit.com/r/" + RedditName + "/.json?count=" + page + "&after=" + bufferId;
                    break;
                }
                WebRequest request = WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = string.Empty;
                    using (response)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        json = reader.ReadToEnd();
                    }
                    rss = JsonConvert.DeserializeObject<redditJson>(json);
                }
            }
            catch
            {
                throw new Exception();
            }
            return rss;
        }

        public static List<redditCommentsJson> GetComments(string RedditName, string id , string title)
        {
            List<redditCommentsJson> rss = null;
            try
            {
                string url = "http://www.reddit.com/comments/" + id + "/" + ".json";
                WebRequest request = WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string json = string.Empty; 
                using (response)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    json = reader.ReadToEnd();
                }
                rss = JsonConvert.DeserializeObject<List<redditCommentsJson>>(json);
            }
            catch(Exception exp)
            {
            }
            return rss;
        }

        public static List<redditCommentsJson> GetCommentsAfterId(string RedditName, string id, string title , string lastCommentId)
        {
            List<redditCommentsJson> rss = null;
            try
            {
                string url = "http://www.reddit.com/comments/" + id + "/" + ".json";
                WebRequest request = WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string json = string.Empty;
                using (response)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    json = reader.ReadToEnd();
                }
                rss = JsonConvert.DeserializeObject<List<redditCommentsJson>>(json);
            }
            catch (Exception exp)
            {
            }
            return rss;
        }


        private static string FixTitle(string title)
        {
            return title.Replace(' ', '_');
        }


        public static redditsSearch SearchReddits(string query)
        {
            redditsSearch rss = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(redditsSearch));
                string url = "http://www.reddit.com/reddits/search.xml?q=" + query;
                WebRequest request = WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (response)
                    {
                        rss = ((redditsSearch)serializer.Deserialize(response.GetResponseStream()));
                    }
                }
            }
            catch
            {
            }
            return rss;
        }

     
    }
}
