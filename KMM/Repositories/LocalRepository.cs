using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace KMM.Repositories
{
    public class LocalRepository:RemoteRepository
    {

        public LocalRepository()
        {
        }

        public bool canHandle(ref XmlNode node)
        {
            return node.Attributes["type"].Equals("local");
        }

        public override bool refresh()
        {
            mods.Clear();
            if (File.Exists("modcache.xml"))
            {
                XmlDocument doc = new XmlDocument();
                string contents = File.ReadAllText("modcache.xml");
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
            }
            return true;
        }

        public void AddMod(Mod mod)
        {
            if (mods.ContainsKey(mod.Name))
                mods.Remove(mod.Name);
            this.mods.Add(mod.Name, mod);
        }

        public void Save()
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(this.toCacheXML(ref doc));
            doc.Save("modcache.xml");
        }
    }
}
