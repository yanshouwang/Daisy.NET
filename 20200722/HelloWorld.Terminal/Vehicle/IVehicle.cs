using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Terminal.Vehicle
{
    interface IVehicle
    {
        int WheelsCount { get; }

        double Speed { get;}

        void Run();
    }
}
