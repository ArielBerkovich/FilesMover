using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YoutubeExtractor;
namespace PresentationsHelper
{
    class YoutubeUtils
    {
        private YoutubeUtils() { }

        public static bool isYoutubeUrl(string url)
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
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void downloadAudio(string youtubeUrl,string presentationName)
        {
            youtubeUrl = youtubeUrl.Replace("watch?v=", "v/");
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(youtubeUrl);
            VideoInfo video = videoInfos
                            .Where(info => info.CanExtractAudio)
                            .OrderByDescending(info => info.AudioBitrate)
                            .First();
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }
            ProgressBar p = new ProgressBar();
            p.Location = new Point(10, 10);
            p.Size = new Size(100, 30);
            p.MarqueeAnimationSpeed = 30;
            p.Style = ProgressBarStyle.Marquee;
            p.Visible = true;
            p.Maximum = 100;
            var audioDownloader = new AudioDownloader(video, Path.Combine(Constants.outputFolder+ presentationName, video.Title + video.AudioExtension));
            audioDownloader.DownloadProgressChanged += (sender, args) => p.Value = (int)(args.ProgressPercentage * 0.85);
            audioDownloader.AudioExtractionProgressChanged += (sender, args) => p.Value = (int)(85 + args.ProgressPercentage * 0.15);
            audioDownloader.Execute();
        }
    }
}
