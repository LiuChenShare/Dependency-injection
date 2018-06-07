using ConsoleApp2_1.IService;
using ConsoleApp2_1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_1
{
    /// <summary>
    /// Setter注入
    /// </summary>
    public class Program
    {

        static void Main(string[] args)
        {
            IServiceClass serviceA = new ServiceClassA();
            IServiceClass serviceB = new ServiceClassB();
            ClientClass client = new ClientClass();

            client.Set_ServiceImpl(serviceA);
            client.ShowInfo();
            client.Set_ServiceImpl(serviceB);
            client.ShowInfo();

            Console.ReadLine();

        }
    }
}
