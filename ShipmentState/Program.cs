using System;

namespace ShipmentState
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new Ordered());
            context.Request1();
            context.Request2();
        }
    }
}