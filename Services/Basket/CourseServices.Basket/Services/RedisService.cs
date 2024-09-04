using StackExchange.Redis;

namespace CourseServices.Basket.Services
{
    public class RedisService
    {
        private readonly string _host;
        private readonly int _port;
        private ConnectionMultiplexer _ConnectionMultiplexer;

        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Connect() => _ConnectionMultiplexer = ConnectionMultiplexer.Connect($"localhost:6379");

        public IDatabase GetDb(int db=1) => _ConnectionMultiplexer.GetDatabase(db);
    }
}
