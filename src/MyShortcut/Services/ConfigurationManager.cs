using MyShortcut.Library.Repository;
using MyShortcut.Library.Services;
using MyShortcut.Library.Services.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Services
{
    public static class ConfigurationManager
    {
        public static IServiceConfiguration GetConfigurationService()
        {

            return new ConfigurationService(new ShortcutsRepository());
        }
    }
}
