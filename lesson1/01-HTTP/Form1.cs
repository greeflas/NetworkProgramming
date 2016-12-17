using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace _01_HTTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url.Text);
            request.Headers.Add("Accept-Language: ru-RU");

            HttpWebResponse responce = null;
            try
            {
                responce = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(responce.GetResponseStream(), Encoding.UTF8);
                HTML.Text = reader.ReadToEnd();
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
