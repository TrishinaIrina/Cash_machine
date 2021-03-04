using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Tengri.OnlineApp
{

    class Program
    {
        private static ILog log = LogManager.GetLogger("LOGGER");
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();







            log.Info("WORK");
        }
    }
}
