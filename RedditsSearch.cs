using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedditAPI
{
    [Serializable()]
    public class redditsSearchItem
    {
        [System.Xml.Serialization.XmlElement("title")]
        public string Title { get; set; }

        [System.Xml.Serialization.XmlElement("link")]
        public string Link { get; set; }

        [System.Xml.Serialization.XmlElement("guid")]
        public string Guid { get; set; }

        [System.Xml.Serialization.XmlElement("dc:date")]
        public string PublishDate { get; set; }

        [System.Xml.Serialization.XmlElement("description")]
        public string Description { get; set; }
    }


    [Serializable()]
    public class redditsSearchChannel
    {
        [System.Xml.Serialization.XmlElement("title")]
        public string Title { get; set; }

        [System.Xml.Serialization.XmlElement("link")]
        public string Link { get; set; }

        [System.Xml.Serialization.XmlElement("description")]
        public string Description { get; set; }



        [System.Xml.Serialization.XmlElement("item")]
        public List<redditsSearchItem> item { get; set; }
    }


    [Serializable()]
    [System.Xml.Serialization.XmlRoot("rss")]
    public class redditsSearch
    {
        [System.Xml.Serialization.XmlElement("channel")]
        public redditsSearchChannel channel { get; set; }
    }

}
