using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2_ConsoleApp1_1
{
    public class GetMessage
    {
        private ILog _log;
        public GetMessage()
        {
            _log = new Log();
        }
        public List<string> GetMessagesInXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"..\..\Config.xml");

            XmlNode root = xmlDoc.DocumentElement;

            List<string> messages = new List<string>();
            NewMethod(root, messages);

            return messages;
        }

        private static void NewMethod(XmlNode root, List<string> messages)
        {
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "message")
                {
                    messages.Add(node.InnerText);
                }
                if (node.ChildNodes.Count > 0)
                {
                    NewMethod(node, messages);
                }
            }
        }
    }
}
