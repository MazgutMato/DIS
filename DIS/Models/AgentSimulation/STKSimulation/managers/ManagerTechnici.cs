using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.entities;

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
                //Stat
                MyAgent.CasCakaniaPrevzatie.AddValue(MySim.CurrentTime - sprava.Vozidlo.CasPrichodu);
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
                //Stat
                MyAgent.DlzkaRadyPrevzatie.AddValue(MyAgent.ParkoviskoPrevziate.Count);
                //Pridanie do rady
				MyAgent.ParkoviskoPrevziate.Enqueue(sprava);
			}
        }

		//meta! sender="ProcessPlatenia", id="63", type="Finish"
		public void ProcessFinishProcessPlatenia(MessageForm message)
        {
            var sprava = (MyMessage)message;
            //Uvolnenie technika
            UvolnenieTechnika(sprava.Zamestnanec);
            //Odoslanie na koniec obsluhy
            sprava.Zamestnanec = null;
            sprava.Code = Mc.ZaplatenieKontroly;
            Response(sprava);
        }

		//meta! sender="ProcessPrevziatia", id="36", type="Finish"
		public void ProcessFinishProcessPrevziatia(MessageForm message)
        {
            var sprava = (MyMessage)message;
            //Uvolnenie technika
            UvolnenieTechnika(sprava.Zamestnanec);
            //Odoslanie na kontrolu
            sprava.Zamestnanec = null;
            sprava.Code = Mc.PrevziatieVozidla;
            Response(sprava);
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
                MyAgent.ParkoviskoPlatba.Enqueue(sprava);
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
            //Uvolnenie technika
            if (MyAgent.VolniTechnici.Count > 0)
            {
                //Priradenie technika
                var zamestnanec = MyAgent.VolniTechnici.Dequeue();
                UvolnenieTechnika(zamestnanec);
            }
        }

		//meta! sender="PrestavkaTechnici", id="83", type="Finish"
		public void ProcessFinishPrestavkaTechnici(MessageForm message)
		{
            var sprava = (MyMessage)message;
            UvolnenieTechnika(sprava.Zamestnanec);
        }

		//meta! sender="AgentSTK", id="87", type="Notice"
		public void ProcessCasPrestavky(MessageForm message)
		{            
            //Vykonanie prestavky
            for (int i = 0; i < MyAgent.VolniTechnici.Count; i++)
            {
                MyAgent.VolniTechnici.Dequeue();
            }
            foreach (var technik in MyAgent.VsetciTechnici)
            {
                var sprava = (MyMessage)message.CreateCopy();
                sprava.Addressee = MyAgent.FindAssistant(SimId.PrestavkaTechnici);
                if (technik.Pracuje == Pracuje.NIE)
                {
                    sprava.Zamestnanec = technik;
                    StartContinualAssistant(sprava);
                }
                else
                {
                    technik.VykonajPrestavku = true;
                }
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
			case Mc.CasPrestavky:
				ProcessCasPrestavky(message);
			break;

			case Mc.Finish:
				switch (message.Sender.Id)
				{
				case SimId.PrestavkaTechnici:
					ProcessFinishPrestavkaTechnici(message);
				break;

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

			case Mc.UvolnenieMiesta:
				ProcessUvolnenieMiesta(message);
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
		private void UvolnenieTechnika(Zamestnanec zamestnanec)
		{
            //Prestavka
            if (zamestnanec.VykonajPrestavku)
            {
                var sprava = new MyMessage(MySim);
                sprava.Zamestnanec = zamestnanec;
                sprava.Addressee = MyAgent.FindAssistant(SimId.PrestavkaTechnici);
                StartContinualAssistant(sprava);
            }
			//Platba
			else if(MyAgent.ParkoviskoPlatba.Count > 0){
				var sprava = MyAgent.ParkoviskoPlatba.Dequeue();
                sprava.Zamestnanec = zamestnanec;
                sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessPlatenia);
                StartContinualAssistant(sprava);
			}
            //Prevzatie
            else if (MyAgent.ParkoviskoPrevziate.Count > 0 && MyAgent.VolneMiestaKontrola > 0){                
                MyAgent.VolneMiestaKontrola--;
                //Stat
                MyAgent.DlzkaRadyPrevzatie.AddValue(MyAgent.ParkoviskoPrevziate.Count);
                var sprava = MyAgent.ParkoviskoPrevziate.Dequeue();
                //Stat
                MyAgent.CasCakaniaPrevzatie.AddValue(MySim.CurrentTime - sprava.Vozidlo.CasPrichodu);
                sprava.Zamestnanec = zamestnanec;
                sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessPrevziatia);
                StartContinualAssistant(sprava);
            }
            //Uvolnenie
            else
            {
				MyAgent.VolniTechnici.Enqueue(zamestnanec);
			}					
		}
    }
}