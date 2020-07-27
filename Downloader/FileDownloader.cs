//######################################################################
//# FILENAME: ApplicationInstanceChecker
//#
//# DESCRIPTION:
//# 
//#
//# AUTHOR:		Mohammad Saiful Alam
//# POSITION:	Senior General Manager
//# E-MAIL:		saiful.alam@ bjitgroup.com
//# CREATE DATE: ...
//#
//# Copyright (c): Free to use
//######################################################################
using System;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace Downloader
{
    class FileDownloader: AbsDownloader
    {
        public FileDownloader(System.Windows.Forms.Label progress) : base(progress)
        {
         
        }

        //
        public void Download(string remoteUri, IDownloadObserver observer)
        {
            this.url = remoteUri;
            // Set the Notiifcation Observer..
            this.DownloadObserver = observer;   
            //
            String fileName = Path.GetFileName(remoteUri);
            string filePath = Directory.GetCurrentDirectory() + "\\" + fileName;
            this.downloadLocation = filePath;
            //
            //using (WebClient client = new WebClient())
            mWebClient = new WebClient();
            try
            {
                //To FIX this => "The request was aborted: Could not create SSL/TLS secure channel."
                // using System.Net;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                // Use SecurityProtocolType.Ssl3 if needed for compatibility reasons

                start = DateTime.Now;                  
                Uri uri = new Uri(remoteUri);
                //password username of your file server eg. ftp username and password
                //client.Credentials = new NetworkCredential("usr", "pass");

                //delegate method, which will be called after file download has been complete.
                mWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(onComplete);
                //delegate method for progress notification handler.
                mWebClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(onContinue);
                // uri is the remote url where filed needs to be downloaded, and FilePath is the location where file to be saved
                mWebClient.DownloadFileAsync(uri, filePath);
                //                    
            }
            catch (Exception e)
            {
                onComplete(this, new AsyncCompletedEventArgs(e, false, null));
            }
        }

        //
        public void onContinue(object sender, DownloadProgressChangedEventArgs e)
        {
            this.downloadStatus = "Continue";
            //
            if (e.ProgressPercentage > 0)
            {
                TimeSpan tss = DateTime.Now - start;
                long percent = e.ProgressPercentage;
                long remaining = ((e.TotalBytesToReceive - e.BytesReceived) * Convert.ToInt32(tss.Milliseconds) / e.BytesReceived);

                // TODO has problem need to FIX it...
                string result = "N/A";

                Console.WriteLine("Remaining time:" + result);

                if(this.DownloadObserver != null)
                {                   
                    this.uodateStatus("Percent: " + e.ProgressPercentage);                                   
                    DownloadArgument dArgument = new DownloadArgument(e, this);
                    dArgument.RemainingTime = result;
                    DownloadObserver.onContinue(dArgument);
                }               
            }

            Console.WriteLine($"Download status: {e.ProgressPercentage}%.");
        }
    }
}
