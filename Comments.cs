using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Runtime.Serialization;
using System.Xml;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

//This is Ugly, have to add Comments and JSON Property Tags
namespace RedditAPI
{
    public class redditCommentSubCommentsRepliesChildData
    {
        public string subreddit_id { get; set; }
        public object banned_by { get; set; }
        public string link_id { get; set; }
        public object likes { get; set; }
        public string replies { get; set; }
        public string id { get; set; }
        public int gilded { get; set; }
        public string author { get; set; }
        public string parent_id { get; set; }
        public object approved_by { get; set; }
        public string body { get; set; }
        public bool edited { get; set; }
        public object author_flair_css_class { get; set; }
        public int downs { get; set; }
        public string body_html { get; set; }
        public string subreddit { get; set; }
        public string name { get; set; }
        public double created { get; set; }
        public object author_flair_text { get; set; }
        public double created_utc { get; set; }
        public object num_reports { get; set; }
        public int ups { get; set; }
    }

    public class redditCommentSubCommentsRepliesChild
    {
        public string kind { get; set; }
        public redditCommentSubCommentsRepliesChildData data { get; set; }
    }

    public class redditCommentSubCommentsRepliesData
    {
        public string modhash { get; set; }
        public List<redditCommentSubCommentsRepliesChild> children { get; set; }
        public object after { get; set; }
        public object before { get; set; }
    }

    public class redditCommentSubCommentsReplies
    {
        public string kind { get; set; }
        public redditCommentSubCommentsRepliesData data { get; set; }
    }

    public class redditCommentSubCommentsChildData
    {
        public string subreddit_id { get; set; }
        public object banned_by { get; set; }
        public string link_id { get; set; }
        public object likes { get; set; }
        public redditCommentSubCommentsReplies replies { get; set; }
        public string id { get; set; }
        public int gilded { get; set; }
        public string author { get; set; }
        public string parent_id { get; set; }
        public object approved_by { get; set; }
        public string body { get; set; }
        public bool edited { get; set; }
        public object author_flair_css_class { get; set; }
        public int downs { get; set; }
        public string body_html { get; set; }
        public string subreddit { get; set; }
        public string name { get; set; }
        public double created { get; set; }
        public object author_flair_text { get; set; }
        public double created_utc { get; set; }
        public object num_reports { get; set; }
        public int ups { get; set; }
    }

    public class redditCommentSubCommentsChild
    {
        public string kind { get; set; }
        public redditCommentSubCommentsChildData data { get; set; }
    }

    public class redditCommentSubCommentsData
    {
        public string modhash { get; set; }
        public List<redditCommentSubCommentsChild> children { get; set; }
        public object after { get; set; }
        public object before { get; set; }
    }

    public class redditCommentSubComments
    {
        public string kind { get; set; }
        public redditCommentSubCommentsData data { get; set; }
    }


    public class redditCommentRepliesChildData
    {
        public string subreddit_id { get; set; }
        public object banned_by { get; set; }
        public string link_id { get; set; }
        public object likes { get; set; }
       
        [JsonProperty("replies")]
        public object commentReplies { get; set; }
        public string id { get; set; }
        public int gilded { get; set; }
        public string author { get; set; }
        public string parent_id { get; set; }
        public object approved_by { get; set; }
        public string body { get; set; }
        public object edited { get; set; }
        public object author_flair_css_class { get; set; }
        public int downs { get; set; }
        public string body_html { get; set; }
        public string subreddit { get; set; }
        public string name { get; set; }
        public double created { get; set; }
        public object author_flair_text { get; set; }
        public double created_utc { get; set; }
        public object num_reports { get; set; }
        public int ups { get; set; }
        public int? count { get; set; }
        public List<string> children { get; set; }
    }

    public class redditCommentRepliesChild
    {
        public string kind { get; set; }
        public redditCommentRepliesChildData data { get; set; }
    }

    public class redditCommentRepliesData
    {
        public string modhash { get; set; }
        public List<redditCommentRepliesChild> children { get; set; }
        public object after { get; set; }
        public object before { get; set; }
    }

    public class redditCommentReplies
    {
        public string kind { get; set; }
        public redditCommentRepliesData data { get; set; }
    }

    public class redditCommentsEmbedMedia
    {
    }

    public class redditCommentsChildData
    {
        public string domain { get; set; }
        public object banned_by { get; set; }
        public redditCommentsEmbedMedia media_embed { get; set; }
        public string subreddit { get; set; }
        public object selftext_html { get; set; }
        public string selftext { get; set; }
        public object likes { get; set; }
        public object link_flair_text { get; set; }
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
        public object edited { get; set; }
        public object link_flair_css_class { get; set; }
        public object author_flair_css_class { get; set; }
        public int downs { get; set; }
        public bool saved { get; set; }
        public bool is_self { get; set; }
        public string permalink { get; set; }
        public string name { get; set; }
        public double created { get; set; }
        public string url { get; set; }
        public object author_flair_text { get; set; }
        public string author { get; set; }
        public double created_utc { get; set; }
        public object media { get; set; }
        public object num_reports { get; set; }
        public int ups { get; set; }
        public string link_id { get; set; }
        [JsonProperty("replies")]
        public redditCommentReplies CommentReplies { get; set; }
        public int? gilded { get; set; }
        public string parent_id { get; set; }
        public string body { get; set; }
        public string body_html { get; set; }
        public int? count { get; set; }
        public List<string> children { get; set; }
    }

    public class redditCommentsChild
    {
        public string kind { get; set; }
        public redditCommentsChildData data { get; set; }
    }

    public class redditCommentsData
    {
        public string modhash { get; set; }
        public List<redditCommentsChild> children { get; set; }
        public object after { get; set; }
        public object before { get; set; }
    }

    public class redditCommentsJson
    {
        public string kind { get; set; }
        public redditCommentsData data { get; set; }
    }
}


