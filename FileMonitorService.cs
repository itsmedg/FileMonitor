using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Configuration;

namespace FileMonitorService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            FSWatcherTest.Path = ConfigurationManager.AppSettings["WatchPath"];
            successPath = ConfigurationManager.AppSettings["successPath"];
            errorPath = ConfigurationManager.AppSettings["errorPath"];
            pattern = ConfigurationManager.AppSettings["pattern"];

            FSWatcherTest.IncludeSubdirectories = false;
            FSWatcherTest.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.Size;

        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
