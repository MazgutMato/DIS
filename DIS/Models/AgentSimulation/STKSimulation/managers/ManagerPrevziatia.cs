using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="34"
    public class ManagerPrevziatia : Manager
    {
        public ManagerPrevziatia(int id, Simulation mySim, Agent myAgent) :
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

        //meta! sender="AgentSTK", id="46", type="Request"
        public void ProcessPrevziatieVozidla(MessageForm message)
        {
        }

        //meta! sender="ProcessPrevziatia", id="39", type="Finish"
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
                case Mc.PrevziatieVozidla:
                    ProcessPrevziatieVozidla(message);
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
        public new AgentPrevziatia MyAgent
        {
            get
            {
                return (AgentPrevziatia)base.MyAgent;
            }
        }
    }
}
