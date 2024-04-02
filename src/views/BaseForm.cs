using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Minecraft_Map_To_Image.src.logic.helpers;
using System.Runtime.Versioning;

namespace Minecraft_Map_To_Image.src.views
{
    /// <summary>
    /// Base class for custom forms with drag-to-move and resize functionality.
    /// </summary>
    public partial class BaseForm : Form
    {
        // More info about this values in:
        // https://learn.microsoft.com/es-es/windows/win32/inputdev/mouse-input-notifications
        private const int WM_NCHITTEST = 0x84;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 2;
        private const int HT_BOTTOMRIGHT = 17;

        private const int GRIP_SIZE = 10;


        /// <summary>
        /// Constructor for the BaseForm class.
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();
            ConfigureForm();
        }

        /// <summary>
        /// Configures the form to have borderless appearance and be resizable.
        /// </summary>
        [SupportedOSPlatform("windows")]
        private void ConfigureForm()
        {

            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            StartPosition = FormStartPosition.CenterScreen;

            if (Screen.PrimaryScreen is null)
            {
                return;
            }

            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [LibraryImport("user32.dll", EntryPoint = "SendMessageA")]
        private static partial int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool ReleaseCapture();

        /// <summary>
        /// Overrides the WndProc method to implement drag and resize functionality.
        /// </summary>
        /// <param name="m">Window message</param>
        [SupportedOSPlatform("windows")]
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                Point mousePos = new(m.LParam.ToInt32());

                mousePos = PointToClient(mousePos);

                if (mousePos.Y < Pnl_TopBar.Height)
                {
                    m.Result = HT_CAPTION;
                    return;
                }

                if (mousePos.X >= ClientSize.Width - GRIP_SIZE &&
                    mousePos.Y >= ClientSize.Height - GRIP_SIZE)
                {
                    m.Result = HT_BOTTOMRIGHT;
                    return;
                }
            }
        }

        /// <summary>
        /// Overrides the OnPaint method to draw the resize area at the bottom-right corner.
        /// </summary>
        /// <param name="e">Paint event arguments</param>
        [SupportedOSPlatform("windows")]
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle GripRect = new Rectangle()
            {
                X = ClientSize.Width - GRIP_SIZE,
                Y = ClientSize.Height - GRIP_SIZE,
                Width = GRIP_SIZE,
                Height = GRIP_SIZE
            };

            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, GripRect);
        }

        [SupportedOSPlatform("windows")]
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [SupportedOSPlatform("windows")]
        private void Btn_ChangeFormState_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        [SupportedOSPlatform("windows")]
        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Handles the MouseDown event to allow dragging the form by clicking and dragging the title bar.
        /// </summary>
        /// <param name="sender">Control that generates the event</param>
        /// <param name="e">MouseDown event arguments</param>
        [SupportedOSPlatform("windows")]
        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}