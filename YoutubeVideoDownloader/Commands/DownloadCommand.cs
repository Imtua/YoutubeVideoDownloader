namespace YoutubeVideoDownloader.Commands
{
    /// <summary>
    /// Класс команды скачивания видео
    /// </summary>
    internal class DownloadCommand : Command
    {
        // Конструктор
        public DownloadCommand(string url) : base(url) { } 

        public override void Run()
        {
            Console.WriteLine("Запуск скачивания");
        }

        public override void Cancel()
        {
            Console.WriteLine("Отмена скачивания");
        }
    }
}
