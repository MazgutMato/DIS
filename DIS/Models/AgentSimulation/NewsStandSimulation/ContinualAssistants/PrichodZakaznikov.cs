using OSPABA;
using DIS.Models.AgentSimulation.NewsStandSimulation.Agents;
using DIS.Models.AgentSimulation.NewsStandSimulation.Simulation;

namespace DIS.Models.AgentSimulation.NewsStandSimulation.ContinualAssistants
{
    //meta! id="29"
    public class PrichodZakaznikov : Scheduler
    {
        public PrichodZakaznikov(int id, OSPABA.Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
        }

        override public void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

        //meta! sender="AgentOkolie", id="30", type="Start"
        public void ProcessStart(MessageForm message)
        {
            message.Code = Mc.ZakaznikPrisiel;
            Hold(((MySimulation)MySim).GeneratorPrichodov.Next(), message);
        }

        //meta! userInfo="Process messages defined in code", id="0"
        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.ZakaznikPrisiel:
                    var copy = message.CreateCopy();
                    Hold(((MySimulation)MySim).GeneratorPrichodov.Next(), message);

                    message.Addressee = MyAgent;
                    message.Code = 
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
        public new AgentOkolie MyAgent
        {
            get
            {
                return (AgentOkolie)base.MyAgent;
            }
        }
    }
}
