using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.entities;
using DIS.Models.AgentSimulation.STKSimulation.managers;
using DIS.SimulationCores.Statistics;

namespace DIS.Models.AgentSimulation.STKSimulation.agents
{
    //meta! id="23"
    public class AgentTechnici : Agent
    {
        public int PocetTechnikov { get; set; } = Config.PocetTechnikov;
        public Queue<Zamestnanec> VolniTechnici { get; set; }
        public List<Zamestnanec> VsetciTechnici { get; set; }
        public Queue<MyMessage> ParkoviskoPlatba { get; set; }
        public Queue<MyMessage> ParkoviskoPrevziate { get; set; }
        public int VolneMiestaKontrola { get; set; }
        public NormalStatistic CasCakaniaPrevzatie { get; set; }
        public WeightStatistic DlzkaRadyPrevzatie { get;set; }
        public AgentTechnici(int id, Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
            VolneMiestaKontrola = Config.KapacitaParkoviskaKontrola;
            ParkoviskoPrevziate = new Queue<MyMessage>();
            ParkoviskoPlatba = new Queue<MyMessage>();            
            ZmenPocetTechnikov(PocetTechnikov);         
            //Stat
            CasCakaniaPrevzatie = new NormalStatistic();
            DlzkaRadyPrevzatie = new WeightStatistic(MySim);
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerTechnici(SimId.ManagerTechnici, MySim, this);
			new ProcessPlatenia(SimId.ProcessPlatenia, MySim, this);
			new ProcessPrevziatia(SimId.ProcessPrevziatia, MySim, this);
			AddOwnMessage(Mc.PrevziatieVozidla);
			AddOwnMessage(Mc.UvolnenieMiesta);
			AddOwnMessage(Mc.ZaplatenieKontroly);
		}
		//meta! tag="end"

        private void ZmenPocetTechnikov(int pocet)
        {
            VolniTechnici = new Queue<Zamestnanec>();
            for (int i = 0; i < pocet; i++)
            {
                VolniTechnici.Enqueue(new Zamestnanec(i + 1, TypZamestnanca.TECHNIK));
            }
            VsetciTechnici = new List<Zamestnanec>();
            VsetciTechnici.AddRange(VolniTechnici);
        }
    }
}