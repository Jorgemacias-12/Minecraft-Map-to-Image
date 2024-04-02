namespace Minecraft_Map_To_Image.src.views
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            Pnl_TopBar = new Panel();
            Lbl_WindowTitle = new Label();
            Pbx_ProgramIcon = new PictureBox();
            Btn_Minimize = new Button();
            Btn_ChangeFormState = new Button();
            Btn_Exit = new Button();
            Pnl_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pbx_ProgramIcon).BeginInit();
            SuspendLayout();
            // 
            // Pnl_TopBar
            // 
            Pnl_TopBar.BackColor = Color.FromArgb(43, 45, 66);
            Pnl_TopBar.Controls.Add(Lbl_WindowTitle);
            Pnl_TopBar.Controls.Add(Pbx_ProgramIcon);
            Pnl_TopBar.Controls.Add(Btn_Minimize);
            Pnl_TopBar.Controls.Add(Btn_ChangeFormState);
            Pnl_TopBar.Controls.Add(Btn_Exit);
            Pnl_TopBar.Dock = DockStyle.Top;
            Pnl_TopBar.Location = new Point(0, 0);
            Pnl_TopBar.Name = "Pnl_TopBar";
            Pnl_TopBar.Size = new Size(800, 35);
            Pnl_TopBar.TabIndex = 0;
            Pnl_TopBar.MouseDown += BaseForm_MouseDown;
            // 
            // Lbl_WindowTitle
            // 
            Lbl_WindowTitle.Dock = DockStyle.Fill;
            Lbl_WindowTitle.ForeColor = Color.White;
            Lbl_WindowTitle.Location = new Point(30, 0);
            Lbl_WindowTitle.Name = "Lbl_WindowTitle";
            Lbl_WindowTitle.Size = new Size(676, 35);
            Lbl_WindowTitle.TabIndex = 4;
            Lbl_WindowTitle.Text = "FormText";
            Lbl_WindowTitle.TextAlign = ContentAlignment.MiddleLeft;
            Lbl_WindowTitle.MouseDown += BaseForm_MouseDown;
            // 
            // Pbx_ProgramIcon
            // 
            Pbx_ProgramIcon.BackgroundImage = Properties.Resources.app_icon;
            Pbx_ProgramIcon.BackgroundImageLayout = ImageLayout.Stretch;
            Pbx_ProgramIcon.Dock = DockStyle.Left;
            Pbx_ProgramIcon.Location = new Point(0, 0);
            Pbx_ProgramIcon.Name = "Pbx_ProgramIcon";
            Pbx_ProgramIcon.Size = new Size(30, 35);
            Pbx_ProgramIcon.TabIndex = 3;
            Pbx_ProgramIcon.TabStop = false;
            // 
            // Btn_Minimize
            // 
            Btn_Minimize.Dock = DockStyle.Right;
            Btn_Minimize.FlatAppearance.BorderSize = 0;
            Btn_Minimize.FlatStyle = FlatStyle.Flat;
            Btn_Minimize.Font = new Font("Monocraft", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Minimize.ForeColor = Color.White;
            Btn_Minimize.Location = new Point(706, 0);
            Btn_Minimize.Name = "Btn_Minimize";
            Btn_Minimize.Size = new Size(30, 35);
            Btn_Minimize.TabIndex = 1;
            Btn_Minimize.Text = "-";
            Btn_Minimize.UseVisualStyleBackColor = true;
            Btn_Minimize.Click += Btn_Minimize_Click;
            // 
            // Btn_ChangeFormState
            // 
            Btn_ChangeFormState.Dock = DockStyle.Right;
            Btn_ChangeFormState.FlatAppearance.BorderSize = 0;
            Btn_ChangeFormState.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 119, 182);
            Btn_ChangeFormState.FlatStyle = FlatStyle.Flat;
            Btn_ChangeFormState.Font = new Font("Monocraft Nerd Font", 10F);
            Btn_ChangeFormState.ForeColor = Color.White;
            Btn_ChangeFormState.Location = new Point(736, 0);
            Btn_ChangeFormState.Name = "Btn_ChangeFormState";
            Btn_ChangeFormState.Size = new Size(34, 35);
            Btn_ChangeFormState.TabIndex = 0;
            Btn_ChangeFormState.Text = "■";
            Btn_ChangeFormState.UseVisualStyleBackColor = true;
            Btn_ChangeFormState.Click += Btn_ChangeFormState_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Dock = DockStyle.Right;
            Btn_Exit.FlatAppearance.BorderSize = 0;
            Btn_Exit.FlatAppearance.MouseDownBackColor = Color.FromArgb(239, 35, 60);
            Btn_Exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 4, 41);
            Btn_Exit.FlatStyle = FlatStyle.Flat;
            Btn_Exit.Font = new Font("Monocraft Nerd Font", 12F);
            Btn_Exit.ForeColor = Color.White;
            Btn_Exit.Location = new Point(770, 0);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(30, 35);
            Btn_Exit.TabIndex = 2;
            Btn_Exit.Text = "X";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 41);
            ClientSize = new Size(800, 600);
            ControlBox = false;
            Controls.Add(Pnl_TopBar);
            DoubleBuffered = true;
            Font = new Font("Monocraft", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(100, 100);
            Name = "BaseForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "BaseForm";
            MouseDown += BaseForm_MouseDown;
            Pnl_TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pbx_ProgramIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_TopBar;
        private PictureBox Pbx_ProgramIcon;
        protected Label Lbl_WindowTitle;
        protected Button Btn_Exit;
        protected Button Btn_Minimize;
        protected Button Btn_ChangeFormState;
    }
}