using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld.Terminal.Vehicle
{
    class Car : BaseVehicle
    {
        public event EventHandler Started;

        public Car()
            : base(4)
        {

        }

        protected override double GetSpeed()
        {
            return 100;
        }

        public override void Run()
        {
            new Thread(() =>
            {
                Thread.Sleep(5000);
                base.Run();
                Started.Invoke(this, EventArgs.Empty);
            }).Start();
        }
    }
}
