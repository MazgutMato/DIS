using DIS.Distributions;
using DIS.SimulationCores;
using DIS.Models.NewsSimulation;
using DIS.SimulationCores.Statistics;
using System.Threading.Tasks;
using TestApp;

var sim = new NewsStand(1, 10000000);
sim.RunSimulation();

var stat = new NormalStatistic();

var random = new Random(1);

for (int i = 0; i < 30; i++)
{
    var rand = random.Next(1, 10);
    Console.Write(rand + ", ");
    stat.AddValue(rand);
}

Console.WriteLine();
Console.WriteLine("Result : " + stat.GetResult());
Console.WriteLine("Standart dev: " + stat.StandardDeviation());
var con = stat.ConfidenceInterval();
Console.WriteLine("Confidance :<" + con.Item1 + ">,<" + con.Item2 + ">");

Console.WriteLine();
Console.WriteLine("Standart dev: " + stat.StandardDeviation());
var con2 = stat.ConfidenceInterval();
Console.WriteLine("Confidance :<" + con2.Item1 + ">,<" + con2.Item2 + ">");

