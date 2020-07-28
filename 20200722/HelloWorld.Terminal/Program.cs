using HelloWorld.Terminal.Vehicle;
using System;
using System.Threading.Tasks;
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
        static void Main()
        {
            // 求圆的面积
            double a = Calculator.GetCircleAera(20.0);
            // 求圆柱的体积
            double v1 = Calculator.GetCylinderVolume(20.0, 10.0);
            // 求圆锥的面积
            double v2 = Calculator.GetConeVolume(20.0, 10.0);

            Console.WriteLine(a);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }
}
