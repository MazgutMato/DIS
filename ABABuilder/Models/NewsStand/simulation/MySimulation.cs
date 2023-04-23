using OSPABA;
using agents;
namespace simulation
{
	public class MySimulation : Simulation
	{
		public MySimulation()
		{
			Init();
		}

		override public void PrepareSimulation()
		{
			base.PrepareSimulation();
			// Create global statistcis
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Reset entities, queues, local statistics, etc...
		}

		override public void ReplicationFinished()
		{
			// Collect local statistics into global, update UI, etc...
			base.ReplicationFinished();
		}

		override public void SimulationFinished()
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
