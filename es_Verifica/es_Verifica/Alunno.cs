using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_Verifica
{
    class Alunno
    {
        public string Nome { set; get; }
        public string Cognome { set; get; }
        public int Eta { set; get; }

        public Alunno (string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public string CalcoloEta(string nome, string cognome, int eta)
        {
            string anno;
            if (eta < 16)
            {
                 anno = "biennio";
            }else
            {
                 anno = "triennio";
            }

            return anno;
        }

        public override string ToString()
        {
            string anno;
            anno = CalcoloEta(Nome, Cognome, Eta);
            return "L'alunno si chiama " + Nome + " " + Cognome + " ha " + Eta + " anni ed è del " + anno;
        }
    }
}
