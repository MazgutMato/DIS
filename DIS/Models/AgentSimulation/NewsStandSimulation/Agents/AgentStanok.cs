using OSPABA;
using DIS.Models.AgentSimulation.NewsStandSimulation.Simulation;
using DIS.Models.AgentSimulation.NewsStandSimulation.Managers;
using DIS.Models.AgentSimulation.NewsStandSimulation.ContinualAssistants;

namespace DIS.Models.AgentSimulation.NewsStandSimulation.Agents
{
    //meta! id="3"
    public class AgentStanok : Agent
    {
        public AgentStanok(int id, OSPABA.Simulation mySim, Agent parent) :
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
            new ManagerStanok(SimId.ManagerStanok, MySim, this);
            new Obsluha(SimId.Obsluha, MySim, this);
            AddOwnMessage(Mc.ZaciatokObsluhy);
        }
        //meta! tag="end"
    }
}
