using MyShortcut.Library.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Repository.Abstruct
{
    public interface IShortcutsRepository
    {
        List<GroupModel> Groups { get; }
        List<ShortcutModel> Shortcuts { get; }

        void AddShortcut(ShortcutModel shortcutModel);
        void AddGroup(GroupModel group);

        void AssignToAllGroup(ShortcutModel shortcutModel);

        void LoadShortcuts();
        void SaveShortcuts();
        void DeleteGroup(GroupModel groupToBeDeleted);
    }
}
