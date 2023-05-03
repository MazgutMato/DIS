using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.entities;
using DIS.Models.AgentSimulation.STKSimulation.managers;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.SimulationCores.Statistics;
using OSPABA;

namespace DIS.Models.AgentSimulation.STKSimulation.agents
{
    //meta! id="21"
    public class AgentAutomechanici : Agent
    {        
        public WeightStatistic VytazenostAutomechanikov { get; set; }
        public int PocetAutomechanikovTyp1 { get; set; } = Config.PocetAutomechanikovTyp1;
        public Queue<Zamestnanec> VolniAutomechaniciTyp1 { get; set; }
        public int PocetAutomechanikovTyp2 { get; set; } = Config.PocetAutomechanikovTyp2;
        public Queue<Zamestnanec> VolniAutomechaniciTyp2 { get; set; }
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
            ZmenPocetAutomechanikov(PocetAutomechanikovTyp1, PocetAutomechanikovTyp2);
            //Stat
            VytazenostAutomechanikov = new WeightStatistic(MySim);
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
        private void ZmenPocetAutomechanikov(int pocetTyp1, int pocetTyp2)
        {
            //Vsetci
            VsetciAutomechanici = new List<Zamestnanec>();
            //Typ1
            VolniAutomechaniciTyp1 = new Queue<Zamestnanec>();
            for (int i = 0; i < pocetTyp1; i++)
            {
                VolniAutomechaniciTyp1.Enqueue(new Zamestnanec(i + 1, TypZamestnanca.AUTOMECHANIK_TYP_1));
            }
            VsetciAutomechanici.AddRange(VolniAutomechaniciTyp1);
            //Typ2
            VolniAutomechaniciTyp2 = new Queue<Zamestnanec>();
            for (int i = 0; i < pocetTyp2; i++)
            {
                VolniAutomechaniciTyp2.Enqueue(new Zamestnanec(pocetTyp1 + i + 1, TypZamestnanca.AUTOMECHANIK_TYP_2));
            }
            VsetciAutomechanici.AddRange(VolniAutomechaniciTyp2);
        }
    }
}