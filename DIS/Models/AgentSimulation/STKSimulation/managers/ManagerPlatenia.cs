using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="24"
    public class ManagerPlatenia : Manager
    {
        public ManagerPlatenia(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="ProcessPlatenia", id="42", type="Finish"
		public void ProcessFinish(MessageForm message)
		{
            var sprava = (MyMessage)message;
            Console.WriteLine("Koniec Platenia(" + MySim.CurrentTime + "): " + sprava.Vozidlo +
                "\tZamestnanec " + sprava.Zamestnanec + "\n");
            sprava.Code = Mc.ZaplatenieKontroly;
            Response(sprava);
        }

		//meta! sender="AgentSTK", id="32", type="Request"
		public void ProcessZaplatenieKontroly(MessageForm message)
		{
            var sprava = (MyMessage)message;
            sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessPlatenia);
            StartContinualAssistant(sprava);
            Console.WriteLine("Zaciatok platenia(" + MySim.CurrentTime + "): " + sprava.Vozidlo +
                "\tZamestnanec " + sprava.Zamestnanec + "\n");
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		public void Init()
		{
		}

		override public void ProcessMessage(MessageForm message)
		{
			switch (message.Code)
			{
			case Mc.ZaplatenieKontroly:
				ProcessZaplatenieKontroly(message);
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
        public new AgentPlatenia MyAgent
        {
            get
            {
                return (AgentPlatenia)base.MyAgent;
            }
        }
    }
}