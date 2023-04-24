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
        private const int KapacitaParkoviska = 5;
        public Queue<Zamestnanec> VolnyTechnici { get; set; }
        public Queue<Zamestnanec> VolnyAutomechanici { get; set; }
        public List<Zamestnanec> VsetciZamestnanci { get; set; }
        public Queue<Vozidlo> CakajucePrevziate { get; set; }
        public Queue<Vozidlo> CakajucePlatba { get; set; }
        public Queue<Vozidlo> CakajuceKontrola { get; set; }
        public AgentSTK(int id, Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
            CakajucePrevziate = new Queue<Vozidlo>();
            CakajucePlatba = new Queue<Vozidlo>();
            CakajuceKontrola = new Queue<Vozidlo>(KapacitaParkoviska);
            VolnyTechnici = new Queue<Zamestnanec>();
            for (int i = 0; i < 10; i++)
            {
                VolnyTechnici.Enqueue(new Zamestnanec(i + 1, TypZamestnanca.TECHNIK));
            }
            VolnyAutomechanici = new Queue<Zamestnanec>();
            for (int i = 0; i < 10; i++)
            {
                VolnyAutomechanici.Enqueue(new Zamestnanec(i + 1, TypZamestnanca.AUTOMECHANIK));
            }
            VsetciZamestnanci = new List<Zamestnanec>();
            VsetciZamestnanci.AddRange(VolnyTechnici);
            VsetciZamestnanci.AddRange(VolnyAutomechanici);
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerSTK(SimId.ManagerSTK, MySim, this);
			AddOwnMessage(Mc.PrevziatieVozidla);
			AddOwnMessage(Mc.ObsluhaZakaznika);
			AddOwnMessage(Mc.ZaplatenieKontroly);
			AddOwnMessage(Mc.KontrolaVozidla);
		}
		//meta! tag="end"
    }
}