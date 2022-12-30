using Confluent.Kafka;
using System;
using Microsoft.Extensions.Configuration;

class Producer
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Please provide the configuration file path as a command line argument");
        }

        IConfiguration configuration = new ConfigurationBuilder()
            .AddIniFile(args[0])
            .Build();

        const string topic = "purchase";

        string[] users = { "eabara", "jsmith", "sgarcia", "jbernard", "htanaka", "awalther"};
        string[] items = { "book", "alarm clock", "t-shirts", "gift card", "batteries"};

        using (var producer = new ProducerBuilding<string, string>(
            configuration.AsEnumerable()).Build())
        {
            var numProduced = 0;
            Random rnd = new Random();
            const int numMessages = 10; 

            //++i will increment the value of i, and then return the incremented value. i = 1; j = ++i; (i is 2, j is 2)
            for (int i = 0; i < numMessages; ++i)
            {
                
            }
        }



}