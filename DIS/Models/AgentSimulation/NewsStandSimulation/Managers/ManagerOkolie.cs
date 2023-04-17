using OSPABA;
using DIS.Models.AgentSimulation.NewsStandSimulation.Agents;
using DIS.Models.AgentSimulation.NewsStandSimulation.Simulation;

namespace DIS.Models.AgentSimulation.NewsStandSimulation.Managers
{
    //meta! id="2"
    public class ManagerOkolie : Manager
    {
        public ManagerOkolie(int id, OSPABA.Simulation mySim, Agent myAgent) :
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

        //meta! sender="PrichodZakaznikov", id="30", type="Finish"
        public void ProcessFinish(MessageForm message)
        {
        }

        //meta! sender="AgentModel", id="9", type="Notice"
        public void ProcessOdchodZakaznika(MessageForm message)
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
                case IdList.Finish:
                    ProcessFinish(message);
                    break;

                case Mc.OdchodZakaznika:
                    ProcessOdchodZakaznika(message);
                    break;

                default:
                    ProcessDefault(message);
                    break;
            }
        }
        //meta! tag="end"
        public new AgentOkolie MyAgent
        {
            get
            {
                return (AgentOkolie)base.MyAgent;
            }
        }
    }
}
