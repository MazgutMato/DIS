using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.AgentSimulation.STKSimulation.entities
{
    public class Vozidlo
    {
        public int ID { get; }
        public double CasPrichodu { get; set; }
        public TypVozidla TypVozidla { get; set; }
        public Vozidlo(int id, TypVozidla typVozidla, double casPrichodu)
        {
            ID = id;
            TypVozidla = typVozidla;
            CasPrichodu = casPrichodu;
        }
        public Vozidlo(int id, double casPrichodu)
        {
            ID = id;
            TypVozidla = TypVozidla.ZIADNY;
            CasPrichodu = casPrichodu;
        }
        public override string ToString()
        {
            return "ID: " + ID + " Typ: " + TypVozidla;
        }
    }

    public enum TypVozidla
    {
        ZIADNY = 0,
        OSOBNE = 1,
        DODAVKA = 2,
        NAKLADNE = 3,
    }
}
