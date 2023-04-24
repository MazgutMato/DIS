using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.continualAssistants;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="24"
    public class ManagerPlatenia : Manager
    {
        public ManagerPlatenia(int id, Simulation mySim, Agent myAgent) :
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

        //meta! sender="ProcessPlatenia", id="45", type="Finish"
        public void ProcessFinish(MessageForm message)
        {
        }

        //meta! sender="AgentSTK", id="48", type="Request"
        public void ProcessZaplatenieKontroly(MessageForm message)
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
                case Mc.ZaplatenieKontroly:
                    ProcessZaplatenieKontroly(message);
                    break;

                case Mc.Finish:
                    ProcessFinish(message);
                    break;

                default:
                    ProcessDefault(message);
                    break;
            }
        }
        //meta! tag="end"
        public new AgentPlatenia MyAgent
        {
            get
            {
                return (AgentPlatenia)base.MyAgent;
            }
        }
    }
}
