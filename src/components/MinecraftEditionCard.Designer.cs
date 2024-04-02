namespace Minecraft_Map_To_Image.src.components
{
    partial class MinecraftEditionCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Pbx_EditionImage = new PictureBox();
            Pnl_Controls = new Panel();
            Btn_ChooseEdition = new Button();
            Lbl_EditionName = new Label();
            ((System.ComponentModel.ISupportInitialize)Pbx_EditionImage).BeginInit();
            Pnl_Controls.SuspendLayout();
            SuspendLayout();
            // 
            // Pbx_EditionImage
            // 
            Pbx_EditionImage.Dock = DockStyle.Fill;
            Pbx_EditionImage.Location = new Point(0, 0);
            Pbx_EditionImage.Name = "Pbx_EditionImage";
            Pbx_EditionImage.Size = new Size(248, 208);
            Pbx_EditionImage.TabIndex = 0;
            Pbx_EditionImage.TabStop = false;
            // 
            // Pnl_Controls
            // 
            Pnl_Controls.Controls.Add(Btn_ChooseEdition);
            Pnl_Controls.Dock = DockStyle.Bottom;
            Pnl_Controls.Location = new Point(0, 239);
            Pnl_Controls.Name = "Pnl_Controls";
            Pnl_Controls.Padding = new Padding(5);
            Pnl_Controls.Size = new Size(248, 44);
            Pnl_Controls.TabIndex = 1;
            // 
            // Btn_ChooseEdition
            // 
            Btn_ChooseEdition.BackColor = Color.FromArgb(65, 40, 153);
            Btn_ChooseEdition.Dock = DockStyle.Fill;
            Btn_ChooseEdition.FlatAppearance.BorderSize = 0;
            Btn_ChooseEdition.FlatStyle = FlatStyle.Flat;
            Btn_ChooseEdition.ForeColor = Color.White;
            Btn_ChooseEdition.Location = new Point(5, 5);
            Btn_ChooseEdition.Name = "Btn_ChooseEdition";
            Btn_ChooseEdition.Size = new Size(238, 34);
            Btn_ChooseEdition.TabIndex = 0;
            Btn_ChooseEdition.Text = "Escoger Edición";
            Btn_ChooseEdition.UseVisualStyleBackColor = false;
            // 
            // Lbl_EditionName
            // 
            Lbl_EditionName.Dock = DockStyle.Bottom;
            Lbl_EditionName.ForeColor = Color.White;
            Lbl_EditionName.Location = new Point(0, 208);
            Lbl_EditionName.Name = "Lbl_EditionName";
            Lbl_EditionName.Size = new Size(248, 31);
            Lbl_EditionName.TabIndex = 2;
            Lbl_EditionName.Text = "Edition";
            Lbl_EditionName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MinecraftEditionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 41);
            Controls.Add(Pbx_EditionImage);
            Controls.Add(Lbl_EditionName);
            Controls.Add(Pnl_Controls);
            Name = "MinecraftEditionCard";
            Size = new Size(248, 283);
            ((System.ComponentModel.ISupportInitialize)Pbx_EditionImage).EndInit();
            Pnl_Controls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Pbx_EditionImage;
        private Panel Pnl_Controls;
        private Label Lbl_EditionName;
        public Button Btn_ChooseEdition;
    }
}
