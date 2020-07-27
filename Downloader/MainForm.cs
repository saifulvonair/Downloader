using System;
using System.Windows.Forms;

namespace Downloader
{
    public partial class MainForm : Form, IDownloadObserver
    {
        DownloadManager DownloadManager = new DownloadManager();

        public MainForm()
        {
            InitializeComponent();
        }
        
        public void onComplete(DownloadArgument e)
        {

        }

        public void onContinue(DownloadArgument e)
        {

        }

        public void onMessage(DownloadArgument e)
        {
            if(e.Message == "NetworkFailed")
            {
                MessageBox.Show("No internet available !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadManager.executeOperation(this.button1, lblval1, txtUrl.Text, this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DownloadManager.executeOperation(this.button2, lblval2, txtUrl2.Text, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DownloadManager.executeOperation(this.button3, lblval3, txtUrl3.Text, this);
        }
        
       

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.btnAll.Enabled = false;

            DownloadManager.executeAllOperation(this.button2, lblval2, txtUrl2.Text, this);
            DownloadManager.executeAllOperation(this.button1, lblval1, txtUrl.Text, this);
            DownloadManager.executeAllOperation(this.button3, lblval3, txtUrl3.Text, this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DownloadManager.RemoveAll();

            this.btnAll.Enabled = true;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            //
            this.lblval1.Text = "Progress";
            this.lblval2.Text = "Progress";
            this.lblval3.Text = "Progress";
            //
            this.button1.Text = "Download";
            this.button2.Text = "Download";
            this.button3.Text = "Download";
        }
    }
}
