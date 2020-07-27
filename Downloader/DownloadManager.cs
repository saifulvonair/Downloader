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
using System.Collections;
using System.Windows.Forms;

namespace Downloader
{

    class Composite : Object
    {
        protected ArrayList mList;

        public ArrayList List { get { return mList; } }

        public Composite()
        {
            mList = new ArrayList();
        }

        // Add item to the mList 
        public void Add(Object item)
        {
            if (!mList.Contains(item))
            {
                mList.Add(item);
            }
        }

        // Remove item from the mList
        public void Remove(Object item)
        {
            mList.Remove(item);
        }

        public Object GetLastItem()
        {
            if (mList.Count > 0)
                return mList[mList.Count - 1];
            return null;
        }

        public FileDownloader getbyID(string id)
        {
            foreach (FileDownloader fd in this.List)
            {
                if (fd.URL == id)
                {
                    return fd;
                }
            }

            return null;
        }

        public void RemoveAll()
        {            
            this.List.Clear();
        }
    }

    class DownloadManager: Composite, IDownloadObserver
    {
        IDownloadObserver mIDownloadObserver;
        
        //
        public DownloadManager()
        {

        }        

        public void cancel(String url)
        {
            FileDownloader fd = this.getbyID(url);
            if(fd != null)
            {
                fd.cancel();
                // We have to remove this from our list...
                this.Remove(fd);
                fd = null;
                //System.GC();
            }
        }


        public FileDownloader exeute(Label lblProgress, String url, IDownloadObserver IDownloadObserver)
        {
            mIDownloadObserver = IDownloadObserver;
            //
            FileDownloader fd = new FileDownloader(lblProgress);
            this.Add(fd);
            fd.Download(url, this);
            return fd;
        }

        public FileDownloader create(Label lblProgress, String url, IDownloadObserver IDownloadObserver, Button btn)
        {
            mIDownloadObserver = IDownloadObserver;

            FileDownloader fd  = this.getbyID(url);
            if(fd == null)
            {
                fd = new FileDownloader(lblProgress);
                this.Add(fd);
            }
            
            fd.Tag = btn;

            return fd;
        }

        void IDownloadObserver.onComplete(DownloadArgument e)
        {
            if(e.Downloader.Tag != null)
            {
                Button btn = (Button)e.Downloader.Tag;
                if (e.AsyncCompletedEventArgs.Cancelled)
                {
                    btn.Enabled = true;
                    btn.Text = "Download";
                }
                else if (e.AsyncCompletedEventArgs.Error != null)
                {
                    // Error in Completion...
                }
                else 
                {  
                    //Normal Complete..We can check Downloded Size and Remote Size to verify...
                    btn.Text = "Completed";
                    btn.Enabled = false;
                    e.Downloader.DownloadObserver = null;
                    mIDownloadObserver = null;
                }
            }

            if(mIDownloadObserver != null)
            {
                mIDownloadObserver.onComplete(e);
            }

            //

            //this.Remove(e.Downloader);
            //e.Downloader = null;
           
        }

        void IDownloadObserver.onContinue(DownloadArgument e)
        {
            if (mIDownloadObserver != null)
            {
                mIDownloadObserver.onContinue(e);
            }
        }

        void IDownloadObserver.onMessage(DownloadArgument e)
        {
            if (mIDownloadObserver != null)
            {
                mIDownloadObserver.onMessage(e);
            }
        }

        // We can pass all the ULRs here..in a list...
        public void executeAllOperation(Button btn, Label lbl, String url, IDownloadObserver observer)
        {
            FileDownloader fd = create(lbl, url, observer, btn);
            if (fd.DownloadStatus == "Continue")
            {
                return;
            }
            executeOperation(btn, lbl, url, observer);
        }


        public void executeOperation(Button btn, Label lbl, String url, IDownloadObserver observer)
        {
            mIDownloadObserver = observer;
            //
            if(!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                if(mIDownloadObserver != null)
                {
                    mIDownloadObserver.onMessage(new DownloadArgument("NetworkFailed"));
                }
                return;
            }

            if (btn.Text == "Cancel")
            {
                btn.Text = "Download";
                cancel(url);
                return;
            }

            FileDownloader fd = create(lbl, url, observer, btn);

            if (fd.DownloadStatus == "Continue")
            {
                return;
            }

            if (fd.DownloadStatus != "Completed")
            {
                fd.Download(url, this);
                btn.Text = "Cancel";
                btn.Enabled = true;
            }
        }
    }
}
