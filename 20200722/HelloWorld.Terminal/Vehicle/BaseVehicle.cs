using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Terminal.Vehicle
{
    abstract class BaseVehicle : IVehicle
    {
        public int WheelsCount { get; }
        public double Speed { get; private set; }

        protected BaseVehicle(int wheelsCount)
        {
            WheelsCount = wheelsCount;
            Speed = 0.0;
        }

        public virtual void Run()
        {
            Speed = GetSpeed();
        }

        protected abstract double GetSpeed();
    }
}
