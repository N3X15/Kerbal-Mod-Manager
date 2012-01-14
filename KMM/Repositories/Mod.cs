using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace KMM.Repositories
{
    /// <summary>
    /// Stores data regarding a mod.
    /// </summary>
    public class Mod:DataGridViewRow
    {
        public string Name = "";
        public string Version = "";
        public VersionMatcher KSPVersion = null;
        public string Description = "";
        public List<string> ImageURLs = new List<string>();
        public List<string> Files = new List<string>();
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

        public void findMyFiles()
        {
            Files.Clear();
            do_filesearch(getFolder());
        }

        private void do_filesearch(string folder)
        {
            DirectoryInfo dir = new DirectoryInfo(folder);
            foreach (FileSystemInfo fsi in dir.GetFileSystemInfos("*",SearchOption.TopDirectoryOnly))
            {
                if (fsi is DirectoryInfo)
                {
                    do_filesearch(Path.Combine(folder, fsi.Name));
                }
                if (fsi is FileInfo)
                {
                    Files.Add(Path.Combine(folder, fsi.Name).Replace(getFolder(),""));
                }
            }
        }

        private string getFolder()
        {
            return Path.Combine("mods", Name.Replace(" ", ""));
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
                if(imgnode.NodeType == XmlNodeType.Element) 
                {
                    if (imgnode.Name.Equals("thumb"))
                    {
                        ImageURLs.Add(imgnode.Value);
                    }
                    if (imgnode.Name.Equals("file"))
                    {
                        Files.Add(imgnode.Value);
                    }
                }
            }
        }

        public Mod()
        {
            // TODO: Complete member initialization
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
            /**
             * <mod 
             *  name="Range Safety Device" 
             *  version="0.0.1" 
             *  kspversion="0.13.0 to 0.13.1"
             *  description="butts"
             *  url="http..."
             *  author="N3X15"
             *  thread="http...">
             *    <thumb>img/thumbs/whatever.png</thumb>
             *    <file>Parts/MISSION_Range%20Safety%20Device/part.cfg</file>
             * </mod>
             */
            XmlElement mod = doc.CreateElement("mod");
            mod.SetAttribute("name", Name);
            mod.SetAttribute("version", Version);
            mod.SetAttribute("kspversion", KSPVersion.ToString());
            mod.SetAttribute("description", Description);
            mod.SetAttribute("url", URL);
            mod.SetAttribute("author", Author);
            mod.SetAttribute("thread", Thread);

            foreach (string thumb in ImageURLs)
            {
                XmlElement thumbnode = doc.CreateElement("thumb");
                thumbnode.Value = thumb;
                mod.AppendChild(thumbnode);
            }

            foreach (string file in Files)
            {
                XmlElement filenode = doc.CreateElement("file");
                filenode.Value = file;
                mod.AppendChild(filenode);
            }

            return mod;
        }
    }
}
