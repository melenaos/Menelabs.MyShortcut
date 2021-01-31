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
        public string Path { get; set; }
        public string Arguments { get; set; }
        public string WorkingDir { get; set; }
        public bool AdminRights { get; set; }
        public string Tags { get; set; }
        public ShortcutType Type { get; set; }

        public string Action
        {
            get
            {
                return Path + " " + Arguments;
            }
        }
    }
}
