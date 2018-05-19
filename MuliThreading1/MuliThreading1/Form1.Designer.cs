namespace MuliThreading1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bStartSimpleWorker = new System.Windows.Forms.Button();
            this.bShowMsg = new System.Windows.Forms.Button();
            this.bStartParallel = new System.Windows.Forms.Button();
            this.txtStartPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bStartParallelParam = new System.Windows.Forms.Button();
            this.bWaitingBackground = new System.Windows.Forms.Button();
            this.bParallel = new System.Windows.Forms.Button();
            this.bAsyncDelegate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bStartSimpleWorker
            // 
            this.bStartSimpleWorker.Location = new System.Drawing.Point(78, 35);
            this.bStartSimpleWorker.Name = "bStartSimpleWorker";
            this.bStartSimpleWorker.Size = new System.Drawing.Size(138, 23);
            this.bStartSimpleWorker.TabIndex = 0;
            this.bStartSimpleWorker.Text = "StartSimpleWorker";
            this.bStartSimpleWorker.UseVisualStyleBackColor = true;
            this.bStartSimpleWorker.Click += new System.EventHandler(this.bStartSimpleWorker_Click);
            // 
            // bShowMsg
            // 
            this.bShowMsg.Location = new System.Drawing.Point(300, 34);
            this.bShowMsg.Name = "bShowMsg";
            this.bShowMsg.Size = new System.Drawing.Size(157, 23);
            this.bShowMsg.TabIndex = 1;
            this.bShowMsg.Text = "Show message";
            this.bShowMsg.UseVisualStyleBackColor = true;
            this.bShowMsg.Click += new System.EventHandler(this.bShowMsg_Click);
            // 
            // bStartParallel
            // 
            this.bStartParallel.Location = new System.Drawing.Point(78, 82);
            this.bStartParallel.Name = "bStartParallel";
            this.bStartParallel.Size = new System.Drawing.Size(138, 23);
            this.bStartParallel.TabIndex = 2;
            this.bStartParallel.Text = "Start Worker Parallel";
            this.bStartParallel.UseVisualStyleBackColor = true;
            this.bStartParallel.Click += new System.EventHandler(this.bStartParallel_Click);
            // 
            // txtStartPoint
            // 
            this.txtStartPoint.Location = new System.Drawing.Point(180, 125);
            this.txtStartPoint.Name = "txtStartPoint";
            this.txtStartPoint.Size = new System.Drawing.Size(36, 20);
            this.txtStartPoint.TabIndex = 3;
            this.txtStartPoint.Text = "0";
            this.txtStartPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the start point";
            // 
            // bStartParallelParam
            // 
            this.bStartParallelParam.Location = new System.Drawing.Point(78, 166);
            this.bStartParallelParam.Name = "bStartParallelParam";
            this.bStartParallelParam.Size = new System.Drawing.Size(138, 23);
            this.bStartParallelParam.TabIndex = 5;
            this.bStartParallelParam.Text = "Start from Start point";
            this.bStartParallelParam.UseVisualStyleBackColor = true;
            this.bStartParallelParam.Click += new System.EventHandler(this.bStartParallelParam_Click);
            // 
            // bWaitingBackground
            // 
            this.bWaitingBackground.Location = new System.Drawing.Point(241, 82);
            this.bWaitingBackground.Name = "bWaitingBackground";
            this.bWaitingBackground.Size = new System.Drawing.Size(138, 23);
            this.bWaitingBackground.TabIndex = 6;
            this.bWaitingBackground.Text = "Wait for finish";
            this.bWaitingBackground.UseVisualStyleBackColor = true;
            this.bWaitingBackground.Click += new System.EventHandler(this.bWaitingBackground_Click);
            // 
            // bParallel
            // 
            this.bParallel.Location = new System.Drawing.Point(78, 231);
            this.bParallel.Name = "bParallel";
            this.bParallel.Size = new System.Drawing.Size(138, 23);
            this.bParallel.TabIndex = 7;
            this.bParallel.Text = "Parallel working";
            this.bParallel.UseVisualStyleBackColor = true;
            this.bParallel.Click += new System.EventHandler(this.bParallel_Click);
            // 
            // bAsyncDelegate
            // 
            this.bAsyncDelegate.Location = new System.Drawing.Point(280, 231);
            this.bAsyncDelegate.Name = "bAsyncDelegate";
            this.bAsyncDelegate.Size = new System.Drawing.Size(138, 23);
            this.bAsyncDelegate.TabIndex = 8;
            this.bAsyncDelegate.Text = "Async delegate";
            this.bAsyncDelegate.UseVisualStyleBackColor = true;
            this.bAsyncDelegate.Click += new System.EventHandler(this.bAsyncDelegate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(280, 261);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 391);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.bAsyncDelegate);
            this.Controls.Add(this.bParallel);
            this.Controls.Add(this.bWaitingBackground);
            this.Controls.Add(this.bStartParallelParam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartPoint);
            this.Controls.Add(this.bStartParallel);
            this.Controls.Add(this.bShowMsg);
            this.Controls.Add(this.bStartSimpleWorker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStartSimpleWorker;
        private System.Windows.Forms.Button bShowMsg;
        private System.Windows.Forms.Button bStartParallel;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStartParallelParam;
        private System.Windows.Forms.Button bWaitingBackground;
        private System.Windows.Forms.Button bParallel;
        private System.Windows.Forms.Button bAsyncDelegate;
        private System.Windows.Forms.Label lblResult;
    }
}

