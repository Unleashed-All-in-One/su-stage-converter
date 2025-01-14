using BlueMystic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUC_Converter.Windows
{
    
    public partial class MainWindow : Form
    {
        private DarkModeCS DM = null;

        public MainWindow()
        {
            InitializeComponent();
            DM = new DarkModeCS(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StagePorterWindow form = new StagePorterWindow();
            form.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CutscenePorterWindow form = new CutscenePorterWindow();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubtitleConverterWindow form = new SubtitleConverterWindow();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParticleConverterWindow form = new ParticleConverterWindow();
            form.Show();
        }

        private void LabelBuildDate_Click(object sender, EventArgs e)
        {

        }
    }
}
public static class AssemblyExtensions
{
    public static DateTime GetLinkerTime(this Assembly assembly, TimeZoneInfo target = null)
    {
        var filePath = assembly.Location;
        const int c_PeHeaderOffset = 60;
        const int c_LinkerTimestampOffset = 8;

        var buffer = new byte[2048];

        using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            stream.Read(buffer, 0, 2048);

        var offset = BitConverter.ToInt32(buffer, c_PeHeaderOffset);
        var secondsSince1970 = BitConverter.ToInt32(buffer, offset + c_LinkerTimestampOffset);
        var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        var linkTimeUtc = epoch.AddSeconds(secondsSince1970);

        var tz = target ?? TimeZoneInfo.Local;
        var localTime = TimeZoneInfo.ConvertTimeFromUtc(linkTimeUtc, tz);

        return localTime;
    }
}