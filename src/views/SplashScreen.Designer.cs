using Minecraft_Map_To_Image.src.components;

namespace Minecraft_Map_To_Image.src.views
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            Pnl_bottom = new Panel();
            Lbl_LoadingCaption = new Label();
            Pgb_SplashScreen = new JProgressBar();
            Pnl_Top = new Panel();
            Lbl_Title = new Label();
            Pnl_bottom.SuspendLayout();
            Pnl_Top.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_bottom
            // 
            Pnl_bottom.AutoSize = true;
            Pnl_bottom.BackColor = Color.Transparent;
            Pnl_bottom.Controls.Add(Lbl_LoadingCaption);
            Pnl_bottom.Controls.Add(Pgb_SplashScreen);
            Pnl_bottom.Dock = DockStyle.Bottom;
            Pnl_bottom.Location = new Point(0, 252);
            Pnl_bottom.Margin = new Padding(4, 3, 4, 3);
            Pnl_bottom.Name = "Pnl_bottom";
            Pnl_bottom.Padding = new Padding(12);
            Pnl_bottom.Size = new Size(723, 82);
            Pnl_bottom.TabIndex = 2;
            // 
            // Lbl_LoadingCaption
            // 
            Lbl_LoadingCaption.Dock = DockStyle.Bottom;
            Lbl_LoadingCaption.Font = new Font("Monocraft", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_LoadingCaption.ForeColor = SystemColors.ButtonFace;
            Lbl_LoadingCaption.Location = new Point(12, 12);
            Lbl_LoadingCaption.Margin = new Padding(0);
            Lbl_LoadingCaption.Name = "Lbl_LoadingCaption";
            Lbl_LoadingCaption.Size = new Size(699, 31);
            Lbl_LoadingCaption.TabIndex = 1;
            Lbl_LoadingCaption.Text = "Cargando...";
            // 
            // Pgb_SplashScreen
            // 
            Pgb_SplashScreen.BackColor = Color.FromArgb(33, 37, 41);
            Pgb_SplashScreen.BackgroundColor = Color.FromArgb(33, 37, 41);
            Pgb_SplashScreen.BorderRadius = 30;
            Pgb_SplashScreen.Dock = DockStyle.Bottom;
            Pgb_SplashScreen.ForeColor = SystemColors.ControlText;
            Pgb_SplashScreen.Location = new Point(12, 43);
            Pgb_SplashScreen.Margin = new Padding(4, 3, 4, 3);
            Pgb_SplashScreen.Name = "Pgb_SplashScreen";
            Pgb_SplashScreen.ProgressColor = Color.Empty;
            Pgb_SplashScreen.Size = new Size(699, 27);
            Pgb_SplashScreen.TabIndex = 0;
            // 
            // Pnl_Top
            // 
            Pnl_Top.AutoSize = true;
            Pnl_Top.BackColor = Color.Transparent;
            Pnl_Top.Controls.Add(Lbl_Title);
            Pnl_Top.Dock = DockStyle.Top;
            Pnl_Top.Location = new Point(0, 12);
            Pnl_Top.Margin = new Padding(4, 3, 4, 3);
            Pnl_Top.Name = "Pnl_Top";
            Pnl_Top.Padding = new Padding(12, 0, 12, 0);
            Pnl_Top.Size = new Size(723, 39);
            Pnl_Top.TabIndex = 3;
            // 
            // Lbl_Title
            // 
            Lbl_Title.BackColor = Color.FromArgb(67, 97, 238);
            Lbl_Title.Dock = DockStyle.Top;
            Lbl_Title.Font = new Font("Monocraft", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Title.ForeColor = Color.White;
            Lbl_Title.Location = new Point(12, 0);
            Lbl_Title.Margin = new Padding(4, 0, 4, 0);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new Size(699, 39);
            Lbl_Title.TabIndex = 2;
            Lbl_Title.Text = "Minecraft Map To Image";
            Lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 41);
            ClientSize = new Size(723, 346);
            ControlBox = false;
            Controls.Add(Pnl_Top);
            Controls.Add(Pnl_bottom);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "SplashScreen";
            Padding = new Padding(0, 12, 0, 12);
            StartPosition = FormStartPosition.CenterScreen;
            Load += SplashScreen_Load;
            Pnl_bottom.ResumeLayout(false);
            Pnl_Top.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel Pnl_bottom;
        private JProgressBar Pgb_SplashScreen;
        private System.Windows.Forms.Panel Pnl_Top;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_LoadingCaption;
    }
}