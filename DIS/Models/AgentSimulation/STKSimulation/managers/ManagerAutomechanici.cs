using OSPABA;
using simulation;
using continualAssistants;
using instantAssistants;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="21"
    public class ManagerAutomechanici : Manager
    {
        public ManagerAutomechanici(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="ProcessKontroly", id="39", type="Finish"
		public void ProcessFinish(MessageForm message)
        {
        }

		//meta! sender="AgentSTK", id="30", type="Request"
		public void ProcessKontrolaVozidla(MessageForm message)
        {
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
            }
        }

		//meta! sender="AgentSTK", id="65", type="Request"
		public void ProcessRezervujMiesto(MessageForm message)
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
			case Mc.RezervujMiesto:
				ProcessRezervujMiesto(message);
			break;

			case Mc.KontrolaVozidla:
				ProcessKontrolaVozidla(message);
			break;

			case Mc.Finish:
				ProcessFinish(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
        public new AgentAutomechanici MyAgent
        {
            get
            {
                return (AgentAutomechanici)base.MyAgent;
            }
        }
    }
}