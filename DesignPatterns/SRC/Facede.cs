namespace DesignPatterns.SRC
{
    public class Estoque
    {
        public void Reservar(string produto) => Console.WriteLine($"Estoque reservado para {produto}");
    }
    public class Pagamento
    {
        public void Processar(decimal valor) => Console.WriteLine($"Pagamento de {valor:C} processado");
    }
    public class PedidoFacade
    {
        private readonly Estoque _estoque = new();
        private readonly Pagamento _pagamento = new();
        public void RealizarPedido(string produto, decimal valor)
        {
            _estoque.Reservar(produto);
            _pagamento.Processar(valor);
            Console.WriteLine("Pedido realizado com sucesso!");
        }
    }

    public static class FacadeDemo
    {
        public static void Run()
        {
            var pedidoFacade = new PedidoFacade();
            pedidoFacade.RealizarPedido("Notebook", 3500);
        }
    }
}
