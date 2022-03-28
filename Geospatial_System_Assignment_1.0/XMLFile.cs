using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq; 

namespace ICT365_Assignment1
{
    /// <summary>
    /// Singleton class to retrieve XML File using lock method
    /// </summary>
    public class XMLFile
    {
        private static XDocument file = null;
        private static readonly object padlock = new object();

        private XMLFile()
        {
            XDocument file = XDocument.Load(@"..\..\lle-events.xml");
        }
        
        public static XDocument getFile
        {
            get
            {
                if (file == null)
                {
                    lock(padlock)
                    {
                        if (file == null)
                        {
                            file = XDocument.Load(@"..\..\lle-events.xml");
                        }
                    }
                }
                return file;
            } 
        }
    }
}
