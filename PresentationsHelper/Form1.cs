using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PresentationsHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
       {
            String textBoxText = textBox2.Text;
            if(isYoutubeUrl(textBoxText))
            {
                string thumbnailImageUrl = String.Format("https://img.youtube.com/vi/{0}/hqdefault.jpg", getYoutubeIdFromUrl(textBoxText));
                youtubePictureBox.Load(thumbnailImageUrl);
            }
        }

        private bool isYoutubeUrl(string url)
        {
            try
            {
                string host = new Uri(url).Host;
                if (host.Replace("www.", "") == "youtube.com" || host == "youtu.be")
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
          
        }

        private static string getYoutubeIdFromUrl(string youtubeUrl)
        {
            var video_id = youtubeUrl.Split(new string[] { "v=" }, StringSplitOptions.None)[1];
            var ampersandPosition = video_id.IndexOf('&');
            if (ampersandPosition != -1)
            {
                video_id = video_id.Substring(0, ampersandPosition);
            }
            return video_id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            youtubePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            initVideosComboBox();
        }


        private void initVideosComboBox()
        {
            var directory = new DirectoryInfo(Constants.presentationsFolder);
            FileInfo[] AllMp4files = directory.GetFiles("*.mp4")
                                              .OrderByDescending(p => p.CreationTime)
                                              .Take(10)
                                              .ToArray();

            foreach(FileInfo fileInfo in AllMp4files)
            {
                presentationsVideosComboBox.Items.Add(fileInfo.Name);
            }
            presentationsVideosComboBox.SelectedIndex=0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoutubeUtils.downloadAudio(textBox2.Text, presentationsVideosComboBox.Text.Replace(".mp4",""));
        }
    }
}
