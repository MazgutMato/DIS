using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.simulation
{
    public class MySimulation : Simulation
    {
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
			AgentModelu = new AgentModelu(SimId.AgentModelu, this, null);
			AgentOkolia = new AgentOkolia(SimId.AgentOkolia, this, AgentModelu);
			AgentSTK = new AgentSTK(SimId.AgentSTK, this, AgentModelu);
			AgentPrevziatia = new AgentPrevziatia(SimId.AgentPrevziatia, this, AgentSTK);
			AgentPlatenia = new AgentPlatenia(SimId.AgentPlatenia, this, AgentSTK);
			AgentKontroly = new AgentKontroly(SimId.AgentKontroly, this, AgentSTK);
		}
		public AgentModelu AgentModelu
		{ get; set; }
		public AgentOkolia AgentOkolia
		{ get; set; }
		public AgentSTK AgentSTK
		{ get; set; }
		public AgentPrevziatia AgentPrevziatia
		{ get; set; }
		public AgentPlatenia AgentPlatenia
		{ get; set; }
		public AgentKontroly AgentKontroly
		{ get; set; }
		//meta! tag="end"
    }
}