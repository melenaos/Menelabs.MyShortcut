using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Repository.Abstruct
{
    public interface ISettingsRepository
    {
        void LoadSettings();
        void SaveSettings();
        Point? GetFormLocation();
        void SetFormLocation(Point location);
    }
}
