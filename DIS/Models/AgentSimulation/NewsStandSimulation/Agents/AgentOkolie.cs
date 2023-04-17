using OSPABA;
using DIS.Models.AgentSimulation.NewsStandSimulation.Simulation;
using DIS.Models.AgentSimulation.NewsStandSimulation.Managers;
using DIS.Models.AgentSimulation.NewsStandSimulation.ContinualAssistants;

namespace DIS.Models.AgentSimulation.NewsStandSimulation.Agents
{
    //meta! id="2"
    public class AgentOkolie : Agent
    {
        public AgentOkolie(int id, OSPABA.Simulation mySim, Agent parent) :
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
            new ManagerOkolie(SimId.ManagerOkolie, MySim, this);
            new PrichodZakaznikov(SimId.PrichodZakaznikov, MySim, this);
            AddOwnMessage(Mc.OdchodZakaznika);
        }
        //meta! tag="end"
    }
}
