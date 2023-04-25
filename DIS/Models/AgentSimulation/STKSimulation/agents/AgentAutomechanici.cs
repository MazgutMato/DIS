using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.managers;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.entities;
using DIS.Models.AgentSimulation.STKSimulation.instantAssistants;

namespace DIS.Models.AgentSimulation.STKSimulation.agents
{
    //meta! id="21"
    public class AgentAutomechanici : Agent
    {
        public Queue<Zamestnanec> VolniAutomechanici { get; set; }
        public List<Zamestnanec> VsetciAutomechanici { get; set; }
        public Queue<Vozidlo> ParkoviskoKontrola { get; set; }
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
            ParkoviskoKontrola = new Queue<Vozidlo>(Config.KapacitaParkoviskaKontrola);
            ZmenPocetAutomechanikov(Config.PocetAutomechanikov);
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerAutomechanici(SimId.ManagerAutomechanici, MySim, this);
			new JeVolneMiesto(SimId.JeVolneMiesto, MySim, this);
			new ProcessKontroly(SimId.ProcessKontroly, MySim, this);
			AddOwnMessage(Mc.RezervujMiesto);
			AddOwnMessage(Mc.KontrolaVozidla);
		}
		//meta! tag="end"
        public void ZmenPocetAutomechanikov(int pocet)
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