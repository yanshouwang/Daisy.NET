using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Terminal
{
    public class Calculator
    {
        public static double GetCircleAera(double r)
        {
            if (r < 0)
            {
                throw new Exception();
            }
            return  r * r;
        }

        public static double GetCylinderVolume(double r, double h)
        {
            return GetCircleAera(r) * h;
        }

        public static double GetConeVolume(double r, double h)
        {
            return GetCylinderVolume(r, h) / 3.0;
        }
    }
}
