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
        IList<GroupModel> Groups { get; }
        IList<ShortcutModel> Shortcuts { get; }
    }
}
