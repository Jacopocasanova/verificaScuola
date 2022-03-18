using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECUPERO_1Q2022_CASANOVA
{
    class distributore
    {
        public string Scompartimento { set; get; }
        public string Codice { set; get; }
        public int QuantitaProdotti { set; get; }
        public distributore(string scompartimento, string codice, int quantitAProdotti)
        {
            Scompartimento = scompartimento;
            Codice = codice;
            QuantitaProdotti = quantitAProdotti;
        }
    }
}
