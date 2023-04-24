using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.managers;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;

namespace DIS.Models.AgentSimulation.STKSimulation.agents
{
    //meta! id="34"
    public class AgentPrevziatia : Agent
    {
        public AgentPrevziatia(int id, Simulation mySim, Agent parent) :
            base(id, mySim, parent)
        {
            Init();
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

        //meta! userInfo="Generated code: do not modify", tag="begin"
        private void Init()
        {
            new ManagerPrevziatia(SimId.ManagerPrevziatia, MySim, this);
            new ProcessPrevziatia(SimId.ProcessPrevziatia, MySim, this);
            AddOwnMessage(Mc.PrevziatieVozidla);
        }
        //meta! tag="end"
    }
}
