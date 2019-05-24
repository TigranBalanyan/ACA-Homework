using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_10
{
    /// <summary>
    /// Copies files Asynchronously
    /// </summary>
    public class FileAsyncCopy
    {
        private string Source { get; set; }
        private string Target { get; set; }
        BackgroundWorker Worker;
        public FileAsyncCopy(string source, string target)
        {
            if (!File.Exists(source))
                throw new FileNotFoundException(string.Format(@"Source file was not found. FileName: {0}", source));

            Source = source;
            Target = target;
            Worker = new BackgroundWorker();
            Worker.WorkerSupportsCancellation = false;
            Worker.WorkerReportsProgress = true;
            Worker.DoWork += DoWork;
        }

        public void DoWork(object sender, DoWorkEventArgs e)
        {
            int bufferSize = 1024 * 512;
            using (FileStream inStream = new FileStream(Source, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (FileStream fileStream = new FileStream(Target, FileMode.OpenOrCreate, FileAccess.Write))
            {
                int bytesRead = -1;
                var totalReads = 0;
                var totalBytes = inStream.Length;
                byte[] bytes = new byte[bufferSize];
                int prevPercent = 0;

                while ((bytesRead = inStream.Read(bytes, 0, bufferSize)) > 0)
                {
                    fileStream.Write(bytes, 0, bytesRead);
                    totalReads += bytesRead;
                    int percent = Convert.ToInt32((totalReads / totalBytes) * 100);
                    if (percent != prevPercent)
                    {
                        Worker.ReportProgress(percent);
                        prevPercent = percent;
                    }
                }
            }
        }

        public event ProgressChangedEventHandler ProgressChanged
        {
            add { Worker.ProgressChanged += value; }
            remove { Worker.ProgressChanged -= value; }
        }

        public event RunWorkerCompletedEventHandler Completed
        {
            add { Worker.RunWorkerCompleted += value; }
            remove { Worker.RunWorkerCompleted -= value; }
        }
        public void StartAsync()
        {
            Worker.RunWorkerAsync();
        }
    }
}
