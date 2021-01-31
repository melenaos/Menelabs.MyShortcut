using MyShortcut.Library.Repository.Abstruct;
using MyShortcut.Library.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Repository
{
    public class ShortcutsRepository : IShortcutsRepository
    {
        IList<GroupModel> GroupsTemp = new[]{
            new GroupModel{ Name = "All", IsAll = true },
            new GroupModel{ Name = "Export" },
            new GroupModel{ Name = "Dev" },
            };

        IList<ShortcutModel> ShortcutsTemp = new[]{
            new ShortcutModel{ Name = "One", Group  = "Export", Tags="Tag1,tag2", Path ="c:\\temp\\Exe", WorkingDir = null, Type = ShortcutType.Application, Arguments="-a all -b bald"  },
            new ShortcutModel{ Name = "two", Group  = "Export" },
            new ShortcutModel{ Name = "three", Group  = "Dev" },
            };
        public IList<GroupModel> Groups => GroupsTemp;

        public IList<ShortcutModel> Shortcuts => ShortcutsTemp;
    }
}
