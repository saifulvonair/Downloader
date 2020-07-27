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

namespace Downloader
{
    public interface IDownloader
    {
        // To show the Progress of Each.. you can add as many as you like..
        System.Windows.Forms.Label Progress { get; set; }
        //
        IDownloadObserver DownloadObserver { get; set; }
        //
        object Tag { get; set; }

        //
        string DownloadStatus { get; }

        //void execute();
        //
        void cancel();
    }

    public interface IDownloadObserver
    {
        void onContinue(DownloadArgument e);
        void onComplete(DownloadArgument e);
        void onMessage(DownloadArgument e); 
    }

    public class DownloadArgument
    {
        public DownloadProgressChangedEventArgs DownloadProgressChangedEventArgs;
        public AsyncCompletedEventArgs AsyncCompletedEventArgs;
        public NetworkAvailabilityEventArgs NetworkAvailabilityEventArgs;

        public String remainingTime;
        public String RemainingTime { get { return remainingTime; } set { remainingTime = value; } }

        public IDownloader Downloader;

        public String message;
        public String Message { get { return message; } set { message = value; } }

        public DownloadArgument(string msg)
        {
            message = msg;
        }

        public DownloadArgument(DownloadProgressChangedEventArgs e, IDownloader d)
        {
            DownloadProgressChangedEventArgs = e;
            Downloader = d;
        }

        public DownloadArgument(AsyncCompletedEventArgs e, IDownloader d)
        {
            AsyncCompletedEventArgs = e;
            Downloader = d;
        }

        public DownloadArgument(NetworkAvailabilityEventArgs e, IDownloader d)
        {
            NetworkAvailabilityEventArgs = e;
            Downloader = d;
        }
    }
}
