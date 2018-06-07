using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ConsoleApp1_2
{
    public class ProductService
    {
        private ILog _log;
        public ProductService(ILog log)
        {
            _log = log;
        }

        public void SaveLog()
        {
            _log.SaveLog("现在是" + DateTime.Now.ToString("F"));
        }
    }
}
