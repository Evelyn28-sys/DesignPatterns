namespace DesignPatterns.SRC
{
    public interface IPedidoState
    {
        void Avancar(PedidoContext context);
        void Cancelar(PedidoContext context);
        string Status { get; }
    }
    public class CriadoState : IPedidoState
    {
        public string Status => "Criado";
        public void Avancar(PedidoContext context)
        {
            context.State = new PagoState();
            Console.WriteLine("Pedido pago.");
        }
        public void Cancelar(PedidoContext context)
        {
            context.State = new CanceladoState();
            Console.WriteLine("Pedido cancelado.");
        }
    }
    public class PagoState : IPedidoState
    {
        public string Status => "Pago";
        public void Avancar(PedidoContext context)
        {
            context.State = new EnviadoState();
            Console.WriteLine("Pedido enviado.");
        }
        public void Cancelar(PedidoContext context)
        {
            context.State = new CanceladoState();
            Console.WriteLine("Pedido cancelado.");
        }
    }
    public class EnviadoState : IPedidoState
    {
        public string Status => "Enviado";
        public void Avancar(PedidoContext context)
        {
            Console.WriteLine("Pedido já foi enviado.");
        }
        public void Cancelar(PedidoContext context)
        {
            context.State = new CanceladoState();
            Console.WriteLine("Pedido cancelado.");
        }
    }
    public class CanceladoState : IPedidoState
    {
        public string Status => "Cancelado";
        public void Avancar(PedidoContext context)
        {
            Console.WriteLine("Pedido cancelado não pode avançar.");
        }
        public void Cancelar(PedidoContext context)
        {
            Console.WriteLine("Pedido já está cancelado.");
        }
    }
    public class PedidoContext
    {
        public IPedidoState State { get; set; }
        public PedidoContext() => State = new CriadoState();
        public void Avancar() => State.Avancar(this);
        public void Cancelar() => State.Cancelar(this);
        public string Status => State.Status;
    }

    public static class StateDemo
    {
        public static void Run()
        {
            var pedido = new PedidoContext();
            Console.WriteLine($"Status: {pedido.Status}");
            pedido.Avancar();
            Console.WriteLine($"Status: {pedido.Status}");
            pedido.Avancar();
            Console.WriteLine($"Status: {pedido.Status}");
            pedido.Cancelar();
            Console.WriteLine($"Status: {pedido.Status}");
        }
    }
}
