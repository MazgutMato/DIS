using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="34"
    public class ManagerPrevziatia : Manager
    {
        public ManagerPrevziatia(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="AgentSTK", id="29", type="Request"
		public void ProcessPrevziatieVozidla(MessageForm message)
		{
            var sprava = (MyMessage)message;
            sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessPrevziatia);
            StartContinualAssistant(sprava);
            Console.WriteLine("Zaciatok prevziatia(" + MySim.CurrentTime + "): " + sprava.Vozidlo +
                "\tZamestnanec " + sprava.Zamestnanec + "\n");
        }

		//meta! sender="ProcessPrevziatia", id="36", type="Finish"
		public void ProcessFinish(MessageForm message)
		{
            var sprava = (MyMessage)message;
            Console.WriteLine("Koniec prevziatia(" + MySim.CurrentTime + "): " + sprava.Vozidlo +
                "\tZamestnanec " + sprava.Zamestnanec + "\n");
            sprava.Code = Mc.PrevziatieVozidla;
            Response(sprava);
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

			case Mc.Finish:
				ProcessFinish(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
        public new AgentPrevziatia MyAgent
        {
            get
            {
                return (AgentPrevziatia)base.MyAgent;
            }
        }
    }
}