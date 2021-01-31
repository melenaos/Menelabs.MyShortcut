using MyShortcut.Library.Repository.Model;
using System;
using System.Collections.Generic;
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

    }
}
