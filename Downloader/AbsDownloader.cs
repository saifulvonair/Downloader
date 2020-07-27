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
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Downloader
{
   public class AbsDownloader: IDownloader
    {
        protected Label mProgress;
        protected IDownloadObserver mObserver;
        protected DateTime start;
        protected string downloadLocation;
        protected string url;
        public string URL { get { return url; } }

        

        public DownloadArgument mResult;
        //
        protected WebClient mWebClient;
        //
        public string DownloadLocation { get {return downloadLocation; } }

        //
        public IDownloadObserver DownloadObserver
        {
            get
            {
                return mObserver;
            }

            set
            {
                mObserver = value;
            }
        }

        protected string downloadStatus;
        public string DownloadStatus { get { return downloadStatus; } }

        //
        public Label Progress
        {
            get
            {
                return mProgress;
            }

            set
            {
                mProgress = value;
            }
        }

        //
        object mObject;
        public object Tag
        {
            get
            {
                return mObject;
            }

            set
            {
                mObject = value;
            }
        }

        //
        public AbsDownloader(Label progress)
        {
            this.mProgress = progress;
            NetworkChange.NetworkAvailabilityChanged += OnAvailabilityChangeHandler;
        }

        public void cancel()
        {
            if(mWebClient != null)
            {
                mWebClient.CancelAsync();
                mWebClient = null;
            }
        }

        //
        public void onComplete(object sender, AsyncCompletedEventArgs e)
        {
            DownloadArgument dArgument = new DownloadArgument(e,this);

            if (e.Error != null)
            {
                if (e.Cancelled)
                {
                    uodateStatus("Cancelled");
                    downloadStatus = "Cancelled";
                }
                else
                {
                    uodateStatus(e.Error.Message);
                    downloadStatus = "Error";
                }
                Console.WriteLine(e.Error.Message);
            }
            else
            {
                downloadStatus = "Completed";
                Console.WriteLine("Completed..");               
            }
            if (DownloadObserver != null)
            {
                DownloadObserver.onComplete(dArgument);
            }
            //DownloadObserver = null;
        }

        //
        void OnAvailabilityChangeHandler(object sender, NetworkAvailabilityEventArgs e)
        {
            if (DownloadObserver != null)
            {
                uodateStatus("Network: " + e.IsAvailable.ToString());
                DownloadObserver.onMessage(new DownloadArgument(e, this));
            }
        }

        //
        protected void uodateStatus(String message)
        {
            if (this.Progress != null)
            {

                if (this.Progress.InvokeRequired)
                {
                    this.Progress.BeginInvoke((MethodInvoker)delegate
                    {
                        this.Progress.Text = message;
                        return;
                    });
                }
                else
                {
                    this.Progress.Text = message;
                }
            }
        }
    }
}
