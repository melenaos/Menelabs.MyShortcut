using MyShortcut.Library.Repository.Model;
using MyShortcut.Library.Services.Abstruct;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Services
{
    public class ShortcutExecutor : IExecuteShortcuts
    {
        public bool Execute(ShortcutModel shortcut)
        {
            if (shortcut.Type == ShortcutType.Application)
            {
                Process prc = new Process();
                // Set the application's filepath
                prc.StartInfo.FileName = shortcut.Command;

                // Admin rights, if needed
                if (shortcut.AdminRights)
                {
                    prc.EnableRaisingEvents = true;
                    prc.StartInfo.Verb = "runas";
                }

                // Provided arguments
                if (!string.IsNullOrWhiteSpace(shortcut.Arguments)) prc.StartInfo.Arguments = shortcut.Arguments;

                // Set working directory at the application's directory
                prc.StartInfo.WorkingDirectory = Path.GetDirectoryName(shortcut.Command);
                //  unless the user has explicity set another working directory
                if (!string.IsNullOrWhiteSpace(shortcut.WorkingDir)) prc.StartInfo.WorkingDirectory = shortcut.WorkingDir;
                
                try
                {
                    prc.Start();
                }
                catch
                {
                    return false;
                }
            }
            else if (shortcut.Type == ShortcutType.Folder)
            {
                Process prc = new Process();
                prc.StartInfo.FileName = shortcut.Command;

                try
                {
                    prc.Start();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
    }
}
