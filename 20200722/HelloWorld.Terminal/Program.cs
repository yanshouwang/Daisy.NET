using HelloWorld.Terminal.Vehicle;
using System;
using System.Windows;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>
namespace HelloWorld.Terminal
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 0.0M;
            Console.ReadLine();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">      </param>
        /// <param name="e" ></param>
        private static void OnStarted(object sender, EventArgs e)
        {
            Car car = (Car)sender;
            Console.WriteLine(car.Speed);
        }
    }
}
