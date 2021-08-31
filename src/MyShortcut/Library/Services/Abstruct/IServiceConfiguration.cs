using MyShortcut.Library.Repository.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Services.Abstruct
{
    public interface IServiceConfiguration
    {
        IList<GroupModel> Groups { get; }
        GroupModel SelectedGroup { get; set; }
        IList<ShortcutModel> Shortcuts { get; }
        IList<ShortcutModel> SelectedGroupShortcuts { get; }

        void SaveShortcuts();
        void LoadShortcuts();
        void SaveSettings();
        Task LoadSettings();

        ShortcutModel AddNewShortcut();
        GroupModel AddNewGroup();
        void DeleteSelectedGroup();
        void UpdateSelectedGroupName(string text);
        ShortcutModel FindShortcut(string text);
        Point? GetFormLocation();
        void SetFormLocation(Point location);

        bool WindowOnTop { get; set; }
        bool ShowInTaskbar { get; set; }
    }
}
