using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsWeek5
{
    internal class Immatricolazione
    {
        public int IdMatricola { get; set; }
        public int AnnoImmatricolazione { get; set; }
        public CorsoLaurea CorsoLaurea { get; set; } = new CorsoLaurea();
        public bool InCorso { get; set; }
        public int CFUAccumulati { get; set; }

        public Immatricolazione()
        {
                
        }

        public Immatricolazione(int idmatricola, int annoimmatricolazione, CorsoLaurea corsolaurea, bool incorso, int cfuaccumulati)
        {
            IdMatricola = idmatricola;
            AnnoImmatricolazione = annoimmatricolazione;
            CorsoLaurea = corsolaurea;
            InCorso = incorso;
            CFUAccumulati = cfuaccumulati;
        }
    }
}
