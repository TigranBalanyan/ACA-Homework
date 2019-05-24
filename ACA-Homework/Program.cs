using ACA_Homework.Assingment_10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace ACA_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;

            FileAsyncCopy copy = new FileAsyncCopy(@"C:\Users\tbala\source\repos\ACA-Homework\ACA-Homework\Assingment-10\TextFile1.txt", @"C:\Users\tbala\source\repos\ACA-Homework\ACA-Homework\Assingment-10\TextFile.txt");
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