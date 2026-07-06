using Confluent.Kafka;

namespace KafkaChatApp
{
    public class KafkaProducer
    {
        private const string BootstrapServers = "localhost:9092";
        private const string Topic = "chat-topic";

        public static async Task SendMessage(string message)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = BootstrapServers
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            var result = await producer.ProduceAsync(
                Topic,
                new Message<Null, string> { Value = message });

            Console.WriteLine($"Message sent: {result.Value} to partition {result.TopicPartitionOffset}");
        }
    }
}