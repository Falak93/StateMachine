using System;

namespace StateMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            var car=new Stateless.StateMachine<Car.State,Car.Action>(Car.State.Stopped);

            car.Configure(Car.State.Stopped)
                .Permit(Car.Action.Start, Car.State.Stopped);
            
            Console.WriteLine($"Stete: {car.CurrenState}");
          
            car.TakeAction(Car.Action.Start);
            Console.WriteLine($"Stete: {car.CurrenState}");

            car.TakeAction(Car.Action.Start);
            Console.WriteLine($"Stete: {car.CurrenState}");

            car.TakeAction(Car.Action.Accelerate);
            Console.WriteLine($"Stete: {car.CurrenState}");

            car.TakeAction(Car.Action.Stop);
            Console.WriteLine($"Stete: {car.CurrenState}");
        }
    }
}