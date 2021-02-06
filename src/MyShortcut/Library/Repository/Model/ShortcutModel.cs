using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Repository.Model
{
    public enum ShortcutType { Application, Folder, Plugin }
    public class ShortcutModel
    {
        public string Group { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Alternative calls seperated with , or ;
        /// </summary>
        public string AlternativeNames { get; set; }
        public ShortcutType Type { get; set; }

        /// <summary>
        /// Application: Filepath
        /// Folder: Folderpath
        /// Plugin: Plugin selection
        /// </summary>
        public string Command { get; set; }
        /// <summary>
        /// Application: application arguments
        /// Plugin: plugin arguments
        /// </summary>
        public string Arguments { get; set; }
        /// <summary>
        /// Application: application working dir
        /// Plugin: plugin path argument
        /// </summary>
        public string WorkingDir { get; set; }

        public bool AdminRights { get; set; }
        public string Tags { get; set; }

        public string Action
        {
            get
            {
                return Command + " " + Arguments;
            }
        }
    }
}
