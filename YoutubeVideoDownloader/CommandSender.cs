using YoutubeExplode;
using YoutubeVideoDownloader.Commands;

namespace YoutubeVideoDownloader
{
    /// <summary>
    /// Класс sender для команд обработки видео
    /// </summary>
    internal class CommandSender
    {
        private BaseCommand _command;

        // Конструктор
        public CommandSender(BaseCommand command)
        {
            _command= command;
        }

        // Выполнить команду
        public void Start()
        {
            
            _command.Run();
        }

        // Прекратить выполнение команды, если оно предусмотрено
        public void Stop()
        {
            _command.Cancel();
        }
    }
}
