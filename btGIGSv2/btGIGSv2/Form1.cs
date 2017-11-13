using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaInfoLib;
using System.IO;

namespace btGIGSv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Datebase db = new Datebase();
        MovieInfo movie;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog okienko = new OpenFileDialog();
            okienko.Filter = "Pliki Video |*.avi|Pliki MKV |*.mkv";

            
            if (okienko.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Wybrano plik: " + okienko.FileName);
                MessageBox.Show(String.Format("test: {0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.Combine("\\BTGIGS\\btg.s3db")));
            }

            labelMainPage.Text = "Loaded: " + okienko.SafeFileName.ToString();// + "\nPath: " + okienko.FileName.ToString();

            movie = new MovieInfo(okienko.FileName.ToString());

            textBoxVideoCodec.Text = movie.VideoCodec;
            textBoxBitrateVideo.Text = movie.BitRateVideo;
            textBoxResolution.Text = movie.Resolution;
            textBoxFPS.Text = movie.FPS;
            textBoxTime.Text = movie.Time;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db = null;
        }
    }
}
