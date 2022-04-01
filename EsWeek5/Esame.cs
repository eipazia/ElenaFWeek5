using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsWeek5
{
    internal class Esame
    {
        public string Nome { get; set; }
        public int CFU { get; set; }

        
        public Esame()
        {
        }
        public Esame(string nome, int cfu)
        {
            Nome = nome;
            CFU = cfu;
        }

       

    }

}
