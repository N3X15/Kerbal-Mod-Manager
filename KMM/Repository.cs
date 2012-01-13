using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KMM.Repositories;
using System.Xml;

namespace KMM
{
    public interface Repository
    {
        DateTime LastUpdate{get;}
        String Maintainer{get;}
        String Name{get;}
        String Website{get;}

        List<Mod> getMods();
        bool refresh();
        XmlNode toXML();
        bool canHandle(ref XmlNode current);
    }
}
