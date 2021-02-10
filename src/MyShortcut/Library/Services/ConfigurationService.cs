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

        private readonly IShortcutsRepository shortcutRepo;
        public ConfigurationService(IShortcutsRepository groupRepo)
        {
            this.shortcutRepo = groupRepo;
            SelectAllGroup();
        }

        public IList<GroupModel> Groups => shortcutRepo.Groups;

        public GroupModel _SelectedGroup;
        public GroupModel SelectedGroup { get { return _SelectedGroup; } set { _SelectedGroup = value; UpdateSelectedGroupShortcuts(); } }

        public IList<ShortcutModel> Shortcuts => shortcutRepo.Shortcuts;
        public IList<ShortcutModel> SelectedGroupShortcuts { get; private set; }

        private void SelectAllGroup()
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
                // Use a new list because the databinding of DataGridView doesn't get triggered otherwise.
                //  Alternative you could just assign the Shortcut directly to SelectedGroupShortcuts
                SelectedGroupShortcuts = new List<ShortcutModel>(Shortcuts);
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

        public GroupModel AddNewGroup()
        {
            var group = new GroupModel();
            shortcutRepo.AddGroup(group);
            SelectedGroup = group;
            UpdateSelectedGroupShortcuts();
            return group;
        }

        public void DeleteSelectedGroup()
        {
            // Don't delete the All group
            if (SelectedGroup.IsAll)
                return;

            // Update the shortcut's group name
            foreach (var shortcut in Shortcuts)
            {
                if (shortcut.Group.Equals(SelectedGroup.Name, StringComparison.OrdinalIgnoreCase))
                {
                    shortcutRepo.AssignToAllGroup(shortcut);
                }
            }
            var groupToBeDeleted = SelectedGroup;

            SelectAllGroup();
            shortcutRepo.DeleteGroup(groupToBeDeleted);

            SaveShortcuts();
        }
        public ShortcutModel FindShortcut(string text)
        {
            foreach (var shortcut in Shortcuts)
            {
                var keyword = text.Split(':').Last().Trim();

                // If searched by name or alternative names
                if (string.Compare(shortcut.Name, keyword, true) == 0 ||
                     shortcut.AlternativeNamesList.Any(u => string.Compare(u.Trim(), keyword, true) == 0))
                {
                    return shortcut;
                }
            }

            return null;
        }


        public void UpdateSelectedGroupName(string name)
        {
            // Don't update the All group
            if (SelectedGroup.IsAll)
                return;

            if (string.IsNullOrEmpty(name))
                return;

            // Update the shortcut's group name
            foreach (var shortcut in Shortcuts)
            {
                if (shortcut.Group.Equals(SelectedGroup.Name, StringComparison.OrdinalIgnoreCase))
                {
                    shortcut.Group = name;
                }
            }

            // Update group
            SelectedGroup.Name = name;

            SaveShortcuts();
        }




        public ShortcutModel AddNewShortcut()
        {
            var shortcut = new ShortcutModel
            {
                Group = SelectedGroup.Name
            };
            shortcutRepo.AddShortcut(shortcut);
            UpdateSelectedGroupShortcuts();
            return shortcut;
        }

        public void SaveShortcuts()
        {
            shortcutRepo.SaveShortcuts();
        }

        public void LoadShortcuts()
        {
            shortcutRepo.LoadShortcuts();
        }
    }
}
