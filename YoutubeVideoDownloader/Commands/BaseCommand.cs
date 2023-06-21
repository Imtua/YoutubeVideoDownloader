namespace YoutubeVideoDownloader.Commands
{
    /// <summary>
    /// Базовый класс команд приложения.
    /// </summary>
    internal abstract class BaseCommand
    {
        /// <summary>
        /// Ссылка на видео.
        /// </summary>
        public string Url { get; }

        public abstract void Run();
        public abstract void Cancel();

        /// <summary>
        /// Конструктор с проверкой ссылки.
        /// </summary>
        /// <param name="url"> Ссылка на видео. </param>
        public BaseCommand(string url)
        {
            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("Неправильный ввод!",nameof(url));
            }
            Url = url;
        }
    }
}
