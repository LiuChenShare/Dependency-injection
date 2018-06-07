using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ConsoleApp1_2
{
    public class Global
    {
        public static IContainer container;
        public void Application_Start()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Log>().As<ILog>();
            builder.RegisterType<ProductService>();
            container = builder.Build();
            var productService = container.Resolve<ProductService>();
        }
    }
}
