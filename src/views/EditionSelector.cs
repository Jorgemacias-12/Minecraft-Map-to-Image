using Minecraft_Map_To_Image.Properties;
using Minecraft_Map_To_Image.src.logic.helpers;
using System.Runtime.Versioning;

namespace Minecraft_Map_To_Image.src.views
{
    /// <summary>
    /// Represents a form for selecting the Minecraft edition.
    /// </summary>
    [SupportedOSPlatform("windows")]
    public partial class EditionSelector : BaseForm
    {
        private MinecraftSaveExplorer explorer = new MinecraftSaveExplorer();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditionSelector"/> class.
        /// </summary>
        public EditionSelector()
        {
            InitializeComponent();
            ConfigureForm();
        }

        /// <summary>
        /// Configures the form appearance and controls.
        /// </summary>
        public void ConfigureForm()
        {
            // Disable and hide the button for changing form state (minimize/maximize).
            Btn_ChangeFormState.Enabled = false;
            Btn_ChangeFormState.Visible = false;

            // Set the images for the edition selector controls.
            Mec_Bedrock.EditionImage = Resources.bedrock_block;
            Mec_Java.EditionImage = Resources.glass_block_3d;

            // Attach event handlers for choosing Java or Bedrock version.
            Mec_Bedrock.Btn_ChooseEdition.Click += ChooseBedrockVersion;
            Mec_Java.Btn_ChooseEdition.Click += ChooseJavaVersion;

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

        /// <summary>
        /// Event handler for choosing the Java version.
        /// </summary>
        private void ChooseJavaVersion(object? sender, EventArgs e)
        {
            explorer.Edition = Mec_Bedrock.Edition;

            // Show the Minecraft save explorer form.
            explorer.Show();
            // Close the edition selector form.
            Close();
        }

        /// <summary>
        /// Event handler for choosing the Bedrock version.
        /// </summary>
        private void ChooseBedrockVersion(object? sender, EventArgs e)
        {
            explorer.Edition = Mec_Java.Edition;

            // Show the Minecraft save explorer form.
            explorer.Show();
            // Close the edition selector form.
            Close();
        }

        private void EditionSelector_Load(object sender, EventArgs e)
        {
            if (!MinecraftHelper.IsMinecraftJavaInstalled)
            {
                Mec_Java.Enabled = false;
                Mec_Java.Visible = false;
            }

            if (!MinecraftHelper.IsMinecraftBedrockInstalled)
            {
                Mec_Bedrock.Visible = false;
            }
        }
    }
}
