using ConsoleApp2_4.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_4.Service
{
    class WindowsWindow : IWindow
    {
        public String Description { get; private set; }

        public WindowsWindow()
        {
            this.Description = "Windows风格窗体";
        }

        public string ShowInfo()
        {
            return this.Description;
        }
    }
}
