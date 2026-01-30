namespace DesignPatterns.SRC
{
    public abstract class Payment
    {
        public abstract string Pay(decimal amount);
    }
    public class PixPayment : Payment
    {
        public override string Pay(decimal amount) => $"Pago {amount:C} via Pix";
    }
    public class CardPayment : Payment
    {
        public override string Pay(decimal amount) => $"Pago {amount:C} via Cartão";
    }
    public class BoletoPayment : Payment
    {
        public override string Pay(decimal amount) => $"Pago {amount:C} via Boleto";
    }
    public abstract class PaymentFactory
    {
        public abstract Payment CreatePayment();
    }
    public class PixPaymentFactory : PaymentFactory
    {
        public override Payment CreatePayment() => new PixPayment();
    }
    public class CardPaymentFactory : PaymentFactory
    {
        public override Payment CreatePayment() => new CardPayment();
    }
    public class BoletoPaymentFactory : PaymentFactory
    {
        public override Payment CreatePayment() => new BoletoPayment();
    }

    public static class FactoryMethodDemo
    {
        public static void Run()
        {
            PaymentFactory factory = new PixPaymentFactory();
            var payment = factory.CreatePayment();
            Console.WriteLine(payment.Pay(100));
        }
    }
}
