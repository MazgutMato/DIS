using DIS.Distributions;
using DIS.Models.AgentSimulation.NewsStandSimulation.Agents;

namespace DIS.Models.AgentSimulation.NewsStandSimulation.Simulation
{
    public class MySimulation : OSPABA.Simulation
    {
        public Exponential GeneratorPrichodov { get; set; }
        public Exponential GeneratorObluhy { get; set; }
        public MySimulation()
        {
            Init();
        }

        override protected void PrepareSimulation()
        {
            base.PrepareSimulation();
            // Create global statistcis
        }

        override protected void PrepareReplication()
        {
            base.PrepareReplication();
            // Reset entities, queues, local statistics, etc...

            //Generatory
            GeneratorObluhy = new Exponential(4 * 60);
            GeneratorPrichodov = new Exponential(5 * 60);
        }

        override protected void ReplicationFinished()
        {
            // Collect local statistics into global, update UI, etc...
            base.ReplicationFinished();
        }

        override protected void SimulationFinished()
        {
            // Dysplay simulation results
            base.SimulationFinished();
        }

        //meta! userInfo="Generated code: do not modify", tag="begin"
        private void Init()
        {
            AgentModel = new AgentModel(SimId.AgentModel, this, null);
            AgentOkolie = new AgentOkolie(SimId.AgentOkolie, this, AgentModel);
            AgentStanok = new AgentStanok(SimId.AgentStanok, this, AgentModel);         
        }
        public AgentModel AgentModel
        { get; set; }
        public AgentOkolie AgentOkolie
        { get; set; }
        public AgentStanok AgentStanok
        { get; set; }
        //meta! tag="end"
    }
}
