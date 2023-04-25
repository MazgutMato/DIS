using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.managers;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.entities;
using DIS.Models.EventSimulation.STKSimulation;

namespace DIS.Models.AgentSimulation.STKSimulation.agents
{
    //meta! id="17"
    public class AgentSTK : Agent
    {
        public Queue<Vozidlo> ParkoviskoPrevziate { get; set; }
        public AgentSTK(int id, Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
            ParkoviskoPrevziate = new Queue<Vozidlo>();
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerSTK(SimId.ManagerSTK, MySim, this);
			new PlanovacPrestavky(SimId.PlanovacPrestavky, MySim, this);
			new ProcessPrestavka(SimId.ProcessPrestavka, MySim, this);
			AddOwnMessage(Mc.PrevziatieVozidla);
			AddOwnMessage(Mc.RezervujMiesto);
			AddOwnMessage(Mc.ObsluhaZakaznika);
			AddOwnMessage(Mc.ZaplatenieKontroly);
			AddOwnMessage(Mc.KontrolaVozidla);
			AddOwnMessage(Mc.ZacniPrestavku);
		}
		//meta! tag="end"
    }
}