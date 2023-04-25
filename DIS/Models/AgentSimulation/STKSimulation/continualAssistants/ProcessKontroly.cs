using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Distributions;
using DIS.Models.AgentSimulation.STKSimulation.entities;

namespace DIS.Models.AgentSimulation.STKSimulation.continualAssistants
{
    //meta! id="38"
    public class ProcessKontroly : Process
    {
        private Distribution KontrolaOsobne { get; set; }
        private Distribution KontrolaDodavka { get; set; }
        private Distribution KontrolaNakladne { get; set; }   
        public ProcessKontroly(int id, Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.KoniecKontroly);
            KontrolaOsobne = new DiscreteUniform(31, 45);            
            var dodavkaParams = new List<EmpiricalParam>();
            dodavkaParams.AddRange(new[] {
                new EmpiricalParam(35, 37, 0.2),
                new EmpiricalParam(38, 40, 0.35),
                new EmpiricalParam(41, 47, 0.3),
                new EmpiricalParam(48, 52, 0.15)
            });
            KontrolaDodavka = new DiscreteEmpirical(dodavkaParams);
            //Ispection time in minutes truck[6]
            var nakladneParams = new List<EmpiricalParam>();
            nakladneParams.AddRange(new[] {
                new EmpiricalParam(37, 42, 0.05),
                new EmpiricalParam(43, 45, 0.1),
                new EmpiricalParam(46, 47, 0.15),
                new EmpiricalParam(48, 51, 0.4),
                new EmpiricalParam(52, 55, 0.25),
                new EmpiricalParam(56, 65, 0.05)
            });
            KontrolaNakladne = new DiscreteEmpirical(nakladneParams);
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

		//meta! sender="AgentAutomechanici", id="39", type="Start"
		public void ProcessStart(MessageForm message)
        {
            var sprava = (MyMessage)message;
            sprava.Code = Mc.KoniecKontroly;
            switch (sprava.Vozidlo.TypVozidla)
            {
                case TypVozidla.OSOBNE:
                    Hold(KontrolaOsobne.Next(), sprava);
                    break;
                case TypVozidla.NAKLADNE:
                    Hold(KontrolaNakladne.Next(), sprava);
                    break;
                case TypVozidla.DODAVKA:
                    Hold(KontrolaDodavka.Next(), sprava);
                    break;
            }
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.KoniecKontroly:
                    AssistantFinished(message);
                    break;
            }
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		override public void ProcessMessage(MessageForm message)
		{
			switch (message.Code)
			{
			case Mc.Start:
				ProcessStart(message);
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