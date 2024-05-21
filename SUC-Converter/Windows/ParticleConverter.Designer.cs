namespace SUC_Converter.Windows
{
    partial class ParticleConverterWindow
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
            PathInspire = new TextBox();
            BrowseInspire = new Button();
            label1 = new Label();
            StartStagePortButton = new Button();
            SuspendLayout();
            // 
            // PathInspire
            // 
            PathInspire.Anchor = AnchorStyles.Top;
            PathInspire.Location = new Point(110, 25);
            PathInspire.Margin = new Padding(2);
            PathInspire.Name = "PathInspire";
            PathInspire.PlaceholderText = "C:\\SonicUnleashedPreviewBuild\\Sonic\\damage_fire.particle";
            PathInspire.Size = new Size(403, 23);
            PathInspire.TabIndex = 2;
            // 
            // BrowseInspire
            // 
            BrowseInspire.Anchor = AnchorStyles.Top;
            BrowseInspire.Font = new Font("Segoe UI", 8F);
            BrowseInspire.Location = new Point(517, 25);
            BrowseInspire.Margin = new Padding(2);
            BrowseInspire.Name = "BrowseInspire";
            BrowseInspire.Size = new Size(70, 26);
            BrowseInspire.TabIndex = 3;
            BrowseInspire.Text = "Browse...";
            BrowseInspire.UseVisualStyleBackColor = true;
            BrowseInspire.Click += BrowseInspire_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 4;
            label1.Text = "Particle File (PB)";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // StartStagePortButton
            // 
            StartStagePortButton.Location = new Point(11, 55);
            StartStagePortButton.Margin = new Padding(2);
            StartStagePortButton.Name = "StartStagePortButton";
            StartStagePortButton.Size = new Size(574, 32);
            StartStagePortButton.TabIndex = 11;
            StartStagePortButton.Text = "Start";
            StartStagePortButton.UseVisualStyleBackColor = true;
            StartStagePortButton.Click += StartPort_Click;
            // 
            // ParticleConverterWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 96);
            Controls.Add(StartStagePortButton);
            Controls.Add(label1);
            Controls.Add(BrowseInspire);
            Controls.Add(PathInspire);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParticleConverterWindow";
            Text = "SUC-Converter Particle Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PathInspire;
        private Button BrowseInspire;
        private Label label1;
        private Button StartStagePortButton;
    }
}