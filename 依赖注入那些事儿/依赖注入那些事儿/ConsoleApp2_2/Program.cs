using ConsoleApp2_2.IService;
using ConsoleApp2_2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_2
{
    /// <summary>
    /// 构造注入
    /// </summary>
    public class Program
    {

        static void Main(string[] args)
        {
            IServiceClass serviceA = new ServiceClassA();
            IServiceClass serviceB = new ServiceClassB();

            ClientClass client = new ClientClass(serviceA);
            client.ShowInfo();

            //
            client = new ClientClass(serviceB);
            client.ShowInfo();

            Console.ReadLine();

        }
    }
}
