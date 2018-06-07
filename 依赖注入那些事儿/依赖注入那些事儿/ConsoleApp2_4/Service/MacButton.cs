using ConsoleApp2_4.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_4.Service
{
    internal sealed class MacButton : IButton
    {
        public String Description { get; private set; }

        public MacButton()
        {
            this.Description = "Mac风格按钮";
        }

        public string ShowInfo()
        {
            return this.Description;
        }
    }
}
