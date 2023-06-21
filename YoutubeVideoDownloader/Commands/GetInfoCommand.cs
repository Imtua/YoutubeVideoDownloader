using YoutubeExplode;
using YoutubeExplode.Videos;

namespace YoutubeVideoDownloader.Commands
{
    /// <summary>
    /// Класс команды вывода информции о видео
    /// </summary>
    internal class GetInfoCommand : BaseCommand
    {
        // Объект для получения ссылки на скачивание.
        private YoutubeClient _youtube;

        public GetInfoCommand(string url) : base(url)
        {
            _youtube = new YoutubeClient();
        }

        /// <summary>
        /// Получение информации о видео.
        /// </summary>
        public override void Run()
        {
            if (_youtube.Videos.GetAsync(Url).GetAwaiter().GetResult() is Video video)
            {
                Console.WriteLine($"Название видео: {video.Title}");
                Console.WriteLine($"Автор: {video.Author}");
                Console.WriteLine($"Описание:\n{video.Description}");
            }
            else
            {
                Console.WriteLine("Не удалось вывести информацию");
            }
        }

        /// <summary>
        /// Реализация отмены не предусмотрена.
        /// </summary>
        public override void Cancel() { }
    }
}
