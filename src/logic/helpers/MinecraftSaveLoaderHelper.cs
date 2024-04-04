using Minecraft_Map_To_Image.src.logic.models;
using Minecraft_Map_To_Image.src.logic.utils;
using SharpNBT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_To_Image.src.logic.helpers
{
    /// <summary>
    /// 
    /// </summary>
    [SupportedOSPlatform("windows")]
    public static class MinecraftSaveLoaderHelper
    {
        private static CompoundTag? levelData;


        private static string ReadVersion(string savePath)
        {
            if (levelData is null) { return ""; }
            
            CompoundTag data = levelData.Get<CompoundTag>("Data");
            CompoundTag version = data.Get<CompoundTag>("Version");
            
            return version.Get<StringTag>("Name");
        }

        private static Image? ReadSplashIcon(string savePath)
        {
            try
            {
                return Image.FromFile($"{savePath}\\icon.png");
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="savePath"></param>
        /// <param name="Edition"></param>
        /// <returns></returns>
        public static MinecraftSave? LoadSave(string savePath, Enums.Minecraft Edition)
        {
            string levelDataPath = Path.Combine(savePath, "level.dat");

            if (!File.Exists(levelDataPath)) return null;

            switch (Edition)
            {
                case Enums.Minecraft.Java:
                    levelData = NbtFile.Read(levelDataPath, FormatOptions.Java);
                    break;

                case Enums.Minecraft.Bedrock:
                    levelData = NbtFile.Read(levelDataPath, FormatOptions.BedrockFile);
                    break;
            }


            MinecraftSave s = new MinecraftSave()
            {
                Name = Path.GetDirectoryName(savePath) ?? "",
                Path = savePath,
                Version = ReadVersion(levelDataPath),
                SplashIcon = ReadSplashIcon(savePath),
                HasMaps = ReadSplashIcon(levelDataPath) != null,
            };

            Dispose();

            return s;
        }

        private static void Dispose()
        {
            levelData = null;
        }
    }
}
