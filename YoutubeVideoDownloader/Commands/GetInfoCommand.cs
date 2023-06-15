namespace YoutubeVideoDownloader.Commands
{
    /// <summary>
    /// Класс команды вывода информции о видео
    /// </summary>
    internal class GetInfoCommand : Command
    {
        // Конструктор
        public GetInfoCommand(string url) : base(url) { } 

        public override void Run()
        {
            Console.WriteLine("Вывод информации о видео");
        }

        public override void Cancel()
        {
            // Реализация отмены не предусмотрена
        }
    }
}
