using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
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
            //Ukoncenie kontroly
            var sprava = (MyMessage)message;
            var kontrolor = sprava.Zamestnanec;
            sprava.Zamestnanec = null;
            sprava.Code = Mc.KontrolaVozidla;
            Response(sprava);
            //Zaciatok novej kontroly
            if (MyAgent.ParkoviskoKontrola.Count > 0)
            {
                var spravaKontrola = MyAgent.ParkoviskoKontrola.Dequeue();
                spravaKontrola.Zamestnanec = kontrolor;
                spravaKontrola.Addressee = MyAgent.FindAssistant(SimId.ProcessKontroly);
                StartContinualAssistant(spravaKontrola);
                UvolnenieMiesta(sprava);
            }
            else
            {
                MyAgent.VolniAutomechanici.Enqueue(kontrolor);
            }            
        }

		//meta! sender="AgentSTK", id="30", type="Request"
		public void ProcessKontrolaVozidla(MessageForm message)
        {
            var sprava = (MyMessage)message;
            if(MyAgent.VolniAutomechanici.Count > 0)
            {
                //Zaciatok kontroly
                sprava.Zamestnanec = MyAgent.VolniAutomechanici.Dequeue();
                sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessKontroly);
                StartContinualAssistant(sprava);
                //Uvolnenie miesta
                UvolnenieMiesta(sprava);
            }
            else
            {
                MyAgent.ParkoviskoKontrola.Enqueue(sprava);
            }
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
				ProcessFinish(message);
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
        public new AgentAutomechanici MyAgent
        {
            get
            {
                return (AgentAutomechanici)base.MyAgent;
            }
        }
        private void UvolnenieMiesta(MyMessage message)
        {
            //Uvolnenie miesta
            var spravaUvolnenie = (MyMessage)message.CreateCopy();
            spravaUvolnenie.Code = Mc.UvolnenieMiesta;
            spravaUvolnenie.Addressee = MySim.FindAgent(SimId.AgentSTK);
            Notice(spravaUvolnenie);
        }
    }
}