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
        private static char[] SPLITTING_CHARS = new[] { ',', ';' };
        public string Group { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }
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

        /// <summary>
        /// Application: Elevate to admin before execution
        /// </summary>
        public bool AdminRights { get; set; }


        public string Action
        {
            get
            {
                return Command + " " + Arguments;
            }
        }

        public string[] TagsList { get { return Tags.Split(SPLITTING_CHARS); } }
        public string[] AlternativeNamesList { get { return AlternativeNames.Split(SPLITTING_CHARS); } }

    }
}
