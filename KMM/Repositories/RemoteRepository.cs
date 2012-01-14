
using System.Collections.Generic;
using System;
using System.Xml;
using System.Net;
namespace KMM.Repositories
{
    /// <summary>
    /// A remotely hosted mod repository.
    /// </summary>
    public class RemoteRepository : Repository
    {
        public Dictionary<string, Mod> mods = new Dictionary<string, Mod>();
        public DateTime LastUpdate { get; set;}
        public string Website { get; set; }
        public string Name { get; set; }
        public string Maintainer { get; set; }
        public string URL {get;set;}

        public RemoteRepository(XmlNode node)
        {
            processCacheNode(node);
        }

        public RemoteRepository() { }

        public virtual bool refresh()
        {
            mods.Clear();
            WebClient wc = new WebClient();
            XmlDocument doc = new XmlDocument();
            string contents = wc.DownloadString(URL);
            doc.LoadXml(contents);
            if (!doc.HasChildNodes)
            {
                return false;
            }
            
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    if (!processCacheNode(node))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        protected bool processCacheNode(XmlNode node)
        {
            switch (node.Name)
            {
                case "repo":
                    this.Website = node.Attributes["website"].Value;
                    this.LastUpdate = DateTime.Parse(node.Attributes["updated"].Value);
                    this.Name = node.Attributes["name"].Value;
                    this.Maintainer = node.Attributes["maintainer"].Value;
                    this.URL = node.Attributes["url"].Value;
                    return true;
                case "mod":
                    Mod mod = new Mod(node);
                    this.mods.Add(mod.Name, mod);
                    return true;
            }
            return false;
        }

        public List<Mod> getMods()
        {
            return new List<Mod>(mods.Values);
        }

        public static bool canHandle(XmlNode node)
        {
            return node.Attributes["type"].Equals("remote");
        }

        /// <summary>
        /// For saving settings (NOT cache)
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public XmlNode toXML(ref XmlDocument doc)
        {
            XmlElement repo = doc.CreateElement("repo");

            repo.SetAttribute("type","remote");
            repo.SetAttribute("name", Name);
            repo.SetAttribute("website", Website);
            repo.SetAttribute("maintainer", Maintainer);
            repo.SetAttribute("lastUpdate", LastUpdate.ToString());

            repo.SetAttribute("url", URL);

            return repo;
        }

        /// <summary>
        /// For saving cache
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public XmlNode toCacheXML(ref XmlDocument doc)
        {
            XmlElement repo = (XmlElement)toXML(ref doc);
            foreach(Mod mod in mods.Values) {
                repo.AppendChild(mod.toXML(doc));
            }
            return repo;
        }
    }
}
