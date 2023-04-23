using OSPABA;
using simulation;
using agents;
using continualAssistants;
using instantAssistants;
namespace managers
{
	//meta! id="1"
	public class ManagerModel : Manager
	{
		public ManagerModel(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="AgentOkolie", id="8", type="Notice"
		public void ProcessPrichodZakaznika(MessageForm message)
		{
		}

		//meta! sender="AgentStanok", id="11", type="Notice"
		public void ProcessKoniecObsluhy(MessageForm message)
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
			case Mc.KoniecObsluhy:
				ProcessKoniecObsluhy(message);
			break;

			case Mc.PrichodZakaznika:
				ProcessPrichodZakaznika(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
		public new AgentModel MyAgent
		{
			get
			{
				return (AgentModel)base.MyAgent;
			}
		}
	}
}
