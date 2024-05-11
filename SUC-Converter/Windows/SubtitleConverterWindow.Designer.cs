namespace SUC_Converter.Windows
{
    partial class SubtitleConverterWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubtitleConverterWindow));
            PathInspire = new TextBox();
            BrowseInspire = new Button();
            label1 = new Label();
            OpenContainer = new Button();
            label2 = new Label();
            EVSIDBox = new TextBox();
            progressBar1 = new ProgressBar();
            label5 = new Label();
            FCOUnleashedPath = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            FCOGensPath = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PathInspire
            // 
            PathInspire.Anchor = AnchorStyles.Top;
            PathInspire.Location = new Point(110, 27);
            PathInspire.Margin = new Padding(2);
            PathInspire.Name = "PathInspire";
            PathInspire.PlaceholderText = "Inspire/subtitle/[eventid].ar/[eventid]_subtitle_English.inspire_resource.xml";
            PathInspire.Size = new Size(403, 23);
            PathInspire.TabIndex = 2;
            // 
            // BrowseInspire
            // 
            BrowseInspire.Anchor = AnchorStyles.Top;
            BrowseInspire.Font = new Font("Segoe UI", 8F);
            BrowseInspire.Location = new Point(517, 27);
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
            label1.Location = new Point(12, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 4;
            label1.Text = "Subtitle Resource";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OpenContainer
            // 
            OpenContainer.Location = new Point(13, 192);
            OpenContainer.Margin = new Padding(2);
            OpenContainer.Name = "OpenContainer";
            OpenContainer.Size = new Size(277, 32);
            OpenContainer.TabIndex = 11;
            OpenContainer.Text = "Get";
            OpenContainer.UseVisualStyleBackColor = true;
            OpenContainer.Click += GetEntries;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(37, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 14;
            label2.Text = "Cutscene ID";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EVSIDBox
            // 
            EVSIDBox.Anchor = AnchorStyles.Top;
            EVSIDBox.Location = new Point(111, 58);
            EVSIDBox.Margin = new Padding(2);
            EVSIDBox.Name = "EVSIDBox";
            EVSIDBox.PlaceholderText = "m0_0_1";
            EVSIDBox.Size = new Size(475, 23);
            EVSIDBox.TabIndex = 12;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(13, 166);
            progressBar1.Margin = new Padding(2);
            progressBar1.MarqueeAnimationSpeed = 50;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(574, 20);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(19, 97);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 27;
            label5.Text = "Unleashed FCO";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FCOUnleashedPath
            // 
            FCOUnleashedPath.Anchor = AnchorStyles.Top;
            FCOUnleashedPath.Location = new Point(110, 94);
            FCOUnleashedPath.Margin = new Padding(2);
            FCOUnleashedPath.Name = "FCOUnleashedPath";
            FCOUnleashedPath.Size = new Size(403, 23);
            FCOUnleashedPath.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(606, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(306, 417);
            dataGridView1.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(309, 192);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(277, 32);
            button1.TabIndex = 29;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StartMakingFCO;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 236);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(573, 211);
            richTextBox1.TabIndex = 30;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(17, 135);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 32;
            label3.Text = "BB Subtitle FCO";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FCOGensPath
            // 
            FCOGensPath.Anchor = AnchorStyles.Top;
            FCOGensPath.Location = new Point(111, 132);
            FCOGensPath.Margin = new Padding(2);
            FCOGensPath.Name = "FCOGensPath";
            FCOGensPath.PlaceholderText = "Generations\\ActionCommon\\Subtitle_Cnv.fco";
            FCOGensPath.Size = new Size(402, 23);
            FCOGensPath.TabIndex = 31;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 8F);
            button2.Location = new Point(516, 94);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(70, 26);
            button2.TabIndex = 33;
            button2.Text = "Browse...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += GetUnleashedFCOButton_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Font = new Font("Segoe UI", 8F);
            button3.Location = new Point(517, 129);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(70, 26);
            button3.TabIndex = 34;
            button3.Text = "Browse...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += GetGensFCOButton_Click;
            // 
            // SubtitleConverterWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 467);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(FCOGensPath);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(FCOUnleashedPath);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(EVSIDBox);
            Controls.Add(OpenContainer);
            Controls.Add(label1);
            Controls.Add(BrowseInspire);
            Controls.Add(PathInspire);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SubtitleConverterWindow";
            Text = "SUC-Converter Subtitle Converter";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PathInspire;
        private Button BrowseInspire;
        private Label label1;
        private Button OpenContainer;
        private Label label2;
        private TextBox EVSIDBox;
        private ProgressBar progressBar1;
        private Label label5;
        private TextBox FCOUnleashedPath;
        private DataGridView dataGridView1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox FCOGensPath;
        private Button button2;
        private Button button3;
    }
}