using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.managers;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;

namespace DIS.Models.AgentSimulation.STKSimulation.agents
{
    //meta! id="24"
    public class AgentPlatenia : Agent
    {
        public AgentPlatenia(int id, Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerPlatenia(SimId.ManagerPlatenia, MySim, this);
			new ProcessPlatenia(SimId.ProcessPlatenia, MySim, this);
			AddOwnMessage(Mc.ZaplatenieKontroly);
		}
		//meta! tag="end"
    }
}