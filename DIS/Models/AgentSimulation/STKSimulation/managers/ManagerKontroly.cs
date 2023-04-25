using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="25"
    public class ManagerKontroly : Manager
    {
        public ManagerKontroly(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="ProcessKontroly", id="39", type="Finish"
		public void ProcessFinish(MessageForm message)
        {
            var sprava = (MyMessage)message;
            Console.WriteLine("Koniec kontroly(" + MySim.CurrentTime + "): " + sprava.Vozidlo +
                "\tZamestnanec " + sprava.Zamestnanec + "\n");
            sprava.Code = Mc.KontrolaVozidla;
            Response(sprava);
        }

		//meta! sender="AgentSTK", id="30", type="Request"
		public void ProcessKontrolaVozidla(MessageForm message)
        {
            var sprava = (MyMessage)message;
            sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessKontroly);
            StartContinualAssistant(sprava);
            Console.WriteLine("Zaciatok kontroly(" + MySim.CurrentTime + "): " + sprava.Vozidlo +
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
        public new AgentKontroly MyAgent
        {
            get
            {
                return (AgentKontroly)base.MyAgent;
            }
        }
    }
}