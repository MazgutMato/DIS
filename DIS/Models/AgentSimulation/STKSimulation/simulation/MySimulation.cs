using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.SimulationCores.Statistics;

namespace DIS.Models.AgentSimulation.STKSimulation.simulation
{
    public class MySimulation : Simulation
    {
        public NormalStatistic CasVSysteme { get; set; }
        public NormalStatistic CasCakaniaPrevzatie { get; set; }
        public NormalStatistic PocetVozidielVSysteme { get; set; }
        public NormalStatistic PocetVozidielNaKonciDna { get; set; }
        public NormalStatistic DlzkaRadyPrevzatie { get; set; }
        public NormalStatistic VytazenieTechnici { get; set; }
        public NormalStatistic VytazenieAutomechaniciTyp1 { get; set; }
        public NormalStatistic VytazenieAutomechaniciTyp2 { get; set; }
        public MySimulation()
        {
            Init();
        }

        override protected void PrepareSimulation()
        {
            base.PrepareSimulation();
            // Create global statistcis
            CasVSysteme = new NormalStatistic();
            CasCakaniaPrevzatie = new NormalStatistic();
            PocetVozidielNaKonciDna = new NormalStatistic();
            PocetVozidielVSysteme = new NormalStatistic();
            DlzkaRadyPrevzatie = new NormalStatistic();
            VytazenieAutomechaniciTyp1 = new NormalStatistic();
            VytazenieAutomechaniciTyp2 = new NormalStatistic();
            VytazenieTechnici = new NormalStatistic();
        }

        override protected void PrepareReplication()
        {
            base.PrepareReplication();
            // Reset entities, queues, local statistics, etc...
        }

        override protected void ReplicationFinished()
        {
            //Global
            CasVSysteme.AddValue(AgentOkolia.CasVSysteme.GetResult());
            CasCakaniaPrevzatie.AddValue(AgentTechnici.CasCakaniaPrevzatie.GetResult());
            PocetVozidielVSysteme.AddValue(AgentOkolia.VozidlaVSysteme.GetResult());
            PocetVozidielNaKonciDna.AddValue(AgentOkolia.PocetVozidilVSysteme);
            DlzkaRadyPrevzatie.AddValue(AgentTechnici.DlzkaRadyPrevzatie.GetResult());
            VytazenieTechnici.AddValue(AgentTechnici.VytazenostTechnici.GetResult());
            VytazenieAutomechaniciTyp1.AddValue(AgentAutomechanici.VytazenostAutomechanikovTyp1.GetResult());
            VytazenieAutomechaniciTyp2.AddValue(AgentAutomechanici.VytazenostAutomechanikovTyp2.GetResult());
            // Collect local statistics into global, update UI, etc...
            base.ReplicationFinished();
        }

        override protected void SimulationFinished()
        {
            // Dysplay simulation results
            base.SimulationFinished();
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			AgentModelu = new AgentModelu(SimId.AgentModelu, this, null);
			AgentOkolia = new AgentOkolia(SimId.AgentOkolia, this, AgentModelu);
			AgentSTK = new AgentSTK(SimId.AgentSTK, this, AgentModelu);
			AgentAutomechanici = new AgentAutomechanici(SimId.AgentAutomechanici, this, AgentSTK);
			AgentTechnici = new AgentTechnici(SimId.AgentTechnici, this, AgentSTK);
		}
		public AgentModelu AgentModelu
		{ get; set; }
		public AgentOkolia AgentOkolia
		{ get; set; }
		public AgentSTK AgentSTK
		{ get; set; }
		public AgentAutomechanici AgentAutomechanici
		{ get; set; }
		public AgentTechnici AgentTechnici
		{ get; set; }
		//meta! tag="end"
    }
}