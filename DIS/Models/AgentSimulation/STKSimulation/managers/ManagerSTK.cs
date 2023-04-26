using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Models.AgentSimulation.STKSimulation.entities;
using System.Reflection;

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
            sprava.Code = Mc.KontrolaVozidla;
            sprava.Addressee = MySim.FindAgent(SimId.AgentAutomechanici);
			Request(sprava);
		}

		//meta! sender="AgentModelu", id="28", type="Request"
		public void ProcessObsluhaZakaznika(MessageForm message)
		{
			var sprava = (MyMessage)message;
            sprava.Code = Mc.PrevziatieVozidla;
            sprava.Addressee = MySim.FindAgent(SimId.AgentTechnici);
            Request(message);
        }

		//meta! sender="AgentTechnici", id="32", type="Response"
		public void ProcessZaplatenieKontroly(MessageForm message)
		{
			var sprava = (MyMessage)message;
			//Koniec obluhy
			sprava.Code = Mc.ObsluhaZakaznika;
            Response(sprava);
		}

		//meta! sender="AgentAutomechanici", id="30", type="Response"
		public void ProcessKontrolaVozidla(MessageForm message)
		{
            var sprava = (MyMessage)message;
            sprava.Code = Mc.ZaplatenieKontroly;
            sprava.Addressee = MySim.FindAgent(SimId.AgentTechnici);
            Request(sprava);
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

		//meta! sender="AgentAutomechanici", id="76", type="Notice"
		public void ProcessUvolnenieMiesta(MessageForm message)
		{
			var sprava = (MyMessage)message;
			sprava.Code = Mc.UvolnenieMiesta;
			sprava.Addressee = MySim.FindAgent(SimId.AgentTechnici);
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

			case Mc.ZaplatenieKontroly:
				ProcessZaplatenieKontroly(message);
			break;

			case Mc.PrevziatieVozidla:
				ProcessPrevziatieVozidla(message);
			break;

			case Mc.KontrolaVozidla:
				ProcessKontrolaVozidla(message);
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

			case Mc.UvolnenieMiesta:
				ProcessUvolnenieMiesta(message);
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
    }
}