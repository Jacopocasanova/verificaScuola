using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace RECUPERO_1Q2022_CASANOVA
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
   /* A causa di errori che non riesco a capire prof non sono riuscite a finire e almeno spiego brevemente come lo avevo pensato
    *dopo l'inserimento nelle liste con la lettura nel file volevo creare nella classe prodotto restituivo ina tex
    */
    public partial class MainWindow : Window
    {
        List<prodotto> prodotti;
        List<distributore> composizioneDistributore;
        public MainWindow()
        {
           
            InitializeComponent();
            composizioneDistributore = new List<distributore>();
            prodotti = new List<prodotto>();
            RiempiListBoxELista();
            riempiListaProdotti();
        }
        

        public void riempiListaProdotti()
        {
            string codice = "";
            string tipo = "";
            string costo = "";
            string stringaTXT = "";
            
            try
            {
                StreamReader st = new StreamReader("prodotti.txt");
                string[] array = new string[3];
                while (st.EndOfStream == false)
                {
                    stringaTXT = st.ReadLine();
                    array = stringaTXT.Split('|');


                    for (int z = 0; z < array.Length; z++)
                    {
                        if (z == 0)
                        {
                            codice = array[z];
                        }
                        if (z == 1)
                        {
                            tipo = array[z];
                        }
                        if (z == 2)
                        {
                            costo = array[z];
                        }

                       

                    }
                    prodotto p = new prodotto(codice, tipo, int.Parse(costo));
                    prodotti.Add(p);

                }

              
               
                st.Close();
            }catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
           
                
            

        }
        public void RiempiListBoxELista()
        {
            string codice = "";
            string scomparto = "";
            string nProdotti = "";
            string stringaTXT = "";
            try
            {
                StreamReader st = new StreamReader("configurazione.txt");
                string[] array = new string[3];

                while (st.EndOfStream == false)
                {
                    stringaTXT = st.ReadLine();


                    array = stringaTXT.Split('|');
                    for (int z = 0; z < array.Length; z++)
                    {
                        if (z == 0)
                        {
                            scomparto = array[z];
                        }
                        if (z == 1)
                        {
                            codice = array[z];
                        }
                        if (z == 2)
                        {
                            nProdotti = array[z];
                        }
                    }


                    distributore d = new distributore(scomparto, codice, int.Parse(nProdotti));
                    composizioneDistributore.Add(d);

                    lstDistributore.Items.Add(scomparto + " " + codice + " " + nProdotti);


                  
                }
               

                st.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
           
            


        }

        private void btnInerisci_Click(object sender, RoutedEventArgs e)
        {
            string prodottoChiesto = txtCodice.Text;
            string tipo = "";
            int costo = 0;
            prodotto p = new prodotto(prodottoChiesto, tipo, costo);
            string messaggio = p.ProdottoRichiesto(prodottoChiesto, prodotti); ;
           
            txtPRisultato.Text = messaggio;
                

        }

     
    }
}
