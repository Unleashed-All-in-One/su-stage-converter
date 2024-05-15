namespace SUC_Converter.Windows
{
    partial class StagePorterWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StagePorterWindow));
            ConsoleOutput = new RichTextBox();
            PathStage = new TextBox();
            BrowseStage = new Button();
            label1 = new Label();
            StartStagePortButton = new Button();
            label2 = new Label();
            BrowseHashtag = new Button();
            PathHashtag = new TextBox();
            label3 = new Label();
            BrowsePFD = new Button();
            PathStagePfd = new TextBox();
            label4 = new Label();
            BrowsePFD_ADD = new Button();
            PathStagePfdAdd = new TextBox();
            progressBar1 = new ProgressBar();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ConsoleOutput
            // 
            ConsoleOutput.BackColor = SystemColors.WindowText;
            ConsoleOutput.ForeColor = SystemColors.Highlight;
            ConsoleOutput.Location = new Point(327, 22);
            ConsoleOutput.Margin = new Padding(2);
            ConsoleOutput.Name = "ConsoleOutput";
            ConsoleOutput.ReadOnly = true;
            ConsoleOutput.Size = new Size(261, 460);
            ConsoleOutput.TabIndex = 1;
            ConsoleOutput.Text = "To start porting, populate the fields and then press \"Start\"";
            ConsoleOutput.TextChanged += ConsoleOutput_TextChanged;
            // 
            // PathStage
            // 
            PathStage.Anchor = AnchorStyles.Top;
            PathStage.Location = new Point(109, 25);
            PathStage.Margin = new Padding(2);
            PathStage.Name = "PathStage";
            PathStage.PlaceholderText = "ghz100.ar";
            PathStage.Size = new Size(133, 23);
            PathStage.TabIndex = 2;
            PathStage.TextChanged += PathStage_TextChanged;
            // 
            // BrowseStage
            // 
            BrowseStage.Anchor = AnchorStyles.Top;
            BrowseStage.Font = new Font("Segoe UI", 8F);
            BrowseStage.Location = new Point(244, 25);
            BrowseStage.Margin = new Padding(2);
            BrowseStage.Name = "BrowseStage";
            BrowseStage.Size = new Size(70, 26);
            BrowseStage.TabIndex = 3;
            BrowseStage.Text = "Browse...";
            BrowseStage.UseVisualStyleBackColor = true;
            BrowseStage.Click += BrowseStage_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Stage Archive";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // StartStagePortButton
            // 
            StartStagePortButton.Location = new Point(11, 224);
            StartStagePortButton.Margin = new Padding(2);
            StartStagePortButton.Name = "StartStagePortButton";
            StartStagePortButton.Size = new Size(302, 31);
            StartStagePortButton.TabIndex = 11;
            StartStagePortButton.Text = "Start";
            StartStagePortButton.UseVisualStyleBackColor = true;
            StartStagePortButton.Click += StartPort_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 14;
            label2.Text = "Hashtag Archive";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BrowseHashtag
            // 
            BrowseHashtag.Anchor = AnchorStyles.Top;
            BrowseHashtag.Font = new Font("Segoe UI", 8F);
            BrowseHashtag.Location = new Point(244, 56);
            BrowseHashtag.Margin = new Padding(2);
            BrowseHashtag.Name = "BrowseHashtag";
            BrowseHashtag.Size = new Size(70, 26);
            BrowseHashtag.TabIndex = 13;
            BrowseHashtag.Text = "Browse...";
            BrowseHashtag.UseVisualStyleBackColor = true;
            BrowseHashtag.Click += BrowseHashtag_Click;
            // 
            // PathHashtag
            // 
            PathHashtag.Anchor = AnchorStyles.Top;
            PathHashtag.Location = new Point(109, 56);
            PathHashtag.Margin = new Padding(2);
            PathHashtag.Name = "PathHashtag";
            PathHashtag.PlaceholderText = "#ghz100.ar";
            PathHashtag.Size = new Size(133, 23);
            PathHashtag.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 17;
            label3.Text = "Stage.pfd";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BrowsePFD
            // 
            BrowsePFD.Anchor = AnchorStyles.Top;
            BrowsePFD.Font = new Font("Segoe UI", 8F);
            BrowsePFD.Location = new Point(244, 89);
            BrowsePFD.Margin = new Padding(2);
            BrowsePFD.Name = "BrowsePFD";
            BrowsePFD.Size = new Size(70, 26);
            BrowsePFD.TabIndex = 16;
            BrowsePFD.Text = "Browse...";
            BrowsePFD.UseVisualStyleBackColor = true;
            BrowsePFD.Click += BrowsePFD_Click;
            // 
            // PathStagePfd
            // 
            PathStagePfd.Anchor = AnchorStyles.Top;
            PathStagePfd.Location = new Point(109, 89);
            PathStagePfd.Margin = new Padding(2);
            PathStagePfd.Name = "PathStagePfd";
            PathStagePfd.PlaceholderText = "ghz100\\Stage.pfd";
            PathStagePfd.Size = new Size(133, 23);
            PathStagePfd.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 20;
            label4.Text = "Stage-Add.pfd";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BrowsePFD_ADD
            // 
            BrowsePFD_ADD.Anchor = AnchorStyles.Top;
            BrowsePFD_ADD.Font = new Font("Segoe UI", 8F);
            BrowsePFD_ADD.Location = new Point(244, 123);
            BrowsePFD_ADD.Margin = new Padding(2);
            BrowsePFD_ADD.Name = "BrowsePFD_ADD";
            BrowsePFD_ADD.Size = new Size(70, 26);
            BrowsePFD_ADD.TabIndex = 19;
            BrowsePFD_ADD.Text = "Browse...";
            BrowsePFD_ADD.UseVisualStyleBackColor = true;
            BrowsePFD_ADD.Click += BrowsePFD_ADD_Click;
            // 
            // PathStagePfdAdd
            // 
            PathStagePfdAdd.Anchor = AnchorStyles.Top;
            PathStagePfdAdd.Location = new Point(109, 123);
            PathStagePfdAdd.Margin = new Padding(2);
            PathStagePfdAdd.Name = "PathStagePfdAdd";
            PathStagePfdAdd.PlaceholderText = "ghz100\\Stage-Add.pfd";
            PathStagePfdAdd.Size = new Size(133, 23);
            PathStagePfdAdd.TabIndex = 18;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(11, 198);
            progressBar1.Margin = new Padding(2);
            progressBar1.MarqueeAnimationSpeed = 50;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(302, 19);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 21;
            progressBar1.Click += progressBar1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 278);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(303, 232);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(327, 483);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(260, 24);
            button1.TabIndex = 23;
            button1.Text = "Copy log to clipboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(11, 162);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 25;
            label5.Text = "New Stage ID";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(108, 159);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ActD_Mykonos";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // StagePorterWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 530);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(BrowsePFD_ADD);
            Controls.Add(PathStagePfdAdd);
            Controls.Add(label3);
            Controls.Add(BrowsePFD);
            Controls.Add(PathStagePfd);
            Controls.Add(label2);
            Controls.Add(BrowseHashtag);
            Controls.Add(PathHashtag);
            Controls.Add(StartStagePortButton);
            Controls.Add(label1);
            Controls.Add(BrowseStage);
            Controls.Add(PathStage);
            Controls.Add(ConsoleOutput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StagePorterWindow";
            Text = "SUC-Converter Stage Porter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ConsoleOutput;
        private TextBox PathStage;
        private Button BrowseStage;
        private Label label1;
        private Button StartStagePortButton;
        private Label label2;
        private Button BrowseHashtag;
        private TextBox PathHashtag;
        private Label label3;
        private Button BrowsePFD;
        private TextBox PathStagePfd;
        private Label label4;
        private Button BrowsePFD_ADD;
        private TextBox PathStagePfdAdd;
        private ProgressBar progressBar1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label5;
        private TextBox textBox1;
    }
}