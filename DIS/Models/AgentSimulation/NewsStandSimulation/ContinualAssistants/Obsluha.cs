using OSPABA;
using DIS.Models.AgentSimulation.NewsStandSimulation.Agents;

namespace DIS.Models.AgentSimulation.NewsStandSimulation.ContinualAssistants
{
    //meta! id="33"
    public class Obsluha : Process
    {
        public Obsluha(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

        //meta! sender="AgentStanok", id="34", type="Start"
        public void ProcessStart(MessageForm message)
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
        override public void ProcessMessage(MessageForm message)
        {
            switch (message.Code)
            {
                case IdList.Start:
                    ProcessStart(message);
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
