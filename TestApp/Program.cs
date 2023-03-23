using DIS.Distributions;
using DIS.SimulationCores;
using DIS.SimulationCores.NewsSimulation;
using System.Threading.Tasks;
using TestApp;

var sim = new NewsStand(1, 10000000);

for (int i = 0; i < 10; i++)
{
    sim.RunSimulation();

    foreach(var statistic in sim._statistics)
    {
        Console.WriteLine(statistic.Key + ":" + statistic.Value.GetResult());
    }    
}

