using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Models.AgentSimulation.STKSimulation.entities;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="17"
    public class ManagerSTK : Manager
    {
        public ManagerSTK(int id, Simulation mySim, Agent myAgent) :
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

		//meta! sender="AgentTechnici", id="29", type="Response"
		public void ProcessPrevziatieVozidla(MessageForm message)
		{
			var sprava = (MyMessage)message;
			//Kontrola
			if(MyAgent.VolnyAutomechanici.Count > 0)
			{
				var spravaKopia = (MyMessage)sprava.CreateCopy();
				spravaKopia.Zamestnanec = MyAgent.VolnyAutomechanici.Dequeue();
				spravaKopia.Zamestnanec.Pracuje = Pracuje.KONTROLUJE;
				spravaKopia.Code = Mc.KontrolaVozidla;
				spravaKopia.Addressee = MySim.FindAgent(SimId.AgentKontroly);
				Request(spravaKopia);
			}
			else
			{
				MyAgent.CakajuceKontrola.Enqueue(sprava.Vozidlo);
			}
			UvolnenieTechnika(sprava);
		}

		//meta! sender="AgentModelu", id="28", type="Request"
		public void ProcessObsluhaZakaznika(MessageForm message)
		{
			var sprava = (MyMessage)message;
			//Prebranie
			if(MyAgent.VolnyTechnici.Count > 0 && (MyAgent.KapacitaParkoviska >
				(MyAgent.PrevzateVozidla + MyAgent.CakajuceKontrola.Count)))
			{
				MyAgent.PrevzateVozidla++;
				sprava.Zamestnanec = MyAgent.VolnyTechnici.Dequeue();
				sprava.Zamestnanec.Pracuje = Pracuje.PREBERA;
                sprava.Code = Mc.PrevziatieVozidla;
                sprava.Addressee = MySim.FindAgent(SimId.AgentPrevziatia);
                Request(message);
            }
			else
			{
				MyAgent.CakajucePrevziate.Enqueue(sprava.Vozidlo);
			}
		}

		//meta! sender="AgentTechnici", id="32", type="Response"
		public void ProcessZaplatenieKontroly(MessageForm message)
		{
			var sprava = (MyMessage)message;			
			UvolnenieTechnika(sprava.CreateCopy());
			//Koniec obluhy
			sprava.Code = Mc.ObsluhaZakaznika;
			Response(sprava);
		}

		//meta! sender="AgentAutomechanici", id="30", type="Response"
		public void ProcessKontrolaVozidla(MessageForm message)
		{
			var sprava = (MyMessage)message;
			//Kontrola
			if(MyAgent.CakajuceKontrola.Count > 0)
			{
				var spravaKopia = (MyMessage)sprava.CreateCopy();
				spravaKopia.Vozidlo = MyAgent.CakajuceKontrola.Dequeue();
				spravaKopia.Code = Mc.KontrolaVozidla;
				spravaKopia.Addressee = MySim.FindAgent(SimId.AgentKontroly);
				Request(spravaKopia);
			}
			else
			{
				sprava.Zamestnanec.Pracuje = Pracuje.NIE;
				MyAgent.VolnyAutomechanici.Enqueue(sprava.Zamestnanec);
			}
			//Platenie
			if(MyAgent.VolnyTechnici.Count > 0)
			{
				sprava.Zamestnanec = MyAgent.VolnyTechnici.Dequeue();
				sprava.Zamestnanec.Pracuje = Pracuje.PLATI;
                sprava.Code = Mc.ZaplatenieKontroly;
				sprava.Addressee = MySim.FindAgent(SimId.AgentPlatenia);
				Request(sprava);
			}
			else
			{
				MyAgent.CakajucePlatba.Enqueue(sprava.Vozidlo);
			}
		}

		//meta! sender="PlanovacPrestavky", id="50", type="Finish"
		public void ProcessFinishPlanovacPrestavky(MessageForm message)
		{
		}

		//meta! sender="ProcessPrestavka", id="52", type="Finish"
		public void ProcessFinishProcessPrestavka(MessageForm message)
		{
		}

		//meta! sender="PlanovacPrestavky", id="55", type="Notice"
		public void ProcessZacniPrestavku(MessageForm message)
		{
		}

		//meta! sender="AgentAutomechanici", id="65", type="Response"
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
			case Mc.ObsluhaZakaznika:
				ProcessObsluhaZakaznika(message);
			break;

			case Mc.Finish:
				switch (message.Sender.Id)
				{
				case SimId.PlanovacPrestavky:
					ProcessFinishPlanovacPrestavky(message);
				break;

				case SimId.ProcessPrestavka:
					ProcessFinishProcessPrestavka(message);
				break;
				}
			break;

			case Mc.ZaplatenieKontroly:
				ProcessZaplatenieKontroly(message);
			break;

			case Mc.PrevziatieVozidla:
				ProcessPrevziatieVozidla(message);
			break;

			case Mc.RezervujMiesto:
				ProcessRezervujMiesto(message);
			break;

			case Mc.KontrolaVozidla:
				ProcessKontrolaVozidla(message);
			break;

			case Mc.ZacniPrestavku:
				ProcessZacniPrestavku(message);
			break;

			default:
				ProcessDefault(message);
			break;
			}
		}
		//meta! tag="end"
        public new AgentSTK MyAgent
        {
            get
            {
                return (AgentSTK)base.MyAgent;
            }
        }
		private void VykonajPrestavku(Zamestnanec zamestnanec)
		{
			//Urobit pri kazdom response
		}
		private void UvolnenieTechnika(MessageForm message)
		{
            var sprava = (MyMessage)message;
            if (MyAgent.CakajucePlatba.Count > 0)
            {
				if(sprava.Zamestnanec.Pracuje == Pracuje.PREBERA)
				{
                    MyAgent.PrevzateVozidla--;
                }
                sprava.Zamestnanec.Pracuje = Pracuje.PLATI;
                sprava.Vozidlo = MyAgent.CakajucePlatba.Dequeue();
                sprava.Code = Mc.ZaplatenieKontroly;                
                sprava.Addressee = MySim.FindAgent(SimId.AgentPlatenia);
                Request(sprava);
            }
            else if (MyAgent.VolnyTechnici.Count > 0 && (MyAgent.KapacitaParkoviska >
                (MyAgent.PrevzateVozidla + MyAgent.CakajuceKontrola.Count)) &&
                MyAgent.CakajucePrevziate.Count > 0)
            {
				if(sprava.Zamestnanec.Pracuje == Pracuje.PLATI)
				{
					MyAgent.PrevzateVozidla++;
				}
				sprava.Zamestnanec.Pracuje = Pracuje.PREBERA;
                sprava.Vozidlo = MyAgent.CakajucePrevziate.Dequeue();
                sprava.Code = Mc.PrevziatieVozidla;
                sprava.Addressee = MySim.FindAgent(SimId.AgentSTK);
                Request(sprava);
            }
            else
            {
                if (sprava.Zamestnanec.Pracuje == Pracuje.PREBERA)
                {
                    MyAgent.PrevzateVozidla--;
                }
				sprava.Zamestnanec.Pracuje = Pracuje.NIE;
                MyAgent.VolnyTechnici.Enqueue(sprava.Zamestnanec);
            }
        }
    }
}