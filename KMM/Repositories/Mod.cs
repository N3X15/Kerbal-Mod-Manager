using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace KMM.Repositories
{
    /// <summary>
    /// Stores data regarding a mod.
    /// </summary>
    public class Mod
    {
        public string Name = "";
        public string Version = "";
        public VersionMatcher KSPVersion = null;
        public string Description = "";
        public List<string> ImageURLs = new List<string>();
        public string URL = "";
        public string Author="";
        public string Thread="";
        public bool Installed = false;

        /// <summary>
        /// For loading a mod metadata file
        /// </summary>
        /// <param name="mod_data"></param>
        public Mod(string mod_data) {
            /*
             * Mission Aeronautics
             * by N3X15
             * Version: 0.0.1
             * URL: http://ci.nexisonline.net/mirror/kerbal/MissionPack0.0.1.zip
             * Requires KSP 0.13.0 to 0.13.1
             * Description: Blah blah blah
             * Thumbnails: http... http...
             * Thread: http...
             */
            foreach (string line in mod_data.Split('\n'))
            {
                if (line.Contains(":") && handleColon(line))
                {
                    ;   
                } 
                else if (line.StartsWith("by "))
                {
                    Author = line.Remove(0, 3).Trim();
                }
                else if (line.StartsWith("Requires KSP "))
                {
                    KSPVersion = new VersionMatcher(line.Remove(0, 13).Trim());
                }
                else
                {
                    Name = line.Trim();
                }
            }
        }

        /// <summary>
        /// For loading from a repository
        /// </summary>
        /// <param name="node"></param>
        public Mod(XmlNode node)
        {
            Name = node.Attributes["name"].Value;
            Version = node.Attributes["version"].Value;
            KSPVersion = new VersionMatcher(node.Attributes["kspversion"].Value);
            Description = node.Attributes["description"].Value;
            URL = node.Attributes["url"].Value;
            Author = node.Attributes["author"].Value;
            Thread = node.Attributes["thread"].Value;
            ImageURLs = new List<string>();
            foreach (XmlNode imgnode in node.ChildNodes)
            {
                if (imgnode.Name.Equals("thumb"))
                {
                    ImageURLs.Add(imgnode.Value);
                }
            }
        }

        private bool handleColon(string line)
        {
            string[] chunks = line.Split(':');
            string key = chunks[0];
            string value = line.Remove(0,line.IndexOf(':')+1).Trim();
            switch (key)
            {
                case "Version":
                    this.Version = value;
                    return true;
                case "URL":
                    this.URL = value;
                    return true;
                case "Description":
                    this.Version = value;
                    return true;
                case "Thumbnails":
                    this.ImageURLs = new List<string>(value.Split(' '));
                    return true;
                case "Thread":
                    this.Thread = value;
                    return true;
            }
            return false;
        }

        /// <summary>
        /// For re-serializing to XML
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public XmlNode toXML(XmlDocument doc)
        {
            throw new NotImplementedException();
        }
    }
}
