using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.managers;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.entities;

namespace DIS.Models.AgentSimulation.STKSimulation.agents
{
    //meta! id="21"
    public class AgentAutomechanici : Agent
    {
        public int PocetAutomechanikov { get; set; } = Config.PocetAutomechanikov;
        public Queue<Zamestnanec> VolniAutomechanici { get; set; }
        public List<Zamestnanec> VsetciAutomechanici { get; set; }
        public Queue<MyMessage> ParkoviskoKontrola { get; set; }
        public int PocetRezervovanychMiest { get; set; }
        public AgentAutomechanici(int id, Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
            PocetRezervovanychMiest = 0;
            ParkoviskoKontrola = new Queue<MyMessage>(Config.KapacitaParkoviskaKontrola);
            ZmenPocetAutomechanikov(PocetAutomechanikov);
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerAutomechanici(SimId.ManagerAutomechanici, MySim, this);
			new PrestavkaAutomechanici(SimId.PrestavkaAutomechanici, MySim, this);
			new ProcessKontroly(SimId.ProcessKontroly, MySim, this);
			AddOwnMessage(Mc.KontrolaVozidla);
			AddOwnMessage(Mc.CasPrestavky);
		}
		//meta! tag="end"
        private void ZmenPocetAutomechanikov(int pocet)
        {
            VolniAutomechanici = new Queue<Zamestnanec>();
            for (int i = 0; i < pocet; i++)
            {
                VolniAutomechanici.Enqueue(new Zamestnanec(i + 1, TypZamestnanca.AUTOMECHANIK));
            }
            VsetciAutomechanici = new List<Zamestnanec>();
            VsetciAutomechanici.AddRange(VolniAutomechanici);
        }
    }
}