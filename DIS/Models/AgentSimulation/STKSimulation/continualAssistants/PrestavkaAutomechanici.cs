using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;
using DIS.Models.AgentSimulation.STKSimulation.entities;

namespace DIS.Models.AgentSimulation.STKSimulation.continualAssistants
{
    //meta! id="87"
    public class PrestavkaAutomechanici : Process
    {
        public PrestavkaAutomechanici(int id, Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.KoniecPrestavkyAutomechanici);
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

        //meta! userInfo="Process messages defined in code", id="0"
        public void ProcessDefault(MessageForm message)
        {
            var sprava = (MyMessage)message;
            switch (message.Code)
            {
                case Mc.KoniecPrestavkyAutomechanici:
                    sprava.Zamestnanec.Pracuje = Pracuje.NIE;
                    sprava.Zamestnanec.VykonajPrestavku = false;
                    AssistantFinished(sprava);
                    break;
            }
        }

        //meta! sender="AgentAutomechanici", id="86", type="Start"
        public void ProcessStart(MessageForm message)
        {
            var sprava = (MyMessage)message;
            sprava.Zamestnanec.Pracuje = Pracuje.PRESTAVKA;
            sprava.Code = Mc.KoniecPrestavkyAutomechanici;
            Hold(30 * 60, sprava);
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
        public new AgentAutomechanici MyAgent
        {
            get
            {
                return (AgentAutomechanici)base.MyAgent;
            }
        }
    }
}