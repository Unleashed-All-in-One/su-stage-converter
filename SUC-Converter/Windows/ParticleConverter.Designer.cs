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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticleConverter));
            PathInspire = new TextBox();
            BrowseInspire = new Button();
            label1 = new Label();
            StartStagePortButton = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // PathInspire
            // 
            PathInspire.Anchor = AnchorStyles.Top;
            PathInspire.Location = new Point(109, 25);
            PathInspire.Margin = new Padding(2);
            PathInspire.Name = "PathInspire";
            PathInspire.PlaceholderText = "C:\\SonicUnleashed\\Inspire\\evrt_xxx.ar";
            PathInspire.Size = new Size(403, 23);
            PathInspire.TabIndex = 2;
            // 
            // BrowseInspire
            // 
            BrowseInspire.Anchor = AnchorStyles.Top;
            BrowseInspire.Font = new Font("Segoe UI", 8F);
            BrowseInspire.Location = new Point(516, 25);
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
            label1.Location = new Point(11, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 4;
            label1.Text = "Cutscene Archive";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // StartStagePortButton
            // 
            StartStagePortButton.Location = new Point(11, 109);
            StartStagePortButton.Margin = new Padding(2);
            StartStagePortButton.Name = "StartStagePortButton";
            StartStagePortButton.Size = new Size(574, 32);
            StartStagePortButton.TabIndex = 11;
            StartStagePortButton.Text = "Start";
            StartStagePortButton.UseVisualStyleBackColor = true;
            StartStagePortButton.Click += StartPort_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(11, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 23;
            label2.Text = "Output";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(109, 63);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "C:\\SonicUnleashed\\Inspire\\evrt_xxx.ar";
            textBox1.Size = new Size(476, 23);
            textBox1.TabIndex = 22;
            // 
            // ParticleConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 150);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(StartStagePortButton);
            Controls.Add(label1);
            Controls.Add(BrowseInspire);
            Controls.Add(PathInspire);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            //Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParticleConverter";
            Text = "SUC-Converter Cutscene Porter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PathInspire;
        private Button BrowseInspire;
        private Label label1;
        private Button StartStagePortButton;
        private Label label2;
        private TextBox textBox1;
    }
}