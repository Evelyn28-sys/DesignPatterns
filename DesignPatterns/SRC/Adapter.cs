namespace DesignPatterns.SRC
{
    public interface IExternalApi
    {
        string GetData();
    }
    public class LegacyApi
    {
        public string GetLegacyData() => "Dados do sistema legado";
    }
    public class LegacyApiAdapter : IExternalApi
    {
        private readonly LegacyApi _legacyApi;
        public LegacyApiAdapter(LegacyApi legacyApi) => _legacyApi = legacyApi;
        public string GetData() => _legacyApi.GetLegacyData();
    }

    public static class AdapterDemo
    {
        public static void Run()
        {
            IExternalApi api = new LegacyApiAdapter(new LegacyApi());
            Console.WriteLine(api.GetData());
        }
    }
}
