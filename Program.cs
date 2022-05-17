using System;

namespace bmiCalcSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCII ASCII = new ASCII();
            ASCII.Text();
            menu menu = new menu();
            menu.Menu();
        }
    }
}
