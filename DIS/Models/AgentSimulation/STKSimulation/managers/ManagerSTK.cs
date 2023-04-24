using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.agents;

namespace DIS.Models.AgentSimulation.STKSimulation.managers
{
    //meta! id="17"
    public class ManagerSTK : Manager
    {
        public ManagerSTK(int id, Simulation mySim, Agent myAgent) :
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

        //meta! sender="AgentPrevziatia", id="46", type="Response"
        public void ProcessPrevziatieVozidla(MessageForm message)
        {
        }

        //meta! sender="AgentModelu", id="22", type="Request"
        public void ProcessObsluhaZakaznika(MessageForm message)
        {
            var sprava = (MyMessage)message;
            if(MyAgent.VolnyTechnici.Count > 0)
            {
                if(MyAgent.CakajucePlatba.Count > 0)
                {

                }
                else
                {

                }
            }
            else
            {
                MyAgent.CakajucePrevziate.Enqueue(sprava.Vozidlo);
            }
        }

        //meta! sender="AgentPlatenia", id="48", type="Response"
        public void ProcessZaplatenieKontroly(MessageForm message)
        {
        }

        //meta! sender="AgentKontroly", id="47", type="Response"
        public void ProcessKontrolaVozidla(MessageForm message)
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
                case Mc.ObsluhaZakaznika:
                    ProcessObsluhaZakaznika(message);
                    break;

                case Mc.PrevziatieVozidla:
                    ProcessPrevziatieVozidla(message);
                    break;

                case Mc.KontrolaVozidla:
                    ProcessKontrolaVozidla(message);
                    break;

                case Mc.ZaplatenieKontroly:
                    ProcessZaplatenieKontroly(message);
                    break;

                default:
                    ProcessDefault(message);
                    break;
            }
        }
        //meta! tag="end"
        public new AgentSTK MyAgent
        {
            get
            {
                return (AgentSTK)base.MyAgent;
            }
        }
    }
}
