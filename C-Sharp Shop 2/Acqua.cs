using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_shop
{
    public class Acqua : Prodotto
    {
        private double litri;
        private readonly double ph;
        private string sorgente;
        public static readonly double massimaDimensioneBottiglia = 1.5;
        public static readonly double convgallone = 3.785;

        public Acqua(string nome, string descrizione, double prezzo, double iva, double litri, double ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
            CalcoloDimensioneBottiglia();
        }

        public void CalcoloDimensioneBottiglia()
        {
            if (litri <= massimaDimensioneBottiglia)
            {
                Console.WriteLine("Bottiglia litri: " + litri);
            }
            else
            {
                Console.WriteLine("Attenzione bottiglia con acqua maggiore di 1.5 litri ");
            }
        }
        public void Bevi(double litridabere)
        { 
            if (this.litri - litridabere > 0)
            {
                this.litri -= litridabere;
                Console.WriteLine("bevuti " + litridabere);
            }
            else
            {
                Console.WriteLine("non c'e' piu' acqua ");
                this.litri = 0;
            }
        }

        public void Svuota ()
        {
            this.litri = 0;
            Console.WriteLine("Hai svuotato la bottiglia!");
        }

        public static void ConvertiInGalloni (double litriGalloni)
        {
            double GalloniDaConv = litriGalloni * convgallone;

            GalloniDaConv = Math.Round(GalloniDaConv, 3);

            Console.WriteLine("Conversione litri in Galloni: " + GalloniDaConv); 
        }

        public void Riempi (double litriRiempimento)
        {
            if (this.litri + litriRiempimento <= massimaDimensioneBottiglia)
            {
                this.litri += litriRiempimento;
                Console.WriteLine("Hai riempito la bottiglia con: " + litriRiempimento);
            }
            else
                Console.WriteLine("La bottiglia è già piena");
                this.litri = massimaDimensioneBottiglia;
        }

        public override void StampaProdotto()
        {

            if (litri <= massimaDimensioneBottiglia)
            {
                base.StampaProdotto();
                Console.WriteLine("Litri: " + litri);
                Console.WriteLine("Ph: " + ph);
                Console.WriteLine("Sorgente: " + sorgente);
            }
            else
            {
                Console.WriteLine("Capacita' prodotto errata - maggiore di " + massimaDimensioneBottiglia);
            }
        }

    }
}
