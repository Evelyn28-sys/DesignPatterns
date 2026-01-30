namespace DesignPatterns.SRC
{
    public interface IService
    {
        void Execute();
    }
    public class OrderService : IService
    {
        public void Execute() => Console.WriteLine("Pedido processado.");
    }
    public class LoggingDecorator : IService
    {
        private readonly IService _inner;
        public LoggingDecorator(IService inner) => _inner = inner;
        public void Execute()
        {
            Console.WriteLine("Log: Iniciando execução...");
            _inner.Execute();
            Console.WriteLine("Log: Execução finalizada.");
        }
    }

    public static class DecoratorDemo
    {
        public static void Run()
        {
            IService service = new LoggingDecorator(new OrderService());
            service.Execute();
        }
    }
}
