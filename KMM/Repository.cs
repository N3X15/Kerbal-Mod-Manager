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
        /// <summary>
        /// The last time this repo was updated
        /// </summary>
        DateTime LastUpdate{get;}

        /// <summary>
        /// Who maintains the repository
        /// </summary>
        String Maintainer{get;}

        /// <summary>
        /// The name of the repository
        /// </summary>
        String Name{get;}

        /// <summary>
        /// Any website associated with the repo
        /// </summary>
        String Website{get;}

        /// <summary>
        /// A list of mods stored within the repo
        /// </summary>
        /// <returns></returns>
        List<Mod> getMods();

        /// <summary>
        /// Read the repo metadata file
        /// </summary>
        /// <returns></returns>
        bool refresh();

        /// <summary>
        /// Reserialize repo
        /// </summary>
        /// <returns></returns>
        XmlNode toXML();

        /// <summary>
        /// Can this repo handler process this XML node?
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        bool canHandle(ref XmlNode current);
    }
}
