namespace DesignPatterns.SRC
{
    public interface IDiscountStrategy
    {
        decimal Apply(decimal price);
    }
    public class VipDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price * 0.8m;
    }
    public class RegularDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price * 0.9m;
    }
    public class NoDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price;
    }
    public class CheckoutService
    {
        private readonly IDiscountStrategy _strategy;
        public CheckoutService(IDiscountStrategy strategy) => _strategy = strategy;
        public decimal Calculate(decimal price) => _strategy.Apply(price);
    }

    public static class StrategyDemo
    {
        public static void Run()
        {
            IDiscountStrategy strategy = new VipDiscount();
            var checkout = new CheckoutService(strategy);
            Console.WriteLine($"Preço final: {checkout.Calculate(2000):C}");
        }
    }
}
