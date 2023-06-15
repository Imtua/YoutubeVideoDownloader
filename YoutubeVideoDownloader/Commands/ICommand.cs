namespace YoutubeVideoDownloader.Commands
{
    internal interface ICommand
    { 
        public void Run();
        public void Cancel();
    }
}
