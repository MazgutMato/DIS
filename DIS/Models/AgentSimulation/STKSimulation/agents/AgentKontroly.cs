using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.managers;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;

namespace DIS.Models.AgentSimulation.STKSimulation.agents
{
    //meta! id="25"
    public class AgentKontroly : Agent
    {
        public AgentKontroly(int id, Simulation mySim, Agent parent) :
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
			new ManagerKontroly(SimId.ManagerKontroly, MySim, this);
			new ProcessKontroly(SimId.ProcessKontroly, MySim, this);
			AddOwnMessage(Mc.KontrolaVozidla);
		}
		//meta! tag="end"
    }
}