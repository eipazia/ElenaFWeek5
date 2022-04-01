using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsWeek5
{
    internal class Studente
    {
        public string NomeS { get; set; }
        public string Cognome { get; set; }
        public int AnnoNascita { get; set; }
        public Immatricolazione Immatricolazione { get; set; } = new Immatricolazione();
       
        public bool RichiestaLaurea { get; set; }

        public Studente()
        {
                
        }

        public Studente(string nomes, string cognome,int annonascita,
            //Immatricolazione immatricolazione,
           bool richiestalaurea)
        {
            NomeS = nomes;
            Cognome = cognome;
            AnnoNascita = annonascita;
            //Immatricolazione= immatricolazione;
           
            RichiestaLaurea = richiestalaurea;      
        }


        public void StampaStudente()
        {
            Console.WriteLine($"Lo studente {NomeS} {Cognome} nato il {AnnoNascita} immatricolato {Immatricolazione.AnnoImmatricolazione} " +
                $"ha sostenuto {Immatricolazione.CFUAccumulati}.{RichiestaLaurea}effettuata");
        }

    }
}
