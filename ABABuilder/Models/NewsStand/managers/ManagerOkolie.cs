using OSPABA;
using simulation;
using agents;
using continualAssistants;
using instantAssistants;
namespace managers
{
	//meta! id="2"
	public class ManagerOkolie : Manager
	{
		public ManagerOkolie(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="Scheduler1", id="21", type="Notice"
		public void ProcessZakaznikPrisiel(MessageForm message)
		{
		}

		//meta! sender="AgentModel", id="9", type="Notice"
		public void ProcessOdchodZakaznika(MessageForm message)
		{
		}

		//meta! sender="Scheduler1", id="20", type="Finish"
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
			case Mc.OdchodZakaznika:
				ProcessOdchodZakaznika(message);
			break;

			case Mc.Finish:
				ProcessFinish(message);
			break;

			case Mc.ZakaznikPrisiel:
				ProcessZakaznikPrisiel(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
		public new AgentOkolie MyAgent
		{
			get
			{
				return (AgentOkolie)base.MyAgent;
			}
		}
	}
}
