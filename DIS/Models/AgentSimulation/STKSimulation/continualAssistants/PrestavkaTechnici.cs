using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Models.AgentSimulation.STKSimulation.entities;

namespace DIS.Models.AgentSimulation.STKSimulation.continualAssistants
{
    //meta! id="82"
    public class PrestavkaTechnici : Process
    {
        public PrestavkaTechnici(int id, Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.KoniecPrestavkyTechnici);
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

        //meta! sender="AgentTechnici", id="83", type="Start"
        public void ProcessStart(MessageForm message)
        {
            var sprava = (MyMessage)message;
            sprava.Zamestnanec.Pracuje = Pracuje.PRESTAVKA;
            sprava.Code = Mc.KoniecPrestavkyTechnici;
            Hold(30 * 60, sprava);
        }

        //meta! userInfo="Process messages defined in code", id="0"
        public void ProcessDefault(MessageForm message)
        {
            var sprava = (MyMessage)message;
            switch (message.Code)
            {
                case Mc.KoniecPrestavkyTechnici:
                    sprava.Zamestnanec.Pracuje = Pracuje.NIE;
                    sprava.Zamestnanec.VykonajPrestavku = false;
                    AssistantFinished(sprava);
                    break;
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
        public new AgentTechnici MyAgent
        {
            get
            {
                return (AgentTechnici)base.MyAgent;
            }
        }
    }
}