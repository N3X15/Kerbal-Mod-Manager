using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KMM.Repositories
{
    internal class InvalidVersionException : Exception
    {
        private string message="";
        public InvalidVersionException(string p)
        {
            this.message = p;
        }

        public string Message
        {
            get { return message; }
        }
    }
}
