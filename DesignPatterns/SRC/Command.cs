namespace DesignPatterns.SRC
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
    public class AddProductCommand : ICommand
    {
        private readonly List<string> _cart;
        private readonly string _product;
        public AddProductCommand(List<string> cart, string product)
        {
            _cart = cart;
            _product = product;
        }
        public void Execute()
        {
            _cart.Add(_product);
            Console.WriteLine($"{_product} adicionado ao carrinho.");
        }
        public void Undo()
        {
            _cart.Remove(_product);
            Console.WriteLine($"{_product} removido do carrinho.");
        }
    }
    public class CommandInvoker
    {
        private readonly Stack<ICommand> _history = new();
        public void Execute(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }
        public void Undo()
        {
            if (_history.Count > 0)
                _history.Pop().Undo();
        }
    }

    public static class CommandDemo
    {
        public static void Run()
        {
            var cart = new List<string>();
            var addCmd = new AddProductCommand(cart, "Mouse");
            var invoker = new CommandInvoker();
            invoker.Execute(addCmd);
            invoker.Undo();
        }
    }
}
