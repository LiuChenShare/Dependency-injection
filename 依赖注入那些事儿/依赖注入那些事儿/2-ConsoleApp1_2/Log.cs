using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ConsoleApp1_2
{
    public class Log : ILog
    {
        public void SaveLog(string message)
        {
            //save log here.
            Console.WriteLine("记录信息 ： " + message);
        }
    }
}
