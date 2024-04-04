using Minecraft_Map_To_Image.src.logic.models;
using Minecraft_Map_To_Image.src.logic.utils;
using SharpNBT;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Minecraft_Map_To_Image.src.logic.helpers
{
    /// <summary>
    /// Helper class for loading Minecraft maps (item).
    /// </summary>
    [SupportedOSPlatform("windows")]
    public class MinecraftMapLoaderHelper
    {
        private static CompoundTag? mapRootTag;
        private static CompoundTag? mapDataTag;
        private static readonly string DATA_FOLDER = "data";
        private static readonly string MAP_DATA_FILE_PATTERN = "map_*.dat";

        /// <summary>
        /// Loads Minecraft maps from the specified save folder path.
        /// </summary>
        /// <param name="saveFolderPath">The path to the save folder.</param>
        /// <param name="version">The version of the Minecraft map.</param>
        /// <returns>A list of loaded Minecraft maps from a given save (world).</returns>
        public static async Task<List<MinecraftMap>?> LoadMaps(string saveFolderPath, string version)
        {
            List<MinecraftMap> maps = new List<MinecraftMap>();

            MinecraftMap map;

            string dataFolderPath = Path.Combine(saveFolderPath, DATA_FOLDER);

            if (!Directory.Exists(dataFolderPath)) return null;

            string[] mapsPath = await Task.Run(() =>
            {
                return Directory.GetFiles(dataFolderPath, MAP_DATA_FILE_PATTERN);
            });

            foreach (string mapPath in mapsPath)
            {
                // Read .dat file with map nbt values
                mapRootTag = await NbtFile.ReadAsync(mapPath, FormatOptions.Java);

                mapDataTag = mapRootTag.Get<CompoundTag>("data");

                map = new MinecraftMap()
                {
                    Name = Path.GetFileNameWithoutExtension(mapPath),
                    Path = mapPath,
                    Colors = GetMapColors(mapDataTag),
                    Dimension = GetDimension(mapDataTag),
                    Locked = ReadIsLocked(mapDataTag),
                    Width = ReadWidth(mapDataTag),
                    Height = ReadHeight(mapDataTag),
                    Scale = ReadScale(mapDataTag),
                    TrackingPosition = ReadTrackingPosition(mapDataTag),
                    UnlimitedTracking = ReadUnlimitedTracking(mapDataTag),
                    XCenter = ReadXCenter(mapDataTag),
                    ZCenter = ReadZCenter(mapDataTag),
                };

                maps.Add(map);
            }

            return maps;
        }

        /// <summary>
        /// Retrieves the map colors from the map tag.
        /// </summary>
        /// <param name="mapTag">The map tag containing color data.</param>
        /// <returns>The map colors.</returns>
        private static byte[] GetMapColors(CompoundTag? mapTag)
        {
            if (mapTag is null) return [];

            return [..mapTag.Get<ByteArrayTag>("colors")];
        }

        /// <summary>
        /// Retrieves the dimension of the Minecraft map.
        /// </summary>
        /// <param name="mapTag">The map tag containing dimension information.</param>
        /// <returns>The dimension of the Minecraft map.</returns>
        private static string GetDimension(CompoundTag? mapTag)
        {
            if (mapTag is null) return "";

            bool containsDimensionTag = mapTag.ContainsKey("dimension");

            if (!containsDimensionTag) return "Unknown";

            CompoundTag? dimensionTag = mapTag.Get<CompoundTag>("dimension");

            switch (dimensionTag?.Type)
            {
                case TagType.String:
                    return FormatDimensionName(dimensionTag.Get<StringTag>("dimension"));

                case TagType.Byte:
                    Enums.MinecraftDimension dimension = (Enums.MinecraftDimension)dimensionTag.Get<ByteTag>("dimension").Value;
                    return FormatDimensionName($"{dimension}");

                default:
                    return "Unknown";
            }
        }

        /// <summary>
        /// Reads the width of the Minecraft map.
        /// </summary>
        /// <param name="mapData">The map data tag.</param>
        /// <returns>The width of the Minecraft map.</returns>
        private static int ReadWidth(CompoundTag mapData)
        {
            const int MAP_WIDTH = 128;

            if (mapData is null) return -1;
            if (!mapData.ContainsKey("width")) return MAP_WIDTH;

            return mapData.Get<IntTag>("width").Value;
        }

        /// <summary>
        /// Reads the height of the Minecraft map.
        /// </summary>
        /// <param name="mapData">The map data tag.</param>
        /// <returns>The height of the Minecraft map.</returns>
        private static int ReadHeight(CompoundTag mapData)
        {
            const int MAP_HEIGHT = 128;

            if (mapData is null) return -1;
            if (!mapData.ContainsKey("height")) return MAP_HEIGHT;

            return mapData.Get<IntTag>("height").Value;
        }

        /// <summary>
        /// Reads the 'locked' property of the Minecraft map.
        /// </summary>
        /// <param name="mapData">The map data tag.</param>
        /// <returns>The 'locked' property value.</returns>
        private static byte ReadIsLocked(CompoundTag mapData)
        {
            if (mapData is null) return 0;
            if (!mapData.ContainsKey("locked")) return 0;

            return mapData.Get<ByteTag>("locked").Value;
        }

        /// <summary>
        /// Reads the 'scale' property of the Minecraft map.
        /// </summary>
        /// <param name="mapData">The map data tag.</param>
        /// <returns>The 'scale' property value.</returns>
        private static byte ReadScale(CompoundTag mapData)
        {
            if (mapData is null) return 0;
            if (!mapData.ContainsKey("scale")) return 0;

            return mapData.Get<ByteTag>("scale").Value;
        }

        /// <summary>
        /// Reads the 'trackingPosition' property of the Minecraft map.
        /// </summary>
        /// <param name="mapData">The map data tag.</param>
        /// <returns>The 'trackingPosition' property value.</returns>
        private static byte ReadTrackingPosition(CompoundTag mapData)
        {
            if (mapData is null) return 0;
            if (!mapData.ContainsKey("trackingPosition")) return 0;

            return mapData.Get<ByteTag>("trackingPosition").Value;
        }

        /// <summary>
        /// Reads the 'unlimitedTracking' property of the Minecraft map.
        /// </summary>
        /// <param name="mapData">The map data tag.</param>
        /// <returns>The 'unlimitedTracking' property value.</returns>
        private static byte ReadUnlimitedTracking(CompoundTag mapData)
        {
            if (mapData is null) return 0;
            if (!mapData.ContainsKey("unlimitedTracking")) return 0;

            return mapData.Get<ByteTag>("unlimitedTracking").Value;
        }

        /// <summary>
        /// Reads the 'xCenter' property of the Minecraft map.
        /// </summary>
        /// <param name="mapData">The map data tag.</param>
        /// <returns>The 'xCenter' property value.</returns>
        private static int ReadXCenter(CompoundTag mapData)
        {
            if (mapData is null) return 0;
            if (!mapData.ContainsKey("xCenter")) return 0;

            return mapData.Get<IntTag>("xCenter").Value;
        }

        /// <summary>
        /// Reads the 'zCenter' property of the Minecraft map.
        /// </summary>
        /// <param name="mapData">The map data tag.</param>
        /// <returns>The 'zCenter' property value.</returns>
        private static int ReadZCenter(CompoundTag mapData)
        {
            if (mapData is null) return 0;
            if (!mapData.ContainsKey("zCenter")) return 0;

            return mapData.Get<IntTag>("zCenter").Value;
        }

        /// <summary>
        /// Formats the dimension name by removing "minecraft:" prefix and converting underscores to spaces.
        /// </summary>
        /// <param name="dimension">The dimension name to format.</param>
        /// <returns>The formatted dimension name.</returns>
        private static string FormatDimensionName(string dimension)
        {
            dimension = Regex.Replace(dimension, @"^minecraft:", "", RegexOptions.IgnoreCase);
            dimension = Regex.Replace(dimension, @"_+", " ");

            CultureInfo cultureInfo = CultureInfo.InvariantCulture;

            return cultureInfo.TextInfo.ToTitleCase(dimension);
        }
    }
}