namespace ThreadPoolDemo
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
            this.bStartNewWorker = new System.Windows.Forms.Button();
            this.bShowMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bStartNewWorker
            // 
            this.bStartNewWorker.Location = new System.Drawing.Point(27, 29);
            this.bStartNewWorker.Name = "bStartNewWorker";
            this.bStartNewWorker.Size = new System.Drawing.Size(203, 23);
            this.bStartNewWorker.TabIndex = 0;
            this.bStartNewWorker.Text = "Start new worker";
            this.bStartNewWorker.UseVisualStyleBackColor = true;
            this.bStartNewWorker.Click += new System.EventHandler(this.bStartNewWorker_Click);
            // 
            // bShowMsg
            // 
            this.bShowMsg.Location = new System.Drawing.Point(277, 29);
            this.bShowMsg.Name = "bShowMsg";
            this.bShowMsg.Size = new System.Drawing.Size(203, 23);
            this.bShowMsg.TabIndex = 1;
            this.bShowMsg.Text = "Show some message";
            this.bShowMsg.UseVisualStyleBackColor = true;
            this.bShowMsg.Click += new System.EventHandler(this.bShowMsg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 261);
            this.Controls.Add(this.bShowMsg);
            this.Controls.Add(this.bStartNewWorker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStartNewWorker;
        private System.Windows.Forms.Button bShowMsg;
    }
}

