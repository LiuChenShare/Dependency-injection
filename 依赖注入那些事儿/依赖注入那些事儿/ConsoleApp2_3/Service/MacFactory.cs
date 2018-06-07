using ConsoleApp2_3.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_3.Service
{
    internal sealed class MacFactory : IFactory
    {
        public IButton MakeButton()
        {
            return new MacButton();
        }

        public ITextBox MakeTextBox()
        {
            return new MacTextBox();
        }

        public IWindow MakeWindow()
        {
            return new MacWindow();
        }
    }
}
