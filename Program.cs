using System;
using StackExchange.Redis;

class Program
{
    static void Main(string[] args)
    {
        // Connect to the Redis server
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");

        // Get a reference to the Redis database
        IDatabase db = redis.GetDatabase();

        // Set a key-value pair in Redis
        db.StringSet("mykey", "Hello Redis!");

        // Retrieve the value from Redis
        string value = db.StringGet("mykey");
        Console.WriteLine(value);  // Output: Hello Redis!
    }
}
