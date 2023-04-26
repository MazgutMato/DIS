using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Distributions;

namespace DIS.Models.AgentSimulation.STKSimulation.continualAssistants
{
    //meta! id="41"
    public class ProcessPlatenia : Process
    {
        private ContinuosUniform CasPlatenia { get; set; }
        public ProcessPlatenia(int id, Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
            CasPlatenia = new ContinuosUniform(65, 177);
            MyAgent.AddOwnMessage(Mc.KoniecPlatenia);
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

		//meta! sender="AgentTechnici", id="63", type="Start"
		public void ProcessStart(MessageForm message)
        {
            var sprava = (MyMessage)message;
            sprava.Zamestnanec.Pracuje = entities.Pracuje.PLATI;
            sprava.Zamestnanec.Vozidlo = sprava.Vozidlo;
            sprava.Code = Mc.KoniecPlatenia;
            Hold(CasPlatenia.Next(), sprava);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            var sprava = (MyMessage)message;
            switch (message.Code)
            {
                case Mc.KoniecPlatenia:
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