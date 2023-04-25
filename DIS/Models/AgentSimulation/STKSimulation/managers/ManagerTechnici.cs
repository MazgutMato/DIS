using OSPABA;
using simulation;
using continualAssistants;
using instantAssistants;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="23"
    public class ManagerTechnici : Manager
    {
        public ManagerTechnici(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="AgentSTK", id="29", type="Request"
		public void ProcessPrevziatieVozidla(MessageForm message)
        {
        }

		//meta! sender="ProcessPlatenia", id="63", type="Finish"
		public void ProcessFinishProcessPlatenia(MessageForm message)
        {
        }

		//meta! sender="ProcessPrevziatia", id="36", type="Finish"
		public void ProcessFinishProcessPrevziatia(MessageForm message)
        {
        }

		//meta! sender="AgentSTK", id="32", type="Request"
		public void ProcessZaplatenieKontroly(MessageForm message)
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
				switch (message.Sender.Id)
				{
				case SimId.ProcessPlatenia:
					ProcessFinishProcessPlatenia(message);
				break;

				case SimId.ProcessPrevziatia:
					ProcessFinishProcessPrevziatia(message);
				break;
				}
			break;

			case Mc.ZaplatenieKontroly:
				ProcessZaplatenieKontroly(message);
			break;

			case Mc.PrevziatieVozidla:
				ProcessPrevziatieVozidla(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
        public new AgentTechnici MyAgent
        {
            get
            {
                return (AgentTechnici)base.MyAgent;
            }
        }
    }
}