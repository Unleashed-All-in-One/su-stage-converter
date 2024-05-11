using BlueMystic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
