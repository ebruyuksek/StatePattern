namespace ShipmentState
{
    // Concrete States implement various behaviors, associated with a state of
    // the Context.
    class Ordered : State
    {
        public override void Forward()
        {
            Console.WriteLine("Ordered handles request1.");
            Console.WriteLine("Ordered wants to change the state of the context.");
            this._context.TransitionTo(new Processing());
        }

        public override void Backward()
        {
            Console.WriteLine("Can't go backwards.");
        }
    }

    class Processing : State
    {
        public override void Forward()
        {
            Console.WriteLine("Processing handles request1.");
            Console.WriteLine("Processing wants to change the state of the context.");
            this._context.TransitionTo(new OnWay());
        }

        public override void Backward()
        {
            Console.WriteLine("Processing handles request2.");
            Console.WriteLine("Processing wants to change the state of the context.");
            this._context.TransitionTo(new Ordered());
        }
    }

    class OnWay : State
    {
        public override void Forward()
        {
            Console.Write("OnWay handles request1.");
        }

        public override void Backward()
        {
            Console.WriteLine("ConcreteStateB handles request2.");
            Console.WriteLine("ConcreteStateB wants to change the state of the context.");
            this._context.TransitionTo(new Received());
        }
    }

    class Received : State
    {
        public override void Forward()
        {
            Console.Write("Received handles request1.");
        }

        public override void Backward()
        {
            Console.WriteLine("Can't go backwards.");
        }
    }

    //class ReturnRequest : State
    //{
    //    public override void Handle1()
    //    {
    //        Console.Write("ConcreteStateB handles request1.");
    //    }

    //    public override void Handle2()
    //    {
    //        Console.WriteLine("ConcreteStateB handles request2.");
    //        Console.WriteLine("ConcreteStateB wants to change the state of the context.");
    //        this._context.TransitionTo(new ConcreteStateA());
    //    }
    //}

}
