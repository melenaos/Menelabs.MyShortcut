using MyShortcut.Library.Repository.Abstruct;
using MyShortcut.Library.Repository.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Repository
{
    public class ShortcutsRepository : IShortcutsRepository
    {
        private static string ALL_GROUP = "All";

        private readonly string shortcutsFile;
        public ShortcutsRepository(string shortcutsPath)
        {
            if (Directory.Exists(shortcutsPath) == false)
                Directory.CreateDirectory(shortcutsPath);

            if (shortcutsPath.EndsWith(@"\") == false) shortcutsPath += @"\";

            shortcutsFile = shortcutsPath + "MyShortcuts.json";
        }

        public void AssignToAllGroup(ShortcutModel shortcutModel)
        {
            shortcutModel.Group = ALL_GROUP;
        }
        public void SaveShortcuts()
        {
            var fileContent = JsonConvert.SerializeObject(new MyShortcutsFile { Groups = Groups, Shortcuts = Shortcuts });
            File.WriteAllText(shortcutsFile, fileContent);
        }
        public void LoadShortcuts()
        {
            if (File.Exists(shortcutsFile))
            {
                try
                {
                    var shortcutsFileContent = File.ReadAllText(shortcutsFile);
                    var shortcutsGraph = JsonConvert.DeserializeObject<MyShortcutsFile>(shortcutsFileContent);
                    Shortcuts = shortcutsGraph.Shortcuts;
                    Groups = shortcutsGraph.Groups;
                }
                catch
                {
                    throw new Exception($"The shortcuts file is corrupted. Please fix the formating or completely delete it ({shortcutsFile})");
                }
            }
            else
            {
                Groups = new List<GroupModel>();
                Shortcuts = new List<ShortcutModel>();
            }

            UpdateGroups();

        }

        /// <summary>
        /// Runs through Shortcuts and add any missing group from the list.
        /// Also ensures that there is atleast one group named 'All' in the list
        /// </summary>
        private void UpdateGroups()
        {
            bool hasAll = false;
            // Add any missing group
            foreach (var shortcut in Shortcuts)
            {
                if(!Groups.Exists(u=> string.Compare(u.Name, shortcut.Group, StringComparison.OrdinalIgnoreCase) == 0))
                {
                    Groups.Add(new GroupModel { Name = shortcut.Group });
                }
            }

            // Find the All-Group
            foreach (var group in Groups)
            {
                if(group.Name == ALL_GROUP)
                {
                    group.IsAll = true;
                    hasAll = true;
                    break;
                }
            }

            // add it if is missing
            if (!hasAll)
            {
                Groups.Add(new GroupModel { Name = ALL_GROUP, IsAll = true });
            }

        }

        public List<GroupModel> Groups { get; set; } = new List<GroupModel>();

        public List<ShortcutModel> Shortcuts { get; set; } = new List<ShortcutModel>();

        public void AddShortcut(ShortcutModel shortcutModel)
        {
            Shortcuts.Add(shortcutModel);
            // no need to save, if the user updates the shortcut (e.g. set name, argument...) then they should save.
        }

        public void AddGroup(GroupModel group)
        {
            Groups.Add(group);
        }

      public  void DeleteGroup(GroupModel groupToBeDeleted)
        {
            Groups.Remove(groupToBeDeleted);
        }



        private class MyShortcutsFile
        {
            public List<GroupModel> Groups { get; set; }
            public List<ShortcutModel> Shortcuts { get; set; }
        }
    }
}
