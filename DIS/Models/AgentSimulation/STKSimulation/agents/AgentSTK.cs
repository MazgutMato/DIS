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
        public bool AktivovatPrestavky { get; set; } = true;
        public AgentSTK(int id, Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
            //Naplanovanie prestavok
            if (AktivovatPrestavky)
            {
                var sprava = new MyMessage(MySim);
                sprava.Addressee = FindAssistant(SimId.PlanovacPrestavky);
                MyManager.StartContinualAssistant(sprava);
            }            
        }

		//meta! userInfo="Generated code: do not modify", tag="begin"
		private void Init()
		{
			new ManagerSTK(SimId.ManagerSTK, MySim, this);
			new PlanovacPrestavky(SimId.PlanovacPrestavky, MySim, this);
			AddOwnMessage(Mc.PrevziatieVozidla);
			AddOwnMessage(Mc.UvolnenieMiesta);
			AddOwnMessage(Mc.ObsluhaZakaznika);
			AddOwnMessage(Mc.ZaplatenieKontroly);
			AddOwnMessage(Mc.KontrolaVozidla);
		}
		//meta! tag="end"
    }
}