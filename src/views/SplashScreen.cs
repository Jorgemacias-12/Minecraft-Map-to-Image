using Minecraft_Map_To_Image.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Map_To_Image.src.views
{
    /// <summary>
    /// Form that displays a splash screen while loading the application.
    /// </summary>
    [SupportedOSPlatform("windows")]
    public partial class SplashScreen : Form
    {
        private EditionSelector? form;
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private List<Image> Backgrounds = new List<Image>()
        {
            Resources.blackstone_block,
            Resources.obsidian_block,
            Resources.netherrack_block,
            Resources.gravel_block,
            Resources.coal_block,
            Resources.deepslate_block,
            Resources.netherite_block,
            Resources.emerald_block,
            Resources.mud_block,
        };

        private List<Color> Colors = new List<Color>()
        {
            Color.FromArgb(67, 97, 238),
            Color.FromArgb(252, 81, 48),
            Color.FromArgb(81, 158, 138),
            Color.FromArgb(10, 10, 12)
        };

        private TimeSpan tenSeconds = TimeSpan.FromSeconds(10);
        private DateTime startTime;

        /// <summary>
        /// Checks if a form of the specified type is already open.
        /// </summary>
        /// <param name="Forms">The collection of open forms.</param>
        /// <param name="formType">The type of form to check.</param>
        /// <returns>True if a form of the specified type is already open; otherwise, false.</returns>
        public static bool IsFormOpen(FormCollection Forms, Type formType)
        {
            return Application.OpenForms.Cast<Form>().Any(openForm => openForm.GetType() == formType);
        }

        /// <summary>
        /// Initializes a new instance of the SplashScreen class.
        /// </summary>
        public SplashScreen() => InitializeComponent();

        private void ApplyRandomBackground()
        {
            Random r = new Random();

            int index = r.Next(Backgrounds.Count);

            BackgroundImage = Backgrounds[index];

            index = r.Next(Colors.Count);

            Lbl_Title.BackColor = Colors[index];
            Lbl_LoadingCaption.ForeColor = Colors[index];
            Pgb_SplashScreen.ProgressColor = Colors[index];
            Pgb_SplashScreen.ForeColor = Colors[index];
        }

        private void SplashScreenLoad()
        {
            Pgb_SplashScreen.Minimum = 0;
            Pgb_SplashScreen.Maximum = 100;

            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (IsFormOpen(Application.OpenForms, typeof(EditionSelector)) &&
                form is null)
            {
                return;
            }

            if (Pgb_SplashScreen.Value >= Pgb_SplashScreen.Maximum)
            {
                timer.Stop();

                form = new EditionSelector();
                form.Show();

                Close();

                return;
            }

            Pgb_SplashScreen.Increment(1);
            Text = $"Loading: Minecraft Map To Image %{Pgb_SplashScreen.Value}";
        }

        /// <summary>
        /// Event handler for the form's Load event.
        /// </summary>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashScreenLoad();
            ApplyRandomBackground();
        }
    }
}
