namespace DIS.Models.AgentSimulation.STKSimulation.entities
{
    public enum TypZamestnanca
    {
        TECHNIK,
        AUTOMECHANIK,
    }
    public enum Pracuje
    {
        NIE,
        PREBERA,
        KONTROLUJE,
        PLATI,
    }
    public class Zamestnanec
    {
        public int ID { get; }
        public Vozidlo? Vozidlo { get; set; }
        public TypZamestnanca Typ { get; set; }
        public Pracuje Pracuje { get; set; }
        public Zamestnanec(int id, TypZamestnanca typ)
        {
            Vozidlo = null;
            ID = id;
            Typ = typ;
            Pracuje = Pracuje.NIE;
        }        
    }
}
