using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Models.AgentSimulation.STKSimulation.simulation;

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
			var sprava = (MyMessage)message;			
			if(MyAgent.VolniTechnici.Count > 0 && MyAgent.VolneMiestaKontrola > 0)
			{
				//Rezervacia miesta
				MyAgent.VolneMiestaKontrola--;
				//Pridelenie technika
				sprava.Zamestnanec = MyAgent.VolniTechnici.Dequeue();
				//Zacatie processu
                sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessPrevziatia);
                StartContinualAssistant(sprava);
            }
			else
			{
				MyAgent.ParkoviskoPrevziate.Enqueue(sprava.Vozidlo);
			}
        }

		//meta! sender="ProcessPlatenia", id="63", type="Finish"
		public void ProcessFinishProcessPlatenia(MessageForm message)
        {
            var sprava = (MyMessage)message;
            //Odoslanie na koniec obsluhy
            var copia = (MyMessage)message.CreateCopy();
            copia.Zamestnanec = null;
            copia.Code = Mc.ZaplatenieKontroly;
            Response(copia);
            //Uvolnenie technika
            sprava.Vozidlo = null;
            UvolnenieTechnika(sprava);
        }

		//meta! sender="ProcessPrevziatia", id="36", type="Finish"
		public void ProcessFinishProcessPrevziatia(MessageForm message)
        {
            var sprava = (MyMessage)message;
			//Odoslanie na kontrolu
			var copia = (MyMessage)message.CreateCopy();
			copia.Zamestnanec = null;
            copia.Code = Mc.PrevziatieVozidla;
            Response(copia);
			//Uvolnenie technika
			sprava.Vozidlo = null;
			UvolnenieTechnika(sprava);
        }

		//meta! sender="AgentSTK", id="32", type="Request"
		public void ProcessZaplatenieKontroly(MessageForm message)
        {
            var sprava = (MyMessage)message;
            if (MyAgent.VolniTechnici.Count > 0)
            {
                //Pridelenie technika
                sprava.Zamestnanec = MyAgent.VolniTechnici.Dequeue();
                //Zacatie processu
                sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessPlatenia);
                StartContinualAssistant(sprava);
            }
            else
            {
                MyAgent.ParkoviskoPlatba.Enqueue(sprava.Vozidlo);
            }
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
            }
        }

		//meta! sender="AgentSTK", id="77", type="Notice"
		public void ProcessUvolnenieMiesta(MessageForm message)
		{
            //Uvolnenie miesta
            MyAgent.VolneMiestaKontrola++;
            //Zacatie prevzatia
            var sprava = (MyMessage)message;
            if (MyAgent.ParkoviskoPrevziate.Count > 0 && MyAgent.VolniTechnici.Count > 0)
            {
                //Rezervacia miesta
                MyAgent.VolneMiestaKontrola--;
                //Pridelenie vozidla
                sprava.Vozidlo = MyAgent.ParkoviskoPrevziate.Dequeue();
                //Priradenie technika
                sprava.Zamestnanec = MyAgent.VolniTechnici.Dequeue();
                //Zacatie processu
                sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessPrevziatia);
                StartContinualAssistant(sprava);
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
			case Mc.UvolnenieMiesta:
				ProcessUvolnenieMiesta(message);
			break;

			case Mc.ZaplatenieKontroly:
				ProcessZaplatenieKontroly(message);
			break;

			case Mc.PrevziatieVozidla:
				ProcessPrevziatieVozidla(message);
			break;

			case Mc.Finish:
				switch (message.Sender.Id)
				{
				case SimId.ProcessPrevziatia:
					ProcessFinishProcessPrevziatia(message);
				break;

				case SimId.ProcessPlatenia:
					ProcessFinishProcessPlatenia(message);
				break;
				}
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
		private void UvolnenieTechnika(MessageForm message)
		{
			var sprava = (MyMessage)message.CreateCopy();
			//Platba
			if(MyAgent.ParkoviskoPlatba.Count > 0){
				sprava.Vozidlo = MyAgent.ParkoviskoPlatba.Dequeue();
                sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessPlatenia);
                StartContinualAssistant(sprava);
			}
            //Prevzatie
            else if (MyAgent.ParkoviskoPrevziate.Count > 0 && MyAgent.VolneMiestaKontrola > 0){
                //Rezervacia miesta
                MyAgent.VolneMiestaKontrola--;
				//Pridelenie vozidla
				sprava.Vozidlo = MyAgent.ParkoviskoPrevziate.Dequeue();
                //Zacatie processu
                sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessPrevziatia);
                StartContinualAssistant(sprava);
            }
            //Uvolnenie
            else
            {
				MyAgent.VolniTechnici.Enqueue(sprava.Zamestnanec);
			}					
		}
    }
}