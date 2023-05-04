using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Distributions;
using DIS.Models.AgentSimulation.STKSimulation.entities;

namespace DIS.Models.AgentSimulation.STKSimulation.continualAssistants
{
    //meta! id="9"
    public class PlanovacPrichodov : Scheduler
    {
        private Exponential RozdeleniePrichod { get; set; }
        private Exponential RozdeleniePrichodZrychlene { get; set; }
        private DiscreteEmpirical RozdelenieTyp { get; set; }
        private int PocetVozidiel { get; set; }
        public PlanovacPrichodov(int id, Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
            RozdeleniePrichodZrychlene = new Exponential((double)3600 / 23 * 0.76);
            RozdeleniePrichod = new Exponential((double)3600 / 23);
            var empParams = new List<EmpiricalParam>();
            empParams.AddRange(new[] {
                new EmpiricalParam(1, 1, 0.65),
                new EmpiricalParam(2, 2, 0.21),
                new EmpiricalParam(3, 3, 0.14)
            });
            RozdelenieTyp = new DiscreteEmpirical(empParams);
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication            
            PocetVozidiel = 0;
        }

		//meta! sender="AgentOkolia", id="10", type="Start"
		public void ProcessStart(MessageForm message)
        {
            var copy = (MyMessage)message.CreateCopy();           
            copy.Code = Mc.NovyZakaznik;
            Hold(0, copy);
        }

		//meta! userInfo="Process messages defined in code", id="0"
		public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.NovyZakaznik:
                    var dalsiPrichod = 0.0;
                    if (MyAgent.ZrychleniePrichodu)
                    {
                        dalsiPrichod = RozdeleniePrichodZrychlene.Next();
                    }
                    else
                    {
                        dalsiPrichod = RozdeleniePrichod.Next();
                    }                    
                    if ((MySim.CurrentTime + dalsiPrichod) < 405 * 60)
                    {
                        Hold(dalsiPrichod, message.CreateCopy());

                        MyMessage sprava = (MyMessage)message;
                        PocetVozidiel++;
                        sprava.Vozidlo = new Vozidlo(PocetVozidiel, (TypVozidla)RozdelenieTyp.Next(), MySim.CurrentTime);
                        sprava.Addressee = MyAgent;

                        Notice(sprava);
                    }
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
        public new AgentOkolia MyAgent
        {
            get
            {
                return (AgentOkolia)base.MyAgent;
            }
        }
    }
}