using Minecraft_Map_To_Image.src.logic.helpers;
using System.Data.Common;
using System.Drawing;
using System.Runtime.Versioning;

namespace Minecraft_Map_To_Image.src.logic.models
{
    /// <summary>
    /// Represents a Minecraft map item.
    /// </summary>
    [SupportedOSPlatform("windows")]
    public class MinecraftMap
    {
        private const int MAP_BTE_SIZE = 16384;
        private const int WIDTH = 128;
        private const int HEIGHT = 128;
        private Bitmap? _image;

        /// <summary>
        /// Gets or sets the name of the Minecraft map.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the file path of the Minecraft map.
        /// </summary>
        public string? Path { get; set; }

        /// <summary>
        /// Gets or sets the dimension of the Minecraft map.
        /// </summary>
        public string? Dimension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Minecraft map is locked.
        /// </summary>
        public byte Locked { get; set; }

        /// <summary>
        /// Gets or sets the scale of the Minecraft map.
        /// </summary>
        public byte Scale { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether tracking position is enabled on the Minecraft map.
        /// </summary>
        public byte TrackingPosition { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether unlimited tracking is enabled on the Minecraft map.
        /// </summary>
        public byte UnlimitedTracking { get; set; }

        /// <summary>
        /// Gets or sets the X-coordinate center of the Minecraft map.
        /// </summary>
        public int XCenter { get; set; }

        /// <summary>
        /// Gets or sets the Z-coordinate center of the Minecraft map.
        /// </summary>
        public int ZCenter { get; set; }

        /// <summary>
        /// Gets or sets the width of the Minecraft map.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the Minecraft map.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the color data of the Minecraft map.
        /// </summary>
        public byte[] Colors { get; set; } = new byte[MAP_BTE_SIZE];

        /// <summary>
        /// Gets or sets the image representation of the Minecraft map.
        /// </summary>
        public Bitmap? Image
        {
            get
            {
                if (_image == null)
                {
                    _image = DrawMap(Colors, WIDTH, HEIGHT);
                }
                return _image;
            }
            set
            {
                _image = value;
            }
        }

        /// <summary>
        /// Converts the color data of the Minecraft map into a Bitmap image.
        /// </summary>
        /// <param name="data">The color data of the Minecraft map.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        /// <returns>The resulting Bitmap image.</returns>
        private static Bitmap? DrawMap(byte[] data, int width, int height)
        {
            Bitmap? bmp = new Bitmap(width, height);

            int EmptyPixelCount = 0;
            int PixelPerBlock = 1;
            int TempWidth = width;
            int MAP_SIZE = 128;

            while ((TempWidth /= 2) >= MAP_SIZE) PixelPerBlock *= 2;

            Graphics g;

            g = Graphics.FromImage(bmp);

            for (int column = 0; column < MAP_SIZE; column ++)
            {
                for (int row = 0; row < MAP_SIZE; row++)
                {
                    bool sucess;
                    int id;
                    byte pixelValue;
                    Color pixelColor;

                    id = column + row * MAP_SIZE;

                    pixelValue = data[id];

                    sucess = MinecraftDataHelper.BlocksColorsMappings.TryGetValue(pixelValue, out pixelColor);

                    if (!sucess) EmptyPixelCount++;

                    using (SolidBrush brush = new SolidBrush(pixelColor))
                    {
                        g.FillRectangle(brush,
                                       column * PixelPerBlock,
                                       row * PixelPerBlock,
                                       PixelPerBlock,
                                       PixelPerBlock);
                    }
                }
            }

            g.Dispose();

            return bmp;
        }
    }
}
