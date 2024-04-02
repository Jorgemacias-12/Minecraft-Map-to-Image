namespace Minecraft_Map_To_Image.src.views
{
    partial class EditionSelector
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
            Tbl_EditionsContainer = new TableLayoutPanel();
            Mec_Bedrock = new components.MinecraftEditionCard();
            Mec_Java = new components.MinecraftEditionCard();
            Tbl_EditionsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_WindowTitle
            // 
            Lbl_WindowTitle.Size = new Size(453, 35);
            Lbl_WindowTitle.Text = "Edition Selector";
            Lbl_WindowTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Exit
            // 
            Btn_Exit.FlatAppearance.BorderSize = 0;
            Btn_Exit.FlatAppearance.MouseDownBackColor = Color.FromArgb(239, 35, 60);
            Btn_Exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 4, 41);
            Btn_Exit.Location = new Point(547, 0);
            // 
            // Btn_Minimize
            // 
            Btn_Minimize.FlatAppearance.BorderSize = 0;
            Btn_Minimize.Location = new Point(483, 0);
            // 
            // Btn_ChangeFormState
            // 
            Btn_ChangeFormState.FlatAppearance.BorderSize = 0;
            Btn_ChangeFormState.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 119, 182);
            Btn_ChangeFormState.Location = new Point(513, 0);
            // 
            // Tbl_EditionsContainer
            // 
            Tbl_EditionsContainer.ColumnCount = 2;
            Tbl_EditionsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tbl_EditionsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tbl_EditionsContainer.Controls.Add(Mec_Bedrock, 0, 0);
            Tbl_EditionsContainer.Controls.Add(Mec_Java, 1, 0);
            Tbl_EditionsContainer.Dock = DockStyle.Fill;
            Tbl_EditionsContainer.Location = new Point(0, 35);
            Tbl_EditionsContainer.Name = "Tbl_EditionsContainer";
            Tbl_EditionsContainer.RowCount = 1;
            Tbl_EditionsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tbl_EditionsContainer.Size = new Size(577, 331);
            Tbl_EditionsContainer.TabIndex = 1;
            // 
            // Mec_Bedrock
            // 
            Mec_Bedrock.BackColor = Color.FromArgb(33, 37, 41);
            Mec_Bedrock.Dock = DockStyle.Fill;
            Mec_Bedrock.Edition = logic.utils.Enums.Minecraft.Bedrock;
            Mec_Bedrock.EditionImage = null;
            Mec_Bedrock.EditionName = "Bedrock";
            Mec_Bedrock.Location = new Point(3, 3);
            Mec_Bedrock.Name = "Mec_Bedrock";
            Mec_Bedrock.Size = new Size(282, 325);
            Mec_Bedrock.TabIndex = 0;
            // 
            // Mec_Java
            // 
            Mec_Java.BackColor = Color.FromArgb(33, 37, 41);
            Mec_Java.Dock = DockStyle.Fill;
            Mec_Java.Edition = logic.utils.Enums.Minecraft.Java;
            Mec_Java.EditionImage = null;
            Mec_Java.EditionName = "Java";
            Mec_Java.Location = new Point(291, 3);
            Mec_Java.Name = "Mec_Java";
            Mec_Java.Size = new Size(283, 325);
            Mec_Java.TabIndex = 1;
            // 
            // EditionSelector
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 366);
            Controls.Add(Tbl_EditionsContainer);
            Location = new Point(0, 0);
            Name = "EditionSelector";
            Text = "EditionSelector";
            Load += EditionSelector_Load;
            Controls.SetChildIndex(Tbl_EditionsContainer, 0);
            Tbl_EditionsContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Tbl_EditionsContainer;
        private components.MinecraftEditionCard Mec_Bedrock;
        private components.MinecraftEditionCard Mec_Java;
    }
}