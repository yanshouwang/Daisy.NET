using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Terminal.Vehicle
{
    class Bicycle : BaseVehicle
    {
        public Bicycle()
            : base(2)
        {

        }

        protected override double GetSpeed()
        {
            return 10;
        }
    }
}
