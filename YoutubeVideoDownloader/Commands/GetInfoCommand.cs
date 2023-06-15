namespace YoutubeVideoDownloader.Commands
{
    /// <summary>
    /// Класс команды вывода информции о видео
    /// </summary>
    internal class GetInfoCommand : ICommand
    {
        //
        Reciever reciever;
        // Ссылка на видео
        public string Url { get; set; }

        // Конструктор
        public GetInfoCommand(string url)
        {
            Url = url;
        }

        // Получение информации о видео
        public void Run()
        {
            Console.WriteLine("Получение информации о видео");
        }

        // Реализация отмены не предусмотрена
        public void Cancel() { }
    }
}
