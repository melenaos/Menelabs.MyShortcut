using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Repository.Model
{
    public class SettingsModel
    {
        public Point? FormLocation { get; set; }
        public bool ShowInTaskbar { get; set; } = true;
        public bool WindowOnTop { get; set; } = false;
    }
}
