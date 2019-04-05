using IEEE.configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE.Interface
{
   public interface IConfig
    {
        BrowserType GetBrowser();
        String GetWebsite();
    }
}
