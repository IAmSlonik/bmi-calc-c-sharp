using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Colorful;
using Console = Colorful.Console;

namespace bmiCalcSHARP
{
    class ASCII
    {
        public void Text()
        {
            string bmi = @"__________    _____  .___  _________     _____  .____   _________  
\______   \  /     \ |   | \_   ___ \   /  _  \ |    |  \_   ___ \ 
 |    |  _/ /  \ /  \|   | /    \  \/  /  /_\  \|    |  /    \  \/ 
 |    |   \/    Y    \   | \     \____/    |    \    |__\     \____
 |______  /\____|__  /___|  \______  /\____|__  /_______ \______  /
        \/         \/              \/         \/        \/      \/";
            Console.WriteLine(bmi, Color.Aqua);
        }
    }
}
