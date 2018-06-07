using ConsoleApp2_4.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindow window = ReflectionFactory.MakaWindow();
            IButton button = ReflectionFactory.MakaButton();
            ITextBox textBox = ReflectionFactory.MakeTextBox();

            //IWindow window = factory.MakaWindow();
            Console.WriteLine("创建 " + window.ShowInfo());

            //IButton button = factory.MakeButton();
            Console.WriteLine("创建 " + button.ShowInfo());

            //ITextBox textBox = factory.MakeTextBox();
            Console.WriteLine("创建 " + textBox.ShowInfo());

            Console.ReadLine();
        }
    }
}
