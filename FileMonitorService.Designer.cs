using System.Text.RegularExpressions;
namespace FileMonitorService
{
    partial class Service1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FSWatcherTest = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.FSWatcherTest)).BeginInit();
            // 
            // FSWatcherTest
            // 
            this.FSWatcherTest.EnableRaisingEvents = true;
            this.FSWatcherTest.IncludeSubdirectories = true;
            this.FSWatcherTest.NotifyFilter = ((System.IO.NotifyFilters)((((((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.Attributes) 
            | System.IO.NotifyFilters.Size) 
            | System.IO.NotifyFilters.LastWrite) 
            | System.IO.NotifyFilters.LastAccess) 
            | System.IO.NotifyFilters.CreationTime) 
            | System.IO.NotifyFilters.Security)));
            this.FSWatcherTest.Changed += new System.IO.FileSystemEventHandler(this.FSWatcherTest_Created);
            this.FSWatcherTest.Created += new System.IO.FileSystemEventHandler(this.FSWatcherTest_Created);
            // 
            // Service1
            // 
            this.ServiceName = "FIleMonitorService";
            ((System.ComponentModel.ISupportInitialize)(this.FSWatcherTest)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher FSWatcherTest;
        private string pattern;
        private string successPath;
        private string errorPath;
        /* DEFINE WATCHER EVENTS... */

        /// <summary>
        /// Event occurs when the contents of a File or Directory is changed
        /// </summary>
        private void FSWatcherTest_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            //code here for newly changed file or directory
        }

        /// <summary>
        /// Event occurs when the a File or Directory is created
        /// </summary>
        private void FSWatcherTest_Created(object sender, System.IO.FileSystemEventArgs e)
        {

            try
            {
                Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                if (rgx.IsMatch(e.Name))
                    System.IO.File.Move(e.FullPath, string.Format("{0}{1}", successPath, e.Name));
                else
                    System.IO.File.Move(e.FullPath, string.Format("{0}{1}", errorPath, e.Name));
            }
            catch (System.Exception ex)
            {
            }
        }

        /// <summary>
        /// Event occurs when the a File or Directory is deleted
        /// </summary>
        private void FSWatcherTest_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            //code here for newly deleted file or directory            
        }

        /// <summary>
        /// Event occurs when the a File or Directory is renamed
        /// </summary>
        private void FSWatcherTest_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            //code here for newly renamed file or directory
        }
    }
}
