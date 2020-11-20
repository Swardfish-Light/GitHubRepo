using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArtNetManager
{
    public class ArtUI_XML
    {
        public const string XML_FILE_NAME = "artnetmanager.xml";
        public const string XML_TAG_ROOT = "artnet-manager";
        public const string XML_TAG_CONFIG = "config";
        public const string XML_TAG_MATRIX = "matrix";
        public const string XML_TAG_PATH = "path";
        public const string XML_TAG_FILE = "file";

        public static XDocument LoadFromXml()
        {      
            XDocument doc;

            try
            {
                doc = XDocument.Load(XML_FILE_NAME);
                return doc;
            }
            catch (Exception)
            {
                return new XDocument(new XElement(XML_TAG_ROOT));
            }
        }

        public static void SaveToXml(XDocument doc)
        {
            doc.Save(ArtUI_XML.XML_FILE_NAME);
        }
    }
}