using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.managers;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.SimulationCores.Statistics;

namespace DIS.Models.AgentSimulation.STKSimulation.agents
{
    //meta! id="2"
    public class AgentOkolia : Agent
    {
        public bool ZrychleniePrichodu { get; set; } = false;
        public NormalStatistic CasVSysteme { get; set; }
        public WeightStatistic VozidlaVSysteme { get; set; }
        public int PocetVozidilVSysteme { get; set; }
        public AgentOkolia(int id, Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
            //Stat
            CasVSysteme = new NormalStatistic();
            VozidlaVSysteme = new WeightStatistic(MySim);
            PocetVozidilVSysteme = 0;
            //Zacatie simulacie
            var sprava = new MyMessage(MySim);
            sprava.Addressee = FindAssistant(SimId.PlanovacPrichodov);
            MyManager.StartContinualAssistant(sprava);            
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerOkolia(SimId.ManagerOkolia, MySim, this);
			new PlanovacPrichodov(SimId.PlanovacPrichodov, MySim, this);
			AddOwnMessage(Mc.OdchodZakaznika);
			AddOwnMessage(Mc.NovyZakaznik);
		}
		//meta! tag="end"
    }
}