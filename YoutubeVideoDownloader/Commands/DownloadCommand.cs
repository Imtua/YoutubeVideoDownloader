namespace YoutubeVideoDownloader.Commands
{
    /// <summary>
    /// Класс команды скачивания видео
    /// </summary>
    internal class DownloadCommand : ICommand
    {
        // Ссылка на видео
        public string Url { get; set; }

        // Конструктор
        public DownloadCommand(string url)
        {
            Url = url;
        }

        // Запуск команды скачивания
        public void Run()
        {
            Console.WriteLine("Запуск скачивания");
        }

        // Отмена команды скачивания
        public void Cancel()
        {
            Console.WriteLine("Отмена скачивания");
        }
    }
}
