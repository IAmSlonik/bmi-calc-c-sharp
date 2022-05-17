using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Colorful;
using Console = Colorful.Console;

namespace bmiCalcSHARP
{
    class menu
    {   
        public void Menu()
        {
            ASCII ASCII = new ASCII();
            double weight;
            double height;
            Console.Write("["); Console.Write("*", Color.Aqua); Console.Write("] ");
            Console.Write("Enter your weight [kg]: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            ASCII.Text();
            Console.Write("["); Console.Write("*", Color.Aqua); Console.Write("] ");
            Console.Write("Enter your height [m]: ");
            height = Convert.ToDouble(Console.ReadLine());
            calc calc = new calc();
            calc.Calc(weight,height);
        }
    }
}