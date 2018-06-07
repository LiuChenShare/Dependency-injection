using ConsoleApp2_4.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp2_4
{
    internal static class ReflectionFactory
    {
        private static string _windowType;
        private static string _buttonType;
        private static string _textBoxtype;

        static ReflectionFactory()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"..\..\Config.xml");
            XmlNode xmlNode = xmlDoc.ChildNodes[1];

            _windowType = xmlNode.ChildNodes[0].ChildNodes[0].Value;
            _buttonType = xmlNode.ChildNodes[1].ChildNodes[0].Value;
            _textBoxtype = xmlNode.ChildNodes[2].ChildNodes[0].Value;
        }

        public static IWindow MakaWindow()
        {
            return Assembly.Load("ConsoleApp2_4").CreateInstance("ConsoleApp2_4.Service." + _windowType) as IWindow;
        }
        public static IButton MakaButton()
        {
            return Assembly.Load("ConsoleApp2_4").CreateInstance("ConsoleApp2_4.Service." + _buttonType) as IButton;
        }
        public static ITextBox MakeTextBox()
        {
            return Assembly.Load("ConsoleApp2_4").CreateInstance("ConsoleApp2_4.Service." + _textBoxtype) as ITextBox;
        }
    }
}
