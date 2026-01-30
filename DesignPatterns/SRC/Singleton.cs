namespace DesignPatterns.SRC
{
    public sealed class CacheService
    {
        private static readonly Lazy<CacheService> _instance = new(() => new CacheService());
        private readonly Dictionary<string, string> _cache = new();

        private CacheService() { }

        public static CacheService Instance => _instance.Value;

        public void Set(string key, string value) => _cache[key] = value;
        public string? Get(string key) => _cache.TryGetValue(key, out var value) ? value : null;
    }

    public static class SingletonDemo
    {
        public static void Run()
        {
            var cache = CacheService.Instance;
            cache.Set("user", "João");
            Console.WriteLine($"Cache user: {cache.Get("user")}");
        }
    }
}
