using ACA_Homework.Assingment_10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;

namespace ACA_Homework
{
    class Program
    {

        static void Main(string[] args)
        {

            bool finished = false;

            string currentDirectory = Directory.GetCurrentDirectory();
            string targetFileName = "myFile.txt";
            string sourceFileName = "targetFile.txt.txt";


            string fileTarget = Path.Combine(currentDirectory, targetFileName);
            string fileSource = Path.Combine(currentDirectory, sourceFileName);

            FileAsyncCopy copy = new FileAsyncCopy(fileTarget, fileSource);
            copy.Completed += CopyCompleted;
            copy.ProgressChanged += CopyProgressChanged;

            copy.StartAsync();
            while (finished == false){}

            void CopyCompleted(object sender, RunWorkerCompletedEventArgs e)
            {
                finished = true;
                BackgroundWorker worker = sender as BackgroundWorker;
                worker.Dispose();
            }

            void CopyProgressChanged(object sender, ProgressChangedEventArgs e)
            {
                Console.WriteLine(e.ProgressPercentage);
            }
        }
    }
}