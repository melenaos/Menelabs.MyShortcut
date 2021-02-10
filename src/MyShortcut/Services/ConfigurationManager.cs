using MyShortcut.Library.Repository;
using MyShortcut.Library.Services;
using MyShortcut.Library.Services.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShortcut.Services
{
    public static class ConfigurationManager
    {
        public static IServiceConfiguration GetConfigurationService()
        {
               var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\MyShortcuts";
            return new ConfigurationService(new ShortcutsRepository(path));
        }

        public static IExecuteShortcuts GetShortcutExecutor()
        {
            return new ShortcutExecutor();
        }
    }
}
