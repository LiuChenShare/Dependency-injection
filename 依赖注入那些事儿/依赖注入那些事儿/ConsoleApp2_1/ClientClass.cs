using ConsoleApp2_1.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_1
{
    internal class ClientClass
    {
        private IServiceClass _serviceImpl;

        public void Set_ServiceImpl(IServiceClass serviceImpl)
        {
            _serviceImpl = serviceImpl;
        }

        public void ShowInfo()
        {
            Console.WriteLine(_serviceImpl.ServiceInfo());
        }
    }
}
