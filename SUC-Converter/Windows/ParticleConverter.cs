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
    public partial class ParticleConverterWindow : Form
    {
        static bool isRunning;
        string pathToSparkle
        {
            get
            {
                return PathInspire.Text;
            }
        }

        private DarkModeCS DM = null;
        public ParticleConverterWindow()
        {
            InitializeComponent();

            DM = new DarkModeCS(this);
        }


        private void StartPort_Click(object sender, EventArgs e)
        {
            if (isRunning)
                return;

            ParticleConverter.Setup(@pathToSparkle);
            ParticleConverter.Run();
        }
        private void DoSomething()
        {
            isRunning = true;
            try
            {
                SystemSounds.Exclamation.Play();

            }
            catch (Exception e)
            {
                OutputLog.Log(e.Message);
                OutputLog.Log(e.Source);
                MessageBox.Show(e.ToString());
            }
            isRunning = false;
        }


        private void BrowseInspire_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SWA Preview Build Particle |*.particle";
            ofd.Title = "Select the particle file and press Enter.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PathInspire.Text = ofd.FileName;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
