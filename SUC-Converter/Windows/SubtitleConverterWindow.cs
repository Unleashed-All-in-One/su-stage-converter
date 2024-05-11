using BlueMystic;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class SubtitleConverterWindow : Form
    {

        public static List<SubtitleContainer> Subtitles = new List<SubtitleContainer>();
        static bool isRunning;
        string pathToSubtitleResource
        {
            get
            {
                return PathInspire.Text;
            }
        }

        string evsID
        {
            get
            {
                return EVSIDBox.Text;
            }
        }
        string pathToFcoUnleashed
        {
            get
            {
                return FCOUnleashedPath.Text;
            }
        }
        string pathToFcoGens
        {
            get
            {
                return FCOGensPath.Text;
            }
        }


        private DarkModeCS DM = null;
        public SubtitleConverterWindow()
        {
            InitializeComponent();

            DM = new DarkModeCS(this);
            BindingSource source = new BindingSource();
            source.DataSource = Subtitles;
            dataGridView1.DataSource = source;
        }

        private void GetEntries(object sender, EventArgs e)
        {
            SubtitleConverter.cutsceneID = evsID;
            SubtitleConverter.pathFcoUnleashed = pathToFcoUnleashed;
            SubtitleConverter.pathInspireSubtitle = pathToSubtitleResource;
            var subtitlesBB = SubtitleConverter.GetAndConvertFile();
            Subtitles.Clear();
            for (int i = 0;  i < subtitlesBB.Text.Count;  i++)
            {
                Subtitles.Add((new SubtitleContainer("New Entry")));
            }
            BindingSource source = new BindingSource();
            source.DataSource = Subtitles;
            dataGridView1.DataSource = source;
        }   

        private void BrowseInspire_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "Select the XML file and press Enter.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PathInspire.Text = ofd.FileName;
            }
        }
        private void StartMakingFCO(object sender, EventArgs e)
        {
            SubtitleConverter.pathFcoGens = pathToFcoGens;
            SubtitleConverter.CreateFCO(Subtitles);
        }

        private void GetUnleashedFCOButton_Click(object sender, EventArgs e)
        {
            //U BROWSE
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "FCO File|*.fco";
            ofd.Title = "Select the FCO from the Unleashed cutscene and press Enter.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FCOUnleashedPath.Text = ofd.FileName;
            }
        }


        private void GetGensFCOButton_Click(object sender, EventArgs e)
        {
            //G BROWSE
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "FCO File|*.fco";
            ofd.Title = "Select the Subtitle_Cnv.fco file from ActionCommon and press Enter.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FCOGensPath.Text = ofd.FileName;
            }
        }
    }
}
public class SubtitleContainer
{
    public string SubtitleText { get; set; }
    public SubtitleContainer(string subtitleTextV)
    {
        SubtitleText = subtitleTextV;
    }
}
