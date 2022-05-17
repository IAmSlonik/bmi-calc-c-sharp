using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Colorful;
using Console = Colorful.Console;

namespace bmiCalcSHARP
{
    class calc
    {
        public void Calc(double weight, double height)
        {
            Console.Clear();
            ASCII ASCII = new ASCII();
            ASCII.Text();
            double bmi = weight / (height * height);
            //Console.WriteLine($"b{Convert.ToString(bmi)}, w{weight}, h{height}");
            Console.Write("["); Console.Write("*", Color.Aqua); Console.Write("] ");
            Console.WriteLine("Your BMI: " + Math.Round(bmi,2));
            Console.Write("\n["); Console.Write("*", Color.Aqua); Console.Write("] ");Console.Write("Press any key to exit...");Console.ReadKey(true);
        }
    }
}
