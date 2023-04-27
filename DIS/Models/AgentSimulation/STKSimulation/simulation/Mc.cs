using OSPABA;

namespace DIS.Models.AgentSimulation.STKSimulation.simulation
{
    public class Mc : IdList
    {
		//meta! userInfo="Generated code: do not modify", tag="begin"
		public const int ZaplatenieKontroly = 1010;
		public const int PrichodZakaznika = 1002;
		public const int OdchodZakaznika = 1003;
		public const int UvolnenieMiesta = 1014;
		public const int NovyZakaznik = 1005;
		public const int CasPrestavky = 1017;
		public const int ObsluhaZakaznika = 1006;
		public const int PrevziatieVozidla = 1007;
		public const int KontrolaVozidla = 1008;
		//meta! tag="end"

		// 1..1000 range reserved for user

		public const int KoniecPrevziatia = 1;
		public const int KoniecKontroly = 2;
		public const int KoniecPlatenia = 3;

		public const int ZaciatokPrestavok = 4;
		public const int KoniecPrestavkyTechnici  = 5;
        public const int KoniecPrestavkyAutomechanici = 6;
    }
}