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
            var sprava = (MyMessage)message;
            sprava.Code = Mc.ObsluhaZakaznika;
            sprava.Addressee = MySim.FindAgent(SimId.AgentSTK);
            Request(sprava);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
            }
        }

		//meta! sender="AgentSTK", id="28", type="Response"
		public void ProcessObsluhaZakaznika(MessageForm message)
		{
            var sprava = (MyMessage)message;
            sprava.Code = Mc.OdchodZakaznika;
            sprava.Addressee = MySim.FindAgent(SimId.AgentOkolia);
            Notice(sprava);
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		public void Init()
		{
		}

		override public void ProcessMessage(MessageForm message)
		{
			switch (message.Code)
			{
			case Mc.ObsluhaZakaznika:
				ProcessObsluhaZakaznika(message);
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
        public new AgentModelu MyAgent
        {
            get
            {
                return (AgentModelu)base.MyAgent;
            }
        }
    }
}