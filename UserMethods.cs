using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Web;
using System.Net;
using System.IO;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace RedditAPI
{
    public class UserMethods
    {
        public Dictionary<string, string> m_object_mapping = new Dictionary<string, string>()
        {
            { "comment_kind", "t1"},
            { "message_kind", "t4"},
            { "more_kind", "more"},
            { "redditor_kind", "t2"},
            { "submission_kind", "t3"},
            { "subreddit_kind", "t5"},
            { "userlist_kind", "UserList"}
        };

        public enum Vote
        {
            DownVote = -1,
            RacantVote = 0,
            UpVote = 1
        };

        public static redditLogin Login(string username, string password)
        {
            redditLogin login = null;
            try
            {
                redditRequest request = new redditRequest
                {
                    Url = "http://www.reddit.com/api/login/" + username,
                    Method = "POST",
                    Content = string.Format("api_type=json&user={0}&passwd={1}", username, password)
                };
                string json = string.Empty;
                if (request.Execute(out json) == HttpStatusCode.OK)
                {
                    login = JsonConvert.DeserializeObject<redditLogin>(json);
                    login.UserHandle = username;
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
            return login;
        }

        public static void Logout(redditLogin login)
        {
            redditRequest request;
            string json = string.Empty;
            try
            {
                if (login.Data.Storage == null)
                {
                    throw new Exception("Login Data Null");
                }
                else if (String.IsNullOrEmpty(login.Data.Storage.modhash) || String.IsNullOrEmpty(login.Data.Storage.cookie))
                {
                    throw new Exception("Login Data NULL");
                }
                request = new redditRequest()
                {
                    Url = "http://www.reddit.com/logout?uh=" + login.Data.Storage.modhash,
                    Method = "POST",
                    User = login.UserHandle,
                    Cookie = login.Data.Storage.cookie,
                    Content = "uh=" + login.Data.Storage.modhash + "&top=off"
                };
                if (request.Execute(out json) != HttpStatusCode.OK)
                {
                    throw new Exception(json);
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        public static bool HasMail(redditLogin session)
        {
            redditAbout a = GetMe(session);
            return a.data.has_mail;
        }
        
        public static redditMessageChild ReadMessage(redditLogin session, string id, redditMessage msg)
        {
            redditMessage mail = null;
            if (msg != null)
            {
                mail = msg;
            }
            else
            {
                mail = Inbox(session);
            }
            if (mail.data.children.Capacity > 0)
            {
                foreach (redditMessageChild child in mail.data.children)
                {
                    if (child.data.id == id)
                    {
                        return child;
                    }
                }
            }
            return null;
        }

        public static redditMessage Unread(redditLogin session)
        {
            redditMessage msg = null;
            var request = new redditRequest
            {
                Method = "GET",
                Cookie = session.Data.Storage.cookie,
                User = session.UserHandle,
                Url = "http://www.reddit.com/message/unread/.json"
            };
            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
                throw new Exception(json);
            msg = JsonConvert.DeserializeObject<redditMessage>(json);
            return msg;
        }

        public static redditMessage Inbox(redditLogin session)
        {
           redditMessage msg = null;
           try
           {
               var request = new redditRequest
               {
                   Method = "GET",
                   Cookie = session.Data.Storage.cookie,
                   User = session.UserHandle,
                   Url = "http://www.reddit.com/message/inbox/.json"
               };
               var json = string.Empty;
               if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
                   throw new Exception(json);
               msg = JsonConvert.DeserializeObject<redditMessage>(json); 
           }
           catch
           {
               throw new Exception("Unable To Reach Inbox");
           }
           return msg;
        }

        public static redditAbout GetMe(redditLogin session)
        {
            redditAbout rAbbout = null;
            var request = new redditRequest
            {
                Method = "GET",
                Cookie = session.Data.Storage.cookie,
                User = session.UserHandle,
                Url = "http://www.reddit.com/api/me.json"
            };
            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
                throw new Exception(json);
            rAbbout = JsonConvert.DeserializeObject<redditAbout>(json);
            return rAbbout;
        }

        public static string SendVote(string Full_ID, Vote vote, redditLogin session)
        {
            string buffer = string.Empty;
            try
            {
                var request = new redditRequest
                {
                    Method = "GET",
                    Cookie = session.Data.Storage.cookie,
                    User = session.UserHandle,
                    Url = "http://www.reddit.com/api/me.json"
                };
                var xml = string.Empty;
                if (request.Execute(out xml) != System.Net.HttpStatusCode.OK)
                    throw new Exception(xml);
            }
            catch (Exception exp)
            {

            }
            return buffer;
        }
    }
}
