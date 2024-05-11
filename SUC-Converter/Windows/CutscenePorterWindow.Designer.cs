namespace SUC_Converter.Windows
{
    partial class CutscenePorterWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutscenePorterWindow));
            ConsoleOutput = new RichTextBox();
            PathInspire = new TextBox();
            BrowseInspire = new Button();
            label1 = new Label();
            StartStagePortButton = new Button();
            label2 = new Label();
            EVSIDBox = new TextBox();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            StageIDBox = new TextBox();
            label3 = new Label();
            CueBox = new TextBox();
            label5 = new Label();
            CueSheetBox = new TextBox();
            SuspendLayout();
            // 
            // ConsoleOutput
            // 
            ConsoleOutput.BackColor = SystemColors.WindowText;
            ConsoleOutput.ForeColor = SystemColors.Highlight;
            ConsoleOutput.Location = new Point(12, 205);
            ConsoleOutput.Margin = new Padding(2);
            ConsoleOutput.Name = "ConsoleOutput";
            ConsoleOutput.ReadOnly = true;
            ConsoleOutput.Size = new Size(574, 242);
            ConsoleOutput.TabIndex = 1;
            ConsoleOutput.Text = "To start porting, populate the fields and then press \"Start\"";
            ConsoleOutput.TextChanged += ConsoleOutput_TextChanged;
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
            StartStagePortButton.Location = new Point(13, 157);
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
            label2.Location = new Point(61, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 14;
            label2.Text = "New ID";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EVSIDBox
            // 
            EVSIDBox.Anchor = AnchorStyles.Top;
            EVSIDBox.Location = new Point(110, 56);
            EVSIDBox.Margin = new Padding(2);
            EVSIDBox.Name = "EVSIDBox";
            EVSIDBox.PlaceholderText = "m0_0_1";
            EVSIDBox.Size = new Size(182, 23);
            EVSIDBox.TabIndex = 12;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(13, 131);
            progressBar1.Margin = new Padding(2);
            progressBar1.MarqueeAnimationSpeed = 50;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(574, 20);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 21;
            progressBar1.Click += progressBar1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(349, 60);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 25;
            label4.Text = "Stage ID";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // StageIDBox
            // 
            StageIDBox.Anchor = AnchorStyles.Top;
            StageIDBox.Location = new Point(403, 57);
            StageIDBox.Margin = new Padding(2);
            StageIDBox.Name = "StageIDBox";
            StageIDBox.PlaceholderText = "ghz100";
            StageIDBox.Size = new Size(182, 23);
            StageIDBox.TabIndex = 24;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(347, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 29;
            label3.Text = "CSB Cue";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CueBox
            // 
            CueBox.Anchor = AnchorStyles.Top;
            CueBox.Location = new Point(402, 93);
            CueBox.Margin = new Padding(2);
            CueBox.Name = "CueBox";
            CueBox.PlaceholderText = "m_0_0_1";
            CueBox.Size = new Size(182, 23);
            CueBox.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(57, 95);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 27;
            label5.Text = "CSB File";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CueSheetBox
            // 
            CueSheetBox.Anchor = AnchorStyles.Top;
            CueSheetBox.Location = new Point(109, 92);
            CueSheetBox.Margin = new Padding(2);
            CueSheetBox.Name = "CueSheetBox";
            CueSheetBox.PlaceholderText = "30VCE_STE";
            CueSheetBox.Size = new Size(182, 23);
            CueSheetBox.TabIndex = 26;
            // 
            // CutscenePorterWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 467);
            Controls.Add(label3);
            Controls.Add(CueBox);
            Controls.Add(label5);
            Controls.Add(CueSheetBox);
            Controls.Add(label4);
            Controls.Add(StageIDBox);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(EVSIDBox);
            Controls.Add(StartStagePortButton);
            Controls.Add(label1);
            Controls.Add(BrowseInspire);
            Controls.Add(PathInspire);
            Controls.Add(ConsoleOutput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CutscenePorterWindow";
            Text = "SUC-Converter Cutscene Porter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ConsoleOutput;
        private TextBox PathInspire;
        private Button BrowseInspire;
        private Label label1;
        private Button StartStagePortButton;
        private Label label2;
        private TextBox EVSIDBox;
        private ProgressBar progressBar1;
        private Label label4;
        private TextBox StageIDBox;
        private Label label3;
        private TextBox CueBox;
        private Label label5;
        private TextBox CueSheetBox;
    }
}