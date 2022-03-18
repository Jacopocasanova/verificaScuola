using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECUPERO_1Q2022_CASANOVA
{
    class prodotto
    {
       
        public string Codice { set; get; }
        public string Tipo { set; get; }
        public int Costo { set; get; }
        public prodotto (string codice,string tipo, int costo) 
        {
           
            Codice = codice;
            Tipo = tipo;
            Costo = costo;

        }

        public string ProdottoRichiesto(string codice1,List<prodotto> prodotti)
        {
            string tipo1 = "";
            int i = 0;
            int costo2 = 0;
            foreach (prodotto p in prodotti)
            {

                if (codice1 == p.ToString())
                {
                    tipo1 = prodotti[i + 1].ToString();
                    string costo1 = prodotti[i + 2].ToString();
                    costo2 = int.Parse(costo1);
                }

            }

            return "il prodotto selezionato è " + tipo1 + " e costa " + costo2;
        }


    }
}
