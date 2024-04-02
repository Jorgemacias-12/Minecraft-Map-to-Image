using System.ComponentModel;
using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace Minecraft_Map_To_Image.src.components
{
    /// <summary>
    /// Custom progress bar control with customizable appearance.
    /// </summary>
    [SupportedOSPlatform("windows")]
    public class JProgressBar : ProgressBar
    {
        private Color _ProgressColor = Color.Green;
        private Color _BackgroundColor = Color.White;
        private int _BorderRadius = 0;

        /// <summary>
        /// Gets or sets the color of the progress bar's filled portion.
        /// </summary>
        [Category("Appearance")]
        [Description("The color of the progress bar's filled portion.")]
        [Browsable(true)]
        public Color ProgressColor
        {
            get { return _ProgressColor; }
            set
            {
                _ProgressColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the background color of the progress bar's unfilled portion.
        /// </summary>
        [Category("Appearance")]
        [Description("The background color of the progress bar's unfilled portion.")]
        [Browsable(true)]
        public Color BackgroundColor
        {
            get { return _BackgroundColor; }
            set
            {
                _BackgroundColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the corner radius for the control's border.
        /// </summary>
        [Category("Appearance")]
        [Description("The corner radius for the control's border.")]
        [Browsable(true)]
        public int BorderRadius
        {
            get { return _BorderRadius; }
            set
            {
                _BorderRadius = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Initializes a new instance of the JProgressBar class.
        /// </summary>
        public JProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Overrides the OnPaint method to customize the appearance of the progress bar.
        /// </summary>
        /// <param name="e">The PaintEventArgs object that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (DesignMode) return;

            Rectangle filledRect = ClientRectangle;
            filledRect.Width = (int)(filledRect.Width * ((double)Value / Maximum));


            // Fill the progress portion with the specified color.
            using (SolidBrush filledBrush = new SolidBrush(ProgressColor))
            {
                e.Graphics.FillRectangle(filledBrush, filledRect);
            }

            Rectangle remainingRect = ClientRectangle;
            remainingRect.X = filledRect.Right;
            remainingRect.Width = ClientRectangle.Right - filledRect.Right;

            // Fill the remaining portion with the background color.
            using (SolidBrush remainingBrush = new SolidBrush(BackgroundColor))
            {
                e.Graphics.FillRectangle(remainingBrush, remainingRect);
            }
        }
    }
}
