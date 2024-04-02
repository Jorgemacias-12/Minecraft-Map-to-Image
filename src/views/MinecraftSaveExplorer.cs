using Minecraft_Map_To_Image.src.logic.utils;
using System;
using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace Minecraft_Map_To_Image.src.views
{
    /// <summary>
    /// Represents a form for exploring Minecraft saves.
    /// </summary>
    [SupportedOSPlatform("windows")]
    public partial class MinecraftSaveExplorer : BaseForm
    {
        /// <summary>
        /// Gets or sets the Minecraft edition associated with the explorer.
        /// </summary>
        public Enums.Minecraft Edition { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinecraftSaveExplorer"/> class.
        /// </summary>
        public MinecraftSaveExplorer()
        {
            InitializeComponent();
            ConfigureForm();
        }

        /// <summary>
        /// Configures the form settings such as centering it on the screen.
        /// </summary>
        private void ConfigureForm()
        {
            // Center the form on the screen.
            StartPosition = FormStartPosition.CenterScreen;

            // Check if the primary screen is available.
            if (Screen.PrimaryScreen is null)
            {
                return;
            }

            // Calculate the position to center the form on the screen.
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
        }
    }
}
