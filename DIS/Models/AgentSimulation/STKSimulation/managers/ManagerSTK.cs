using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="17"
    public class ManagerSTK : Manager
    {
        public ManagerSTK(int id, Simulation mySim, Agent myAgent) :
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

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
            }
        }

		//meta! sender="AgentPrevziatia", id="29", type="Response"
		public void ProcessPrevziatieVozidla(MessageForm message)
		{
		}

		//meta! sender="AgentModelu", id="28", type="Request"
		public void ProcessObsluhaZakaznika(MessageForm message)
		{
		}

		//meta! sender="AgentPlatenia", id="32", type="Response"
		public void ProcessZaplatenieKontroly(MessageForm message)
		{
		}

		//meta! sender="AgentKontroly", id="30", type="Response"
		public void ProcessKontrolaVozidla(MessageForm message)
		{
		}

		//meta! userInfo="Generated code: do not modify", tag="begin"
		public void Init()
		{
		}

		override public void ProcessMessage(MessageForm message)
		{
			switch (message.Code)
			{
			case Mc.PrevziatieVozidla:
				ProcessPrevziatieVozidla(message);
			break;

			case Mc.ZaplatenieKontroly:
				ProcessZaplatenieKontroly(message);
			break;

			case Mc.ObsluhaZakaznika:
				ProcessObsluhaZakaznika(message);
			break;

			case Mc.KontrolaVozidla:
				ProcessKontrolaVozidla(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
        public new AgentSTK MyAgent
        {
            get
            {
                return (AgentSTK)base.MyAgent;
            }
        }
    }
}