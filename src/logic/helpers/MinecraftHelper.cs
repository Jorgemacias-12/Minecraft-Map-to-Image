namespace Minecraft_Map_To_Image.src.logic.helpers
{
    /// <summary>
    /// Provides helper methods related to Minecraft installations and saves.
    /// </summary>
    public static class MinecraftHelper
    {
        #region FIELDS

        /// <summary>
        /// The path to the AppData folder.
        /// </summary>
        public readonly static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// The path to the Local Application Data folder.
        /// </summary>
        public readonly static string LOCAL_APPLICATION_DATA = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        /// <summary>
        /// The default installation path for Minecraft Java edition.
        /// </summary>
        public readonly static string JAVA_INSTALATION_PATH = Path.Combine(APPDATA_PATH, ".minecraft");

        /// <summary>
        /// The path to the versions folder within the Minecraft Java installation.
        /// </summary>
        public readonly static string JAVA_VERSIONS_PATH = Path.Combine(JAVA_INSTALATION_PATH, "versions");

        /// <summary>
        /// The default installation path for Minecraft Bedrock edition.
        /// </summary>
        public readonly static string BEDROCK_INSTALATION_PATH = Path.Combine(LOCAL_APPLICATION_DATA,
                                                                              "Packages",
                                                                              "Microsoft.MinecraftUWP_8wekyb3d8bbwe");

        /// <summary>
        /// The path to the saves folder within the Minecraft Java installation.
        /// </summary>
        public readonly static string JAVA_SAVES_PATH = Path.Combine(JAVA_INSTALATION_PATH, "saves");

        /// <summary>
        /// The path to the saves folder within the Minecraft Bedrock installation.
        /// </summary>
        public readonly static string BEDROCK_SAVES_PATH = Path.Combine(BEDROCK_INSTALATION_PATH,
                                                                        "LocalState",
                                                                        "games",
                                                                        "com.mojang",
                                                                        "minecraftWorlds");

        /// <summary>
        /// Gets a value indicating whether Minecraft Java edition is installed by checking the default installation path.
        /// </summary>
        public static bool IsMinecraftJavaInstalled
        {
            get
            {
                return CheckMinecraftJavaInstallation();
            }
        }

        /// <summary>
        /// Gets a value indicating whether Minecraft Bedrock edition is installed by checking the default installation path.
        /// </summary>
        public static bool IsMinecraftBedrockInstalled
        {
            get
            {
                return CheckMinecraftBedrockInstallation();
            }
        }

        /// <summary>
        /// Gets a value indicating whether Minecraft Java edition has saved worlds.
        /// </summary>
        public static bool MinecraftJavaHasSaves
        {
            get
            {
                return CheckIfMinecraftJavaHasSaves();
            }
        }

        /// <summary>
        /// Gets a value indicating whether Minecraft Bedrock edition has saved worlds.
        /// </summary>
        public static bool MinecraftBedrockHasSaves
        {
            get
            {
                return CheckIfMinecraftBedrockHasSaves();
            }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Checks if Minecraft Java edition is installed by verifying the existence of the default installation path.
        /// </summary>
        /// <returns><see langword="true"/> if Minecraft Java edition is installed; otherwise, <see langword="false"/>.</returns>
        private static bool CheckMinecraftJavaInstallation()
        {
            return Directory.Exists(JAVA_INSTALATION_PATH);
        }

        /// <summary>
        /// Checks if Minecraft Bedrock edition is installed by verifying the existence of the default installation path.
        /// </summary>
        /// <returns><see langword="true"/> if Minecraft Bedrock edition is installed; otherwise, <see langword="false"/>.</returns>
        private static bool CheckMinecraftBedrockInstallation()
        {
            return Directory.Exists(BEDROCK_INSTALATION_PATH);
        }

        /// <summary>
        /// Checks if Minecraft Java edition has saved worlds by verifying the existence of saved worlds within the saves folder.
        /// </summary>
        /// <returns><see langword="true"/> if Minecraft Java edition has saved worlds; otherwise, <see langword="false"/>.</returns>
        private static bool CheckIfMinecraftJavaHasSaves()
        {
            return Directory.GetDirectories(JAVA_SAVES_PATH).Length != 0;
        }

        /// <summary>
        /// Checks if Minecraft Bedrock edition has saved worlds by verifying the existence of saved worlds within the saves folder.
        /// </summary>
        /// <returns><see langword="true"/> if Minecraft Bedrock edition has saved worlds; otherwise, <see langword="false"/>.</returns>
        private static bool CheckIfMinecraftBedrockHasSaves()
        {
            return Directory.GetDirectories(BEDROCK_SAVES_PATH).Length != 0;
        }

        #endregion
    }
}
