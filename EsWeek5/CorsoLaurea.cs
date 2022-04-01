using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsWeek5
{
    internal class CorsoLaurea
    {
        public CorsoType Type { get; set; }
        public int AnniCorso { get; set; }
        public int CFUTotali { get; set; }

        public Esame Esame { get; set; } = new Esame();


        public CorsoLaurea()
        {
                
        }
        public CorsoLaurea(CorsoType type, int annicorso, int cfutotali)
            //Esame esame )
        {
            Type = type;
            AnniCorso = annicorso;  
            CFUTotali = cfutotali;
            //Esame = esame;
        }

       
        public void StampaCDL()
        {
            Console.WriteLine($"Il corso di laurea {Type} prevede {AnniCorso}anni di corso e {CFUTotali} cfu");
        }
    }
    public enum CorsoType
    {
        Matematica = 1,
        Informatica = 2,
        Lettere = 3,
        Fisica = 4,
        Ingegneria = 5
    }
}
