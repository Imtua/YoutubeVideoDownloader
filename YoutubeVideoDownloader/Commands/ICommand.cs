namespace YoutubeVideoDownloader.Commands
{
    internal abstract class Command
    {
        public string Url { get; set; }
        public Command(string url)
        {
            Url = url;
        }
        public abstract void Run();
        public abstract void Cancel();
    }
}
