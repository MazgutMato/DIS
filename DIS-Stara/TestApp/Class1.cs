using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Class1
    {
        public static async Task For1()
        {
            for (int i = 0; i < 10; i++)
            {
                await Console.Out.WriteLineAsync(i.ToString());
                await Task.Delay(1000);
            }
        }

        public static async Task For2()
        {
            for (int i = 10; i < 20; i++)
            {
                await Console.Out.WriteLineAsync(i.ToString());
                await Task.Delay(500);
            }
        }
    }
}
