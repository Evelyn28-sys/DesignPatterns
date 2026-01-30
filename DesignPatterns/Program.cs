using System;
using DesignPatterns.SRC;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha um Design Pattern para demonstrar:");
            Console.WriteLine("1. Singleton (CacheService)");
            Console.WriteLine("2. Factory Method (Payment)");
            Console.WriteLine("3. Abstract Factory (Notification)");
            Console.WriteLine("4. Adapter (API externa)");
            Console.WriteLine("5. Decorator (Logging)");
            Console.WriteLine("6. Facade (Pedido)");
            Console.WriteLine("7. Strategy (Desconto)");
            Console.WriteLine("8. Observer (Eventos)");
            Console.WriteLine("9. Command (Undo)");
            Console.WriteLine("10. State (Status Pedido)");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            var op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    SingletonDemo.Run();
                    break;
                case "2":
                    FactoryMethodDemo.Run();
                    break;
                case "3":
                    AbstractFactoryDemo.Run();
                    break;
                case "4":
                    AdapterDemo.Run();
                    break;
                case "5":
                    DecoratorDemo.Run();
                    break;
                case "6":
                    FacadeDemo.Run();
                    break;
                case "7":
                    StrategyDemo.Run();
                    break;
                case "8":
                    ObserverDemo.Run();
                    break;
                case "9":
                    CommandDemo.Run();
                    break;
                case "10":
                    StateDemo.Run();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
