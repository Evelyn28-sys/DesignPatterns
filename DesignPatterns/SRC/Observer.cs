namespace DesignPatterns.SRC
{
    public interface IObserver
    {
        void Update(string eventData);
    }
    public class EmailObserver : IObserver
    {
        public void Update(string eventData) => Console.WriteLine($"[Email] {eventData}");
    }
    public class LogObserver : IObserver
    {
        public void Update(string eventData) => Console.WriteLine($"[Log] {eventData}");
    }
    public class PedidoSubject
    {
        private readonly List<IObserver> _observers = new();
        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Notify(string eventData)
        {
            foreach (var obs in _observers)
                obs.Update(eventData);
        }
        public void CriarPedido()
        {
            Console.WriteLine("Pedido criado.");
            Notify("Pedido criado com sucesso!");
        }
    }

    public static class ObserverDemo
    {
        public static void Run()
        {
            var subject = new PedidoSubject();
            subject.Attach(new EmailObserver());
            subject.Attach(new LogObserver());
            subject.CriarPedido();
        }
    }
}
