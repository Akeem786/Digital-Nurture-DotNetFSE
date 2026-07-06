namespace KafkaChatApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Kafka Chat Application");
            Console.WriteLine("1. Start as Producer (Send messages)");
            Console.WriteLine("2. Start as Consumer (Receive messages)");
            Console.Write("Choose option: ");

            string? option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Type messages to send (type 'exit' to quit):");

                while (true)
                {
                    string? message = Console.ReadLine();

                    if (message?.ToLower() == "exit")
                        break;

                    await KafkaProducer.SendMessage(message!);
                }
            }
            else if (option == "2")
            {
                KafkaConsumer.ConsumeMessages();
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}