using HamsterCopy;

namespace FilesHamster
{
    public partial class HamsterForm : Form
    {
        private Hamster hamster;

        public HamsterForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var logger = new Logger(logBox);
            hamster = new Hamster(logger);

            if (string.IsNullOrEmpty(sourcePath.Text)
                || string.IsNullOrEmpty(destinationPath.Text))
            {
                logger.Write("Error: path not selected");
                return;
            }

            hamster.Start(sourcePath.Text, destinationPath.Text, cachePath.Text);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            hamster.Stop();
        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                sourcePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                destinationPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}