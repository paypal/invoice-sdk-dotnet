using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
namespace PayPal.Manager
{
    class Test
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Student><Name>Latha</Name></Student>");
            XmlNodeList nodeList=doc.GetElementsByTagName("Student");
            Console.WriteLine(nodeList[0].ChildNodes[0].InnerText
                );
        }
    }
}
