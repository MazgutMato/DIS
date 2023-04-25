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
			AgentAutomechanici = new AgentAutomechanici(SimId.AgentAutomechanici, this, AgentSTK);
			AgentTechnici = new AgentTechnici(SimId.AgentTechnici, this, AgentSTK);
		}
		public AgentModelu AgentModelu
		{ get; set; }
		public AgentOkolia AgentOkolia
		{ get; set; }
		public AgentSTK AgentSTK
		{ get; set; }
		public AgentAutomechanici AgentAutomechanici
		{ get; set; }
		public AgentTechnici AgentTechnici
		{ get; set; }
		//meta! tag="end"
    }
}