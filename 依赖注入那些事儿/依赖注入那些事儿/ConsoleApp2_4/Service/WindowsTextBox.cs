using ConsoleApp2_4.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_4.Service
{
    class WindowsTextBox : ITextBox
    {
        public String Description { get; private set; }

        public WindowsTextBox()
        {
            this.Description = "Windows风格文本框";
        }

        public string ShowInfo()
        {
            return this.Description;
        }
    }
}
