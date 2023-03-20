using DIS.Distributions;
using DIS.SimulationCores;
using System.Threading.Tasks;
using TestApp;

var dis = new Exponential(5);

for (int i = 0; i < 10000; i++)
{
    Console.WriteLine(dis.Next());
}
