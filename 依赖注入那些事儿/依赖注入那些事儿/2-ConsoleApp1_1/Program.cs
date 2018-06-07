using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ConsoleApp1_1
{
    public class Program
    {
        private ILog _log;
        public Program()
        {
            _log = new Log();
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p._log.SaveLog("现在是"+DateTime.Now.ToString("F"));

            GetMessage getMessage = new GetMessage();
            var messages = getMessage.GetMessagesInXml();
            foreach (var message in messages)
            {
                p._log.SaveLog(message);
            }

            Console.ReadLine();
        }
        
    }
}
