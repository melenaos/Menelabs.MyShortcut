using MyShortcut.Library.Repository.Abstruct;
using MyShortcut.Library.Repository.Model;
using MyShortcut.Library.Services.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Services
{
    public class ConfigurationService : IServiceConfiguration
    {

        private readonly IShortcutsRepository groupRepo;
        public ConfigurationService(IShortcutsRepository groupRepo)
        {
            this.groupRepo = groupRepo;
            InitializeGroup();
        }

        public IList<GroupModel> Groups => groupRepo.Groups;

        public GroupModel _SelectedGroup;
        public GroupModel SelectedGroup { get { return _SelectedGroup; } set { _SelectedGroup = value; UpdateSelectedGroupShortcuts(); } }

        public IList<ShortcutModel> Shortcuts => groupRepo.Shortcuts;
        public IList<ShortcutModel> SelectedGroupShortcuts { get; private set; }

        private void InitializeGroup()
        {
            // Select group 'All'
            foreach (var group in Groups)
            {
                if (group.IsAll)
                {
                    SelectedGroup = group;
                    break;
                }
            }
        }
        /// <summary>
        /// Update the SelectedGroupShortcuts whenever the user changes group
        /// </summary>
        private void UpdateSelectedGroupShortcuts()
        {
            if (SelectedGroup.IsAll)
            {
                SelectedGroupShortcuts = Shortcuts;
            }
            else
            {
                // Add only the shortcuts that belong to the selected group
                var groupShortcuts = new List<ShortcutModel>();
                foreach (var shortcut in Shortcuts)
                {
                    if (shortcut.Group.Equals(SelectedGroup.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        groupShortcuts.Add(shortcut);
                    }
                }
                SelectedGroupShortcuts = groupShortcuts;
            }
        }
    }
}
