using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethods
{
    public class FordEscacpeFactory : CarFactory
    {
        public override Car Create()
        {
            return new Car("red", "Ford", "Escape");        
        }
    }
}