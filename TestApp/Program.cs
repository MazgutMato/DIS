using DIS.Distributions;
using DIS.SimulationCores;
using DIS.SimulationCores.Statistics;
using System.Threading.Tasks;
using TestApp;

var dis = new Exponential(10);

for (int i = 0; i < 100000; i++)
{
    Console.WriteLine(dis.Next());
}