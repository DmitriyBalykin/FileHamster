namespace FilesHamster
{
    partial class HamsterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.sourceButton = new System.Windows.Forms.Button();
            this.destinationButton = new System.Windows.Forms.Button();
            this.cacheButton = new System.Windows.Forms.Button();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.cachePath = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(93, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(13, 62);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(75, 23);
            this.sourceButton.TabIndex = 3;
            this.sourceButton.Text = "Source";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(15, 102);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(75, 23);
            this.destinationButton.TabIndex = 4;
            this.destinationButton.Text = "Destination";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // cacheButton
            // 
            this.cacheButton.Enabled = false;
            this.cacheButton.Location = new System.Drawing.Point(15, 140);
            this.cacheButton.Name = "cacheButton";
            this.cacheButton.Size = new System.Drawing.Size(75, 23);
            this.cacheButton.TabIndex = 5;
            this.cacheButton.Text = "Cache";
            this.cacheButton.UseVisualStyleBackColor = true;
            // 
            // sourcePath
            // 
            this.sourcePath.Location = new System.Drawing.Point(94, 62);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(694, 23);
            this.sourcePath.TabIndex = 6;
            // 
            // destinationPath
            // 
            this.destinationPath.Location = new System.Drawing.Point(94, 102);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(694, 23);
            this.destinationPath.TabIndex = 7;
            // 
            // cachePath
            // 
            this.cachePath.Enabled = false;
            this.cachePath.Location = new System.Drawing.Point(93, 140);
            this.cachePath.Name = "cachePath";
            this.cachePath.Size = new System.Drawing.Size(694, 23);
            this.cachePath.TabIndex = 7;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(15, 178);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(772, 228);
            this.logBox.TabIndex = 8;
            this.logBox.Text = "";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // HamsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.cachePath);
            this.Controls.Add(this.destinationPath);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.cacheButton);
            this.Controls.Add(this.destinationButton);
            this.Controls.Add(this.sourceButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "HamsterForm";
            this.Text = "FilesHamster";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog;
        private Button startButton;
        private Button stopButton;
        private ProgressBar progressBar1;
        private Button sourceButton;
        private Button destinationButton;
        private Button cacheButton;
        private TextBox sourcePath;
        private TextBox destinationPath;
        private TextBox cachePath;
        private RichTextBox logBox;
        private FileSystemWatcher fileSystemWatcher1;
    }
}