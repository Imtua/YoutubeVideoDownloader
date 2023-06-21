using YoutubeVideoDownloader;
using YoutubeVideoDownloader.Commands;

Console.Write("Введите ссылку на Youtube-видео: ");
var link = Console.ReadLine();

var comSender = new CommandSender(new GetInfoCommand(link));
comSender.Start();

Console.WriteLine("Начало загрузки...");
var downloadSender = new CommandSender(new DownloadCommand(link));
downloadSender.Start();
Console.WriteLine("Загрузка завершена");
