using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Risposte
//Domanda 1 - c
//Domanda 2 - Le variabili di tipo string vengono memorizzate nella memoria heap
//perché sono reference Type.
//Domanda 3 - a, b  

namespace EsWeek5
{
    internal class Gestore
    {
      

        public static List<Esame> esami = new List<Esame>()
        {
            new Esame("AlgebraLineare",6),
            new Esame("Fisica3",8),
            new Esame("Relativita",6),
            new Esame("Filosofia",8),
            new Esame("Topologia",10),
            new Esame("Costruzioni",9),
            new Esame("BaseDati",5)

        };
        public static List<Studente> studenti = new List<Studente>()
        {
            new Studente("Mario","Rossi",1980,true),
            new Studente("Luca","Bianchi",1987,true),
            new Studente("Giovanni","Gialli",1999,false),
            new Studente("Carlo","Arancioni",2000,true),

        };
        public static List<CorsoLaurea> listacorsilaurea = new List<CorsoLaurea>()
        {
            new CorsoLaurea((CorsoType)1,4,180),
            new CorsoLaurea((CorsoType)2,2,160),
            new CorsoLaurea((CorsoType)3,6,120),
            new CorsoLaurea((CorsoType)4,3,160),
             new CorsoLaurea((CorsoType)5,4,180)

        };

        public static Studente CercaStudente(string nome, string cognome)
        {
            foreach (var item in studenti)
            {
                if (item.NomeS == nome && item.Cognome == cognome)
                {
                    item.StampaStudente();
                    return item;
                }
            }
            return null;
        }


    }

   
}

