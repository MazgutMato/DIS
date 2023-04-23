using OSPABA;
using simulation;
using managers;
using continualAssistants;
using instantAssistants;
namespace agents
{
	//meta! id="2"
	public class AgentOkolie : Agent
	{
		public AgentOkolie(int id, Simulation mySim, Agent parent) :
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
			new ManagerOkolie(SimId.ManagerOkolie, MySim, this);
			new Scheduler1(SimId.Scheduler1, MySim, this);
			AddOwnMessage(Mc.ZakaznikPrisiel);
			AddOwnMessage(Mc.OdchodZakaznika);
		}
		//meta! tag="end"
	}
}
