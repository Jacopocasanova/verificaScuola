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
        public string Eta { set; get; }

        public Alunno (string nome, string cognome, string eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

    }
}
