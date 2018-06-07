using ConsoleApp2_4.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_4.Service
{
    class MacWindow : IWindow
    {
        public String Description { get; private set; }

        public MacWindow()
        {
            this.Description = "Mac风格窗体";
        }

        public string ShowInfo()
        {
            return this.Description;
        }
    }
}
