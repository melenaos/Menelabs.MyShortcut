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

        public Point? GetFormLocation()
        {
            return settings.FormLocation;
        }
        public void SetFormLocation(Point location)
        {
            settings.FormLocation = location;
        }

        public bool WindowOnTop
        {
            get
            {
                return settings.WindowOnTop;
            }
            set
            {
                settings.WindowOnTop = value;
            }
        }

        public bool ShowInTaskbar
        {
            get
            {
                return settings.ShowInTaskbar;
            }
            set
            {
                settings.ShowInTaskbar = value;
            }
        }
    }
}
