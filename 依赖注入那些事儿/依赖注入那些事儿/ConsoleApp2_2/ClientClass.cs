using ConsoleApp2_2.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_2
{
    internal class ClientClass
    {
        private IServiceClass _serviceImpl;

        public ClientClass(IServiceClass serviceImpl)
        {
            _serviceImpl = serviceImpl;
        }

        public void ShowInfo()
        {
            Console.WriteLine(_serviceImpl.ServiceInfo());
        }
    }
}
