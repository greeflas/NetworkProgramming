using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace _02_WebClient
{
    public partial class WebClientForm : Form
    {
        WebClient client;
        string url = "https://yandex.ua/images/today";

        public WebClientForm()
        {
            InitializeComponent();
        }

        void AddImage(Image img)
        {
            ImageContainer.Image = ResizeImage.FixedSize(img, ImageContainer.Width, ImageContainer.Height, false);
        }

        void ShowResultTime(DateTime start, DateTime finish)
        {
            lblDownloadingTime.Text = (finish - start).Milliseconds.ToString();
        }

        private void btnLoadIamge_Click(object sender, EventArgs e)
        {
            try
            {
                client = new WebClient();

                string resultFile = "image.jpg";

                DateTime start = DateTime.UtcNow;
                client.DownloadFile(url, resultFile);
                DateTime finish = DateTime.UtcNow;

                AddImage(Image.FromFile(resultFile));
                ShowResultTime(start, finish);

                client.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownloadBigImage_Click(object sender, EventArgs e)
        {
            try
            {
                client = new WebClient();

                string resultFile = "big-image.jpg";
                
                DateTime start = DateTime.UtcNow;

                Stream stream = client.OpenRead(url);
                Stream fileStream = File.OpenWrite(resultFile);

                const int BUFF_SIZE = 4096;
                byte[] buff = new byte[BUFF_SIZE];

                int bytesRead = stream.Read(buff, 0, BUFF_SIZE);
                while (bytesRead > 0)
                {
                    fileStream.Write(buff, 0, bytesRead);
                    bytesRead = stream.Read(buff, 0, BUFF_SIZE);
                }

                fileStream.Close();
                stream.Close();

                DateTime finish = DateTime.UtcNow;

                AddImage(Image.FromFile(resultFile));
                ShowResultTime(start, finish);

                client.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
