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
        PRESTAVKA,
    }
    public class Zamestnanec
    {
        public int ID { get; }
        public Vozidlo? Vozidlo { get; set; }
        public TypZamestnanca Typ { get; set; }
        public Pracuje Pracuje { get; set; }
        public bool VykonajPrestavku { get; set; }
        public Zamestnanec(int id, TypZamestnanca typ)
        {
            Vozidlo = null;
            ID = id;
            Typ = typ;
            Pracuje = Pracuje.NIE;
            VykonajPrestavku = false;
        }
        public override string ToString()
        {
            return "ID: " + ID + " Typ: " + Typ + " Pracuje: " + Pracuje;
        }
    }
}
