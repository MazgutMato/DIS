using OSPABA;
using simulation;
using agents;

namespace DIS.Models.AgentSimulation.STKSimulation.instantAssistants
{
    //meta! id="68"
    public class JeVolneMiesto : Query
    {
        public JeVolneMiesto(int id, Simulation mySim, CommonAgent myAgent) :
            base(id, mySim, myAgent)
        {
        }

        override public void Execute(MessageForm message)
        {
        }
        public new AgentAutomechanici MyAgent
        {
            get
            {
                return (AgentAutomechanici)base.MyAgent;
            }
        }
    }
}
