﻿using System;
using System.Drawing;
using System.Windows.Forms;

// Need these namespaces!
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace DataParallelismWithForEach
{
    public partial class MainForm : Form
    {
        // New Form level variable.
        //private CancellationTokenSource cancelToken = new CancellationTokenSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProcessImages_Click(object sender, EventArgs e)
        {
            ProcessFiles();
            // Start a new "task" to process the files. 
            //Task.Factory.StartNew...
        }

        private void ProcessFiles()
        {
            // Use ParallelOptions instance to store the CancellationToken
            //ParallelOptions parOpts = new ParallelOptions();
            //parOpts.CancellationToken = cancelToken.Token;
            //parOpts.MaxDegreeOfParallelism = System.Environment.ProcessorCount;

            // Load up all *.jpg files, and make a new folder for the modified data.
            string[] files = Directory.GetFiles(@"C:\Work\Photo\TempPhoto", "*.jpg",
                SearchOption.AllDirectories);
            string newDir = @"C:\Work\Photo\TempPhoto2";
            Directory.CreateDirectory(newDir);

            try
            {
                //  Process the image data in a parallel manner! 
                //Parallel.ForEach(files, parOpts, currentFile =>

                foreach (var currentFile in files)
                {
                    string filename = Path.GetFileName(currentFile);
                    using (Bitmap bitmap = new Bitmap(currentFile))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(newDir, filename));

                        //this.Invoke((Action)delegate
                        //{
                        //    this.Text = string.Format("Processing {0} on thread {1}", filename, Thread.CurrentThread.ManagedThreadId);
                        //});
                    }
                }
            }
            catch (OperationCanceledException ex)
            {
                this.Invoke((Action)delegate
                {
                    this.Text = ex.Message;
                });                
            }
        }

        private void btnCancelTask_Click(object sender, EventArgs e)
        {
            // This will be used to tell all the worker threads to stop!
            //cancelToken.Cancel();
        }
    }
}
