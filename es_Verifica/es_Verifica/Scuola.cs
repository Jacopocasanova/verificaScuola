using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_Verifica
{
    class Scuola
    {
        public string Nome { set; get; }
        public string Indirizzo { set; get; }
        public string OrarioChiusura { set; get; }
        public string OrarioApertura { set; get; }

        public Scuola ( string nome, string indirizzo, string orarioApertura, string orarioChiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioApertura;
        }
    }
}
