using Confluent.Kafka;

namespace KafkaChatApp
{
    public class KafkaConsumer
    {
        private const string BootstrapServers = "localhost:9092";
        private const string Topic = "chat-topic";
        private const string GroupId = "chat-group";

        public static void ConsumeMessages()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = BootstrapServers,
                GroupId = GroupId,
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe(Topic);

            Console.WriteLine("Listening for messages...");

            while (true)
            {
                var result = consumer.Consume();
                Console.WriteLine($"Message received: {result.Message.Value}");
            }
        }
    }
}