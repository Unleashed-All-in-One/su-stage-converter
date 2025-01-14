using BlueMystic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SUC_Converter.Windows
{
    public partial class StagePorterWindow : Form
    {
        static bool isRunning;
        string pathToStageArchive
        {
            get
            {
                return PathStage.Text;
            }
        }
        string pathToStageArchiveHashtag
        {
            get
            {
                return PathHashtag.Text;
            }
        }
        string pathToPfd
        {
            get
            {
                return PathStagePfd.Text;
            }
        }
        string pathToPfdAdd
        {
            get
            {
                return PathStagePfdAdd.Text;
            }
        }
        string stageID
        {
            get
            {
                return textBox1.Text;
            }
        }
        private DarkModeCS DM = null;
        public StagePorterWindow()
        {
            InitializeComponent();
            OutputLog.OutputChanged += ConsoleUpdated;

            DM = new DarkModeCS(this);
        }

        private void ConsoleUpdated(object? sender, EventArgs e)
        {
            ThreadHelperClass.SetText(this, ConsoleOutput, OutputLog.Output);
        }

        private void StartPort_Click(object sender, EventArgs e)
        {
            if (isRunning)
                return;
            progressBar1.Style = ProgressBarStyle.Marquee;
            Thread myThread = new Thread(new ThreadStart(DoSomething));
            myThread.Start();
        }
        private void DoSomething()
        {
            isRunning = true;
            try
            {
                Program.pathToStageArchive = Utility.AddQuotesIfRequired(pathToStageArchive);
                Program.pathToSetArchive = Utility.AddQuotesIfRequired(pathToStageArchiveHashtag);
                Program.pathToStagePfd = Utility.AddQuotesIfRequired(pathToPfd);
                Program.pathToStagePfdAdd = Utility.AddQuotesIfRequired(pathToPfdAdd);
                Program.m_StageID = stageID;
                Program.CleanupLastTry();
                Program.CopyArchivesToProgram();
                Program.MoveFilesToCorrectLocations();
                Program.MoveStageToBBStyleFolder();
                Program.MakeNewHashtagFolderContents();
                Program.UncompressPFD();
                Program.MatFixer();
                Program.RepackEverything();
                Program.Cleanup();
                OutputLog.Log("Port has been completed. You'll now have to repack the terrain geometry in GLVL.");
                SystemSounds.Exclamation.Play();
            }
            catch (Exception e)
            {
                OutputLog.Log(e.Message);
                OutputLog.Log(e.Source);
                MessageBox.Show(e.ToString());
            }
            ThreadHelperClass.SetProgressbarStyle(this, progressBar1, ProgressBarStyle.Continuous);
            isRunning = false;
        }

        private void PathStage_TextChanged(object sender, EventArgs e)
        {

        }
        private void BrowseStage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archive File|*.ar.00;*.ar";
            ofd.Title = "Select the Stage.ar.00 file and press Enter.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PathStage.Text = ofd.FileName;
            }
        }

        private void BrowseHashtag_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archive File|*.ar.00;*.ar";
            ofd.Title = "Select the #Stage.ar.00 file and press Enter.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PathHashtag.Text = ofd.FileName;
            }
        }

        private void BrowsePFD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the Stage.pfd file from Packed for this stage and press Enter.";
            ofd.Filter = "GI Archive File|*.pfd";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PathStagePfd.Text = ofd.FileName;
            }
        }

        private void BrowsePFD_ADD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the Stage-Add.pfd file from Packed for this stage and press Enter.";
            ofd.Filter = "GI Archive File|*.pfd";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PathStagePfdAdd.Text = ofd.FileName;
            }
        }

        private void ConsoleOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputLog.Output);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
