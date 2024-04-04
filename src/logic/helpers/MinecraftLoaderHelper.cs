using Minecraft_Map_To_Image.src.logic.models;
using Minecraft_Map_To_Image.src.logic.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_To_Image.src.logic.helpers
{
    public sealed class MinecraftLoaderHelper : IDisposable
    {
        #region FIELDS
        private static MinecraftLoaderHelper? instance;
        public List<MinecraftSave>? MinecraftJavaSaves = new List<MinecraftSave>();
        public List<MinecraftSave>? MinecraftBedrockSaves = new List<MinecraftSave>();

        public static MinecraftLoaderHelper Instance
        {
            get
            {
                return instance ?? new MinecraftLoaderHelper();
            }
        }

        
        #endregion

        #region METHODS
        public async Task LoadSaves(Enums.Minecraft Edition)
        {
            string[] saves;
            MinecraftSave? save;

            switch (Edition)
            {
                case Enums.Minecraft.Java:

                    saves = await Task.Run(() =>
                    {
                        return Directory.GetDirectories(MinecraftHelper.JAVA_SAVES_PATH);
                    });

                    foreach (string saveFolder in saves)
                    {
                        if (string.IsNullOrEmpty(saveFolder)) continue;

                        save = MinecraftSaveLoaderHelper.LoadSave(saveFolder, Edition);

                        if (MinecraftJavaSaves != null &&
                            save != null)
                        {
                            MinecraftJavaSaves.Add(save);
                        }
                    }

                    break;
                case Enums.Minecraft.Bedrock:

                    saves = await Task.Run(() =>
                    {
                        return Directory.GetDirectories(MinecraftHelper.BEDROCK_SAVES_PATH);
                    });

                    foreach (string saveFolder in saves)
                    {
                        if (string.IsNullOrEmpty(saveFolder)) continue;

                        save = MinecraftSaveLoaderHelper.LoadSave(saveFolder, Edition);

                        if (MinecraftJavaSaves != null &&
                            save != null)
                        {
                            MinecraftJavaSaves.Add(save);
                        }
                    }
                    break;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
