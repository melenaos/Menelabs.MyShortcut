using MyShortcut.Library.Repository.Abstruct;
using MyShortcut.Library.Repository.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Repository
{
    public class SettingsRepository : ISettingsRepository
    {
        private readonly string settingsFile;
        private SettingsModel settings;
        public SettingsRepository(string path)
        {
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);

            if (path.EndsWith(@"\") == false) path += @"\";

            settingsFile = path + "Settings.json";
        }

        public Point? GetFormLocation()
        {
            return settings.FormLocation;
        }

        public void LoadSettings()
        {
            if (File.Exists(settingsFile))
            {
                try
                {
                    var settingsFileContent = File.ReadAllText(settingsFile);
                    settings = JsonConvert.DeserializeObject<SettingsModel>(settingsFileContent);
                    
                }
                catch
                {
                    throw new Exception($"The settings file is corrupted. Please fix the formating or completely delete it ({settingsFile})");
                }
            }
            else
            {
                settings = new SettingsModel();
            }
        }

        public void SaveSettings()
        {
            var fileContent = JsonConvert.SerializeObject(settings);
            File.WriteAllText(settingsFile, fileContent);
        }

        public void SetFormLocation(Point location)
        {
            settings.FormLocation = location;
        }
    }
}
