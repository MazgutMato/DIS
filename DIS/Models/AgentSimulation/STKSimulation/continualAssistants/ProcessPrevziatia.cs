using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Distributions;

namespace DIS.Models.AgentSimulation.STKSimulation.continualAssistants
{
    //meta! id="35"
    public class ProcessPrevziatia : Process
    {
        private TriangularDistribution CasPrevzatia { get; set; }
        public ProcessPrevziatia(int id, Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.KoniecPrevziatia);
            CasPrevzatia = new TriangularDistribution(180, 695, 431);
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

		//meta! sender="AgentTechnici", id="36", type="Start"
		public void ProcessStart(MessageForm message)
        {
            var sprava = (MyMessage)message;
            sprava.Zamestnanec.Pracuje = entities.Pracuje.PREBERA;
            sprava.Zamestnanec.Vozidlo = sprava.Vozidlo;
            sprava.Code = Mc.KoniecPrevziatia;
            Hold(CasPrevzatia.Next(), sprava);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            var sprava = (MyMessage)message;            
            switch (message.Code)
            {
                case Mc.KoniecPrevziatia:
                    sprava.Zamestnanec.Pracuje = entities.Pracuje.NIE;
                    sprava.Zamestnanec.Vozidlo = null;
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
        public new AgentTechnici MyAgent
        {
            get
            {
                return (AgentTechnici)base.MyAgent;
            }
        }
    }
}