using MyShortcut.Library.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Services.Abstruct
{
   public interface IExecuteShortcuts
    {
        bool Execute(ShortcutModel shortcut);
    }
}
