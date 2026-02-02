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

    public abstract class Product
    {
        public abstract string GetInfo();
    }
    public class Batom : Product
    {
        public override string GetInfo() => "Produto: Batom - Cor vibrante e longa duração";
    }
    public class Base : Product
    {
        public override string GetInfo() => "Produto: Base - Cobertura perfeita para sua pele";
    }
    public class Mascara : Product
    {
        public override string GetInfo() => "Produto: Máscara de cílios - Volume e definição";
    }
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct();
    }
    public class BatomFactory : ProductFactory
    {
        public override Product CreateProduct() => new Batom();
    }
    public class BaseFactory : ProductFactory
    {
        public override Product CreateProduct() => new Base();
    }
    public class MascaraFactory : ProductFactory
    {
        public override Product CreateProduct() => new Mascara();
    }

    public static class FactoryMethodDemo
    {
        public static void Run()
        {
            PaymentFactory paymentFactory = new PixPaymentFactory();
            var payment = paymentFactory.CreatePayment();
            Console.WriteLine(payment.Pay(100));

            ProductFactory productFactory = new BatomFactory();
            var product = productFactory.CreateProduct();
            Console.WriteLine(product.GetInfo());
        }
    }
}
