using OSPABA;
using simulation;
using managers;
using continualAssistants;
using instantAssistants;
namespace agents
{
	//meta! id="3"
	public class AgentStanok : Agent
	{
		public AgentStanok(int id, Simulation mySim, Agent parent) :
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
			new ManagerStanok(SimId.ManagerStanok, MySim, this);
			new Obsluha(SimId.Obsluha, MySim, this);
			AddOwnMessage(Mc.ZaciatokObsluhy);
			AddOwnMessage(Mc.ObsluhaUkoncena);
		}
		//meta! tag="end"
	}
}
