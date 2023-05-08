using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using System.ComponentModel.Design;
using DIS.Models.AgentSimulation.STKSimulation.entities;

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
		public void ProcessFinishProcessKontroly(MessageForm message)
        {            
            //Ukoncenie kontroly
            var sprava = (MyMessage)message;
            var kontrolor = sprava.Zamestnanec;
            sprava.Zamestnanec = null;
            sprava.Code = Mc.KontrolaVozidla;
            Response(sprava);
            UvolnenieAutomechanika(kontrolor);                               
        }

		//meta! sender="AgentSTK", id="30", type="Request"
		public void ProcessKontrolaVozidla(MessageForm message)
        {
            var sprava = (MyMessage)message;
            PriradAutomechanika(sprava);
            if (sprava.Zamestnanec != null)
            {
                //Zaciatok kontroly
                sprava.Addressee = MyAgent.FindAssistant(SimId.ProcessKontroly);
                StartContinualAssistant(sprava);
                //Uvolnenie miesta
                UvolnenieMiesta();
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

		//meta! sender="PrestavkaAutomechanici", id="86", type="Finish"
		public void ProcessFinishPrestavkaAutomechanici(MessageForm message)
		{
            var sprava = (MyMessage)message;
            UvolnenieAutomechanika(sprava.Zamestnanec);
		}

		//meta! sender="AgentSTK", id="88", type="Notice"
		public void ProcessCasPrestavky(MessageForm message)
		{
            //Nastavenie prestavky
            foreach (var technik in MyAgent.VsetciAutomechanici)
            {
                technik.VykonajPrestavku = true;
            }
            //Stat
            MyAgent.VytazenostAutomechanikovTyp1.AddValue(MyAgent.VolniAutomechaniciTyp1.Count);
            MyAgent.VytazenostAutomechanikovTyp2.AddValue(MyAgent.VolniAutomechaniciTyp2.Count);
            //Vykonanie prestavky
            while (MyAgent.VolniAutomechaniciTyp1.Count > 0)
            {
                //Prestavka
                var mechanik = MyAgent.VolniAutomechaniciTyp1.Dequeue();
                UvolnenieAutomechanika(mechanik);
            }
            while (MyAgent.VolniAutomechaniciTyp2.Count > 0)
            {                
                //Prestavka
                var mechanik = MyAgent.VolniAutomechaniciTyp2.Dequeue();
                UvolnenieAutomechanika(mechanik);
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
				switch (message.Sender.Id)
				{
				case SimId.PrestavkaAutomechanici:
					ProcessFinishPrestavkaAutomechanici(message);
				break;

				case SimId.ProcessKontroly:
					ProcessFinishProcessKontroly(message);
				break;
				}
			break;

			case Mc.KontrolaVozidla:
				ProcessKontrolaVozidla(message);
			break;

			case Mc.CasPrestavky:
				ProcessCasPrestavky(message);
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
        private void UvolnenieMiesta()
        {
            //Uvolnenie miesta
            var spravaUvolnenie = new MyMessage(MySim);
            spravaUvolnenie.Code = Mc.UvolnenieMiesta;
            spravaUvolnenie.Addressee = MySim.FindAgent(SimId.AgentSTK);
            Notice(spravaUvolnenie);
        }
        private void UvolnenieAutomechanika(Zamestnanec zamestnanec)
        {
            //Prestavka
            if(zamestnanec.VykonajPrestavku)
            {
                var sprava = new MyMessage(MySim);
                sprava.Zamestnanec = zamestnanec;
                sprava.Addressee = MyAgent.FindAssistant(SimId.PrestavkaAutomechanici);
                StartContinualAssistant(sprava);
            }
            //Uvolnenie a kontrola
            else
            {
                //Uvolnenie
                if (zamestnanec.Typ == TypZamestnanca.AUTOMECHANIK_TYP_1)
                {
                    //Stat
                    MyAgent.VytazenostAutomechanikovTyp1.AddValue(MyAgent.VolniAutomechaniciTyp1.Count); 
                    MyAgent.VolniAutomechaniciTyp1.Enqueue(zamestnanec);
                }
                else
                {
                    //Stat
                    MyAgent.VytazenostAutomechanikovTyp2.AddValue(MyAgent.VolniAutomechaniciTyp2.Count);
                    MyAgent.VolniAutomechaniciTyp2.Enqueue(zamestnanec);
                }
                //Vykonanie kontroly
                if(MyAgent.ParkoviskoKontrola.Count > 0)
                {
                    var spravaKontrola = MyAgent.ParkoviskoKontrola.Peek();
                    PriradAutomechanika(spravaKontrola);
                    if (spravaKontrola.Zamestnanec != null)
                    {
                        MyAgent.ParkoviskoKontrola.Dequeue();
                        spravaKontrola.Addressee = MyAgent.FindAssistant(SimId.ProcessKontroly);
                        StartContinualAssistant(spravaKontrola);
                        UvolnenieMiesta();
                    }
                }                
            }
        }
        private void PriradAutomechanika(MyMessage sprava)
        {
            sprava.Zamestnanec = null;
            if(sprava.Vozidlo.TypVozidla == TypVozidla.NAKLADNE &&
                MyAgent.VolniAutomechaniciTyp2.Count > 0)
            {
                //Stat
                MyAgent.VytazenostAutomechanikovTyp2.AddValue(MyAgent.VolniAutomechaniciTyp2.Count);
                sprava.Zamestnanec = MyAgent.VolniAutomechaniciTyp2.Dequeue();                               
            }
            else
            {
                if(MyAgent.VolniAutomechaniciTyp1.Count>0)
                {
                    //Stat
                    MyAgent.VytazenostAutomechanikovTyp1.AddValue(MyAgent.VolniAutomechaniciTyp1.Count);
                    sprava.Zamestnanec = MyAgent.VolniAutomechaniciTyp1.Dequeue();
                }else if (MyAgent.VolniAutomechaniciTyp2.Count > 0)
                {
                    //Stat
                    MyAgent.VytazenostAutomechanikovTyp2.AddValue(MyAgent.VolniAutomechaniciTyp2.Count);
                    sprava.Zamestnanec = MyAgent.VolniAutomechaniciTyp2.Dequeue();
                }
            }
        }
    }
}