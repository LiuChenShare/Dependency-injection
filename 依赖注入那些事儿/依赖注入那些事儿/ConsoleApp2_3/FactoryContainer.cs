using ConsoleApp2_3.IService;
using ConsoleApp2_3.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp2_3
{
    internal static class FactoryContainer
    {
        public static IFactory factory { get; private set; }

        static FactoryContainer()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"..\..\Config.xml");
            XmlNode xmlNode = xmlDoc.ChildNodes[1].ChildNodes[0].ChildNodes[0];

            if (xmlNode.Value == "Windows")
            {
                factory = new WindowsFactory();
            }
            else if (xmlNode.Value == "Mac")
            {
                factory = new MacFactory();
            }
            else
            {
                throw new Exception("Factory Init Error");
            }
        }
    }
}
