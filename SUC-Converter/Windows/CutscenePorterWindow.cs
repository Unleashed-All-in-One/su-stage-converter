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
    public partial class CutscenePorterWindow : Form
    {
        static bool isRunning;
        string pathToInspire
        {
            get
            {
                return PathInspire.Text;
            }
        }
        string stageID
        {
            get
            {
                return StageIDBox.Text;
            }
        }
        string evsID
        {
            get
            {
                return EVSIDBox.Text;
            }
        }
        string cueSheet
        {
            get
            {
                return CueSheetBox.Text;
            }
        }
        string cueName
        {
            get
            {
                return CueBox.Text;
            }
        }

        private DarkModeCS DM = null;
        public CutscenePorterWindow()
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
                CutsceneConverter.archivePath = pathToInspire;
                CutsceneConverter.cueSheet = cueSheet;
                CutsceneConverter.cueName = cueName;
                CutsceneConverter.evs_ID = evsID;
                CutsceneConverter.stageID = stageID;
                CutsceneConverter.Start();
                SystemSounds.Exclamation.Play();

            }
            catch(Exception e)
            {
                OutputLog.Log(e.Message);
                OutputLog.Log(e.Source);
                MessageBox.Show(e.ToString());
            }            
            ThreadHelperClass.SetProgressbarStyle(this, progressBar1, ProgressBarStyle.Continuous);
            isRunning = false;
        }


        private void BrowseInspire_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archive File|*.ar.00;*.ar";
            ofd.Title = "Select the Stage.ar.00 file and press Enter.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PathInspire.Text = ofd.FileName;
            }
        }

        private void BrowseHashtag_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archive File|*.ar.00;*.ar";
            ofd.Title = "Select the #Stage.ar.00 file and press Enter.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                EVSIDBox.Text = ofd.FileName;
            }
        }

        private void ConsoleOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
