using OSPABA;
using DIS.Models.AgentSimulation.NewsStandSimulation.Simulation;
using DIS.Models.AgentSimulation.NewsStandSimulation.Managers;

namespace DIS.Models.AgentSimulation.NewsStandSimulation.Agents
{
    //meta! id="1"
    public class AgentModel : Agent
    {
        public AgentModel(int id, OSPABA.Simulation mySim, Agent parent) :
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
            new ManagerModel(SimId.ManagerModel, MySim, this);
            AddOwnMessage(Mc.PrichodZakaznika);
            AddOwnMessage(Mc.KoniecObsluhy);
        }
        //meta! tag="end"
    }
}
