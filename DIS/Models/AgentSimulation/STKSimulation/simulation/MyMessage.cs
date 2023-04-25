using DIS.Models.AgentSimulation.STKSimulation.entities;
using OSPABA;

namespace DIS.Models.AgentSimulation.STKSimulation.simulation
{
    public class MyMessage : MessageForm
    {
        public Vozidlo? Vozidlo { get; set; }
        public Zamestnanec? Zamestnanec { get; set; }
        public MyMessage(Simulation sim) :
            base(sim)
        {
            Vozidlo = null;
            Zamestnanec = null;
        }

        public MyMessage(MyMessage original) :
            base(original)
        {
            // copy() is called in superclass
        }

        override public MessageForm CreateCopy()
        {
            return new MyMessage(this);
        }

        override protected void Copy(MessageForm message)
        {
            base.Copy(message);
            MyMessage original = (MyMessage)message;
            // Copy attributes

            Vozidlo = original.Vozidlo;
            Zamestnanec = original.Zamestnanec;
        }
    }
}