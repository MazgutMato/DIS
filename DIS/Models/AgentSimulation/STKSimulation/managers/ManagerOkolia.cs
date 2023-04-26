using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Models.AgentSimulation.STKSimulation.simulation;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="2"
    public class ManagerOkolia : Manager
    {
        public ManagerOkolia(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="PlanovacPrichodov", id="10", type="Finish"
		public void ProcessFinish(MessageForm message)
        {
        }

		//meta! sender="AgentModelu", id="6", type="Notice"
		public void ProcessOdchodZakaznika(MessageForm message)
        {
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
            }
        }

		//meta! sender="PlanovacPrichodov", id="13", type="Notice"
		public void ProcessNovyZakaznik(MessageForm message)
		{
            message.Code = Mc.PrichodZakaznika;
            message.Addressee = MySim.FindAgent(SimId.AgentModelu);
            Notice(message);
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

			case Mc.OdchodZakaznika:
				ProcessOdchodZakaznika(message);
			break;

			case Mc.NovyZakaznik:
				ProcessNovyZakaznik(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
        public new AgentOkolia MyAgent
        {
            get
            {
                return (AgentOkolia)base.MyAgent;
            }
        }
    }
}