using ConsoleApp2_2.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_2.Service
{
    class ServiceClassA : IServiceClass
    {
        public string ServiceInfo()
        {
            return "我是ServiceClassA";
        }
    }
}
