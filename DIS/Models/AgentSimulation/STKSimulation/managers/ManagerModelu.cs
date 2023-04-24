using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Models.AgentSimulation.STKSimulation.simulation;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="1"
    public class ManagerModelu : Manager
    {
        public ManagerModelu(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="AgentOkolia", id="5", type="Notice"
		public void ProcessPrichodZakaznika(MessageForm message)
        {
            message.Code = Mc.ObsluhaZakaznika;
            message.Addressee = MySim.FindAgent(SimId.AgentSTK);
            Request(message);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
            }
        }

		//meta! sender="AgentSTK", id="22", type="Response"
		public void ProcessObsluhaZakaznika(MessageForm message)
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
			case Mc.PrichodZakaznika:
				ProcessPrichodZakaznika(message);
			break;

			case Mc.ObsluhaZakaznika:
				ProcessObsluhaZakaznika(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
        public new AgentModelu MyAgent
        {
            get
            {
                return (AgentModelu)base.MyAgent;
            }
        }
    }
}