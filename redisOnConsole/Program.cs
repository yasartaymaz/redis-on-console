using StackExchange.Redis;
using System;

namespace redisOnConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConnectionMultiplexer conn = ConnectionMultiplexer.Connect("localhost");
            //getting database instances of the redis  
            IDatabase database = conn.GetDatabase();
            //set value in redis server  
            database.StringSet("redisKey", "muhittin");
            //get value from redis server  
            var value = database.StringGet("redisKey");
            Console.WriteLine("Value cached in redis server is: " + value);
            Console.ReadLine();
        }
    }
}
