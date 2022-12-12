using YoutubeExtractor;

namespace YouTubeDowloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboResolution.SelectedIndex = 1;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string link = txtUrl.Text;
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);

            VideoInfo video = videoInfos
                .Where(info => info.CanExtractAudio)
                .OrderByDescending(info => info.AudioBitrate)
                .First();

            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            
            var audioDownloader = new AudioDownloader(video, Path.Combine("D:/University", video.Title + video.AudioExtension));

            audioDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage * 0.85);
            audioDownloader.AudioExtractionProgressChanged += (sender, args) => Console.WriteLine(85 + args.ProgressPercentage * 0.15);
            audioDownloader.Execute();
        }

        /*
        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            //Get url video
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(txtUrl.Text);
            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(cboResolution.Text));
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);

            //Download video
            VideoDownloader downloader = new VideoDownloader(video, Path.Combine(Application.StartupPath + "\\", video.Title + video.VideoExtension));
            downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;

            //Create a new thread to download file
            Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
            thread.Start();

            // ------------------

            //Update progressbar
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar.Value = (int)e.ProgressPercentage;
                lblPercentage.Text = $"{string.Format("{0:0.##}", e.ProgressPercentage)}%";//C# 6.0
                progressBar.Update();
            }));
        }
        */

    }
}