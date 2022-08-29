using HamsterCopy;

namespace FilesHamster;

public class Hamster
{
    private CancellationTokenSource? cancellationTokenSource;
    private ISet<string> processingFiles = new HashSet<string>();
    private TaskFactory taskFactory;
    private Logger logger;
    private FileSystemWatcher fileWatcher;
    private bool isStarted;

    public Hamster(Logger logger)
    {
        this.logger = logger;
    }

    public void Start(string sourceFolder, string targetFolder, string cacheFolder)
    {
        if (isStarted)
        {
            return;
        }

        isStarted = true;

        taskFactory = new TaskFactory();

        cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        fileWatcher = new FileSystemWatcher(sourceFolder);
        fileWatcher.Created += FileCreated;
        Task.Run(() => FileWaitingLoop(sourceFolder, targetFolder, cacheFolder, cancellationToken), cancellationToken);
    }

    private void FileCreated(object sender, FileSystemEventArgs e)
    {
        
    }

    public void Stop()
    {
        if (cancellationTokenSource != null)
        {
            cancellationTokenSource.Cancel();
            cancellationTokenSource.Dispose();
            cancellationTokenSource = null;

            fileWatcher.Created -= FileCreated;
            fileWatcher.Dispose();
        }

        isStarted = false;
    }

    private async Task FileWaitingLoop(
        string sourceFolder,
        string targetFolder,
        string cacheFolder,
        CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            await CheckFiles(sourceFolder, targetFolder);
            await Task.Delay(1000, cancellationToken);
        }
    }

    private async Task CheckFiles(string sourceFolder, string targetFolder)
    {
        string fileToMove = null;
        string destFilePath = null;
        try
        {
            var currentFiles = Directory.GetFiles(sourceFolder, "*", new EnumerationOptions { RecurseSubdirectories = true });

            if (!currentFiles.Any())
            {
                return;
            }

            fileToMove = currentFiles.First();
            var fileName = Path.GetFileName(fileToMove);
            destFilePath = Path.Combine(targetFolder, fileName);

            File.Move(fileToMove, destFilePath);
            logger.Write($"File {fileName} moved");
        }
        catch (Exception ex)
        {
            if (ex.Message == "The process cannot access the file because it is being used by another process")
            {
                return;
            }

            logger.Write($"Error: {ex.Message} for source {fileToMove}, destination {destFilePath}");
        }
    }
}