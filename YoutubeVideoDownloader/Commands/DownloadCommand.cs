using VideoLibrary;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YoutubeVideoDownloader.Commands
{
    /// <summary>
    /// Класс команды скачивания видео
    /// </summary>
    internal class DownloadCommand : BaseCommand
    {
        private const string DOWNLOAD_PATH = @"C:\test\";

        // Объект для получения ссылки на скачивание.
        private YouTube _youtube;
            
        public DownloadCommand(string url) : base(url) 
        {
            _youtube = YouTube.Default;
        }

        /// <summary>
        /// Запуск команды скачивания.
        /// </summary>
        public override async void Run()
        {
            var video = _youtube.GetVideo(Url);
            File.WriteAllBytes(DOWNLOAD_PATH + video.FullName, video.GetBytes());
        }

        /// <summary>
        /// Реализация отмены скачивания не предусмотрена.
        /// </summary>
        public override void Cancel() { }
    }
}
