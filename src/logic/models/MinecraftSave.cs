using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_To_Image.src.logic.models
{
    public class MinecraftSave
    {
        #region FIELDS
        public string? Name { get; set; }
        public string? Path { get; set; }
        public string? Version { get; set; }    
        public Image? SplashIcon { get; set; }
        public bool HasMaps { get; set; } = false;
        public bool HasSplashIcon { get; set; } = false;



        #endregion

        #region CONSTRUCTORS
        public MinecraftSave() { }

        public MinecraftSave(string name, string path, string version, Image splashIcon, bool hasMaps, bool hasSplashIcon)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Path = path ?? throw new ArgumentNullException(nameof(path));
            Version = version ?? throw new ArgumentNullException(nameof(version));
            SplashIcon = splashIcon ?? throw new ArgumentNullException(nameof(splashIcon));
            HasMaps = hasMaps;
            HasSplashIcon = hasSplashIcon;
        }
        #endregion


    }
}
