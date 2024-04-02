using Minecraft_Map_To_Image.src.logic.utils;
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.Versioning;

namespace Minecraft_Map_To_Image.src.components
{
    /// <summary>
    /// Represents a user control for displaying Minecraft edition information.
    /// </summary>
    [SupportedOSPlatform("windows")]
    public partial class MinecraftEditionCard : UserControl
    {
        private Image? _EditionImage;

        /// <summary>
        /// Gets or sets the Minecraft edition associated with the card.
        /// </summary>
        public Enums.Minecraft Edition { get; set; }

        /// <summary>
        /// Gets or sets the image representing the Minecraft edition.
        /// </summary>
        [Browsable(true)]
        [Description("The image representing the Minecraft edition.")]
        public Image? EditionImage
        {
            get
            {
                return Pbx_EditionImage.Image;
            }
            set
            {
                if (value is null)
                {
                    return;
                }
                
                _EditionImage = value;

                Pbx_EditionImage.BackgroundImage = _EditionImage;
                Pbx_EditionImage.BackgroundImageLayout = ImageLayout.Stretch;
                Pbx_EditionImage.Refresh();
            }
        }

        /// <summary>
        /// Gets or sets the name of the Minecraft edition.
        /// </summary>
        [Browsable(true)]
        [Description("The name of the Minecraft edition.")]
        public string? EditionName
        {
            get
            {
                return Lbl_EditionName.Text;
            }
            set
            {
                if (value is null)
                {
                    return;
                }
                Lbl_EditionName.Text = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinecraftEditionCard"/> class.
        /// </summary>
        public MinecraftEditionCard()
        {
            InitializeComponent();
        }
    }
}
