using OSPABA;
using DIS.Models.AgentSimulation.NewsStandSimulation.Agents;
using DIS.Models.AgentSimulation.NewsStandSimulation.Simulation;

namespace DIS.Models.AgentSimulation.NewsStandSimulation.Managers
{
    //meta! id="3"
    public class ManagerStanok : Manager
    {
        public ManagerStanok(int id, OSPABA.Simulation mySim, Agent myAgent) :
            base(id, mySim, myAgent)
        {
            Init();
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication

            if (PetriNet != null)
            {
                PetriNet.Clear();
            }
        }

        //meta! sender="AgentModel", id="10", type="Notice"
        public void ProcessZaciatokObsluhy(MessageForm message)
        {
        }

        //meta! sender="Obsluha", id="34", type="Finish"
        public void ProcessFinish(MessageForm message)
        {
        }

        //meta! userInfo="Process messages defined in code", id="0"
        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
            }
        }

        //meta! userInfo="Generated code: do not modify", tag="begin"
        public void Init()
        {
        }

        override public void ProcessMessage(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.ZaciatokObsluhy:
                    ProcessZaciatokObsluhy(message);
                    break;

                case IdList.Finish:
                    ProcessFinish(message);
                    break;

                default:
                    ProcessDefault(message);
                    break;
            }
        }
        //meta! tag="end"
        public new AgentStanok MyAgent
        {
            get
            {
                return (AgentStanok)base.MyAgent;
            }
        }
    }
}
