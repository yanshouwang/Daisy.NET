using HelloWorld.Terminal.Vehicle;
using System;
using System.Windows;
using System.Windows.Forms;

namespace HelloWorld.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            Car car = new Car();
            car.Started += OnStarted;
            bicycle.Run();
            car.Run();
            Console.WriteLine(bicycle.Speed);
            Console.WriteLine(car.Speed);
            Console.ReadLine();
        }

        private static void OnStarted(object sender, EventArgs e)
        {
            Car car = (Car)sender;
            Console.WriteLine(car.Speed);
        }
    }
}
