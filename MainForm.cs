using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using NAudio.Wave;
using System.Linq;

//Elias Canelas
//02/17/2024
//Youtube downloader/mp4->mp3 converter

namespace RedDownload
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            var videoId = txtUrl.Text;
            var outputMp3FilePath = txtOutputPath.Text;

            await DownloadAndConvertToMp3(videoId, outputMp3FilePath);

            lblProcess.Text = "Download Complete!";
        }

        private async Task DownloadAndConvertToMp3(string videoId, string outputMp3Directory)
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(videoId);

            var songName = RemoveInvalidFileNameChars(video.Title);
            var author = RemoveInvalidFileNameChars(video.Author.Title);
                                                                        
            var outputMp3FileName = $"{songName}.{author}.mp3";
            var outputMp3FilePath = Path.Combine(outputMp3Directory, outputMp3FileName);

            Directory.CreateDirectory(outputMp3Directory);

            if (File.Exists(outputMp3FilePath))
            {
                MessageBox.Show("The file already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
            var audioStreamInfo = streamManifest.GetAudioStreams().OrderByDescending(s => s.Bitrate).FirstOrDefault();
            lblProcess.Text = "Starting download...";
            var tempFileName = Guid.NewGuid().ToString("N") + ".mp4";
            var tempFilePath = Path.Combine(outputMp3Directory, tempFileName);

            try
            {
                await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, tempFilePath);
                lblProcess.Text = "Download completed.";
                File.Move(tempFilePath, outputMp3FilePath);
                lblProcess.Text = "File moved to output path.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (File.Exists(tempFilePath))
                {
                    File.Delete(tempFilePath);
                }
            }
        }


        private string RemoveInvalidFileNameChars(string fileName)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            return new string(fileName.Where(c => !invalidChars.Contains(c)).ToArray());
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txtOutputPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
    }
}
