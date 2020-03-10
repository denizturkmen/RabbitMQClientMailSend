using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Coree.Abstract;
using RabbitMQ.Coree.Concrete;
using RabbitMQ.Coree.Data;
using RabbitMQ.Coree.Entities;

namespace RabbitMQ.Consumer
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("RabbitMQ.ConsumerConsole Program.cs Acıldı.");

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("project.json");

            Console.WriteLine("project.json okundu.");
            var configuration = builder.Build();


            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConfiguration>(configuration)
                .AddSingleton<IRabbitMQConfiguration, RabbitMQConfiguration>()
                .AddSingleton<IRabbitMQService, RabbitMQService>()
                .AddSingleton<IObjectConvertFormat, ObjectConvertFormat>()
                .AddSingleton<ISmtpConfiguration, SmtpConfiguration>()
                .AddSingleton<IMailSender, MailSender>()
                .AddSingleton<IDataModel<User>, UsersDataModel>()
                .AddSingleton<IConsumerService, ConsumerManager>()
                .BuildServiceProvider();

            var consumerService = serviceProvider.GetService<IConsumerService>();
            Console.WriteLine("consumerService alındı.");
            Console.WriteLine($"consumerService.Start() başladı: {DateTime.Now.ToShortTimeString()}");
            await consumerService.Start();
            Console.WriteLine($"consumerService.Start() bitti:  {DateTime.Now.ToShortTimeString()}");
        }
    }
}
