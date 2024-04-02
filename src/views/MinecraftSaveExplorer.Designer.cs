namespace Minecraft_Map_To_Image.src.views
{
    partial class MinecraftSaveExplorer
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
            SuspendLayout();
            // 
            // Lbl_WindowTitle
            // 
            Lbl_WindowTitle.Text = "Minecraft Map To Image";
            Lbl_WindowTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Exit
            // 
            Btn_Exit.FlatAppearance.BorderSize = 0;
            Btn_Exit.FlatAppearance.MouseDownBackColor = Color.FromArgb(239, 35, 60);
            Btn_Exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 4, 41);
            // 
            // Btn_Minimize
            // 
            Btn_Minimize.FlatAppearance.BorderSize = 0;
            // 
            // Btn_ChangeFormState
            // 
            Btn_ChangeFormState.FlatAppearance.BorderSize = 0;
            Btn_ChangeFormState.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 119, 182);
            // 
            // MinecraftSaveExplorer
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Location = new Point(0, 0);
            Name = "MinecraftSaveExplorer";
            Text = "MinecraftMapsAndSavesViewer";
            ResumeLayout(false);
        }

        #endregion
    }
}