using ACA_Homework.Assingment_10;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ACA_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            FileAsyncCopy copy = new FileAsyncCopy(@"C:\Users\tbala\source\repos\ACA-Homework\ACA-Homework\Assingment-10\TextFile1.txt", @"C:\Users\tbala\source\repos\ACA-Homework\ACA-Homework\Assingment-10\TextFile.txt");
            copy.Completed += CopyCompleted;
            copy.ProgressChanged += CopyProgressChanged;
            copy.StartAsync();
        }

        public static  void Start()
        {
            FileAsyncCopy copy = new FileAsyncCopy(@"C:\Users\tbala\source\repos\ACA-Homework\ACA-Homework\Assingment-10\TextFile1.txt", @"C:\Users\tbala\source\repos\ACA-Homework\ACA-Homework\Assingment-10\TextFile.txt");
            copy.Completed += CopyCompleted;
            copy.ProgressChanged += CopyProgressChanged;
            copy.StartAsync();
        }

        private static void CopyProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("You");
            Console.WriteLine(e.ProgressPercentage);
        }
        private static void CopyCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Hey");
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.Dispose();
        }
    }
}
