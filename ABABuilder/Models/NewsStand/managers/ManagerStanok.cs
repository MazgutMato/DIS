using OSPABA;
using simulation;
using agents;
using continualAssistants;
using instantAssistants;
namespace managers
{
	//meta! id="3"
	public class ManagerStanok : Manager
	{
		public ManagerStanok(int id, Simulation mySim, Agent myAgent) :
			base(id, mySim, myAgent)
		{
			Init();
		}

		override public void PrepareReplication()
		{
			base.PrepareReplication();
			// Setup component for the next replication

			if (PetriNet != null)
			{
				PetriNet.Clear();
			}
		}

		//meta! sender="AgentModel", id="10", type="Notice"
		public void ProcessZaciatokObsluhy(MessageForm message)
		{
		}

		//meta! sender="Obsluha", id="18", type="Notice"
		public void ProcessObsluhaUkoncena(MessageForm message)
		{
		}

		//meta! sender="Obsluha", id="16", type="Finish"
		public void ProcessFinish(MessageForm message)
		{
		}

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
		{
			switch (message.Code)
			{
			}
		}

		//meta! userInfo="Generated code: do not modify", tag="begin"
		public void Init()
		{
		}

		override public void ProcessMessage(MessageForm message)
		{
			switch (message.Code)
			{
			case Mc.Finish:
				ProcessFinish(message);
			break;

			case Mc.ZaciatokObsluhy:
				ProcessZaciatokObsluhy(message);
			break;

			case Mc.ObsluhaUkoncena:
				ProcessObsluhaUkoncena(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
		public new AgentStanok MyAgent
		{
			get
			{
				return (AgentStanok)base.MyAgent;
			}
		}
	}
}
