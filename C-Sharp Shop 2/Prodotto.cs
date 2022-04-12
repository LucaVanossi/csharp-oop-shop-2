namespace C_Sharp_shop
{
    public class Prodotto
    {
        private int Codice;
        private string Nome;
        private string Descrizione;
        private double Prezzo;
        private double Iva;

        public Prodotto(string Nome, string Descrizione, double Prezzo, double Iva)
        {
            this.Codice = GeneraProdotto();
            this.Nome = Nome;
            this.Descrizione = Descrizione;
            this.Prezzo = Prezzo;
            this.Iva = Iva;
            SetNome();
        }
        private int GeneraProdotto()
        {
            Random NumeroCasuale = new Random();
            return NumeroCasuale.Next(10000000);
        }

        public void SetNome()
        {
            this.Nome = Nome;
        }


        //public string GetNome()
        //{
        //    return Nome;
        //}

        //private string GetDescrizione()
        //{
        //    return Descrizione;
        //}

        //private double GetPrezzo()
        //{
        //    return Prezzo;
        //}

        //private double GetIva()
        //{
        //    return Iva;
        //}

        private double PrezzoSenzaIva()
        {
            return (Prezzo - Iva);

        }

        private string NomeEsteso()
        {
            return (Codice.ToString() + " - " + Nome);
        }

        private string CodiceOtto()
        {
            return Codice.ToString().PadLeft(8, '0');
        }
        public string VisualizzaDati()
        {
            string InfoProdotto = (NomeEsteso() + Environment.NewLine + "Il codice a 8 è: " + CodiceOtto() + Environment.NewLine +
                "Il codice del prodotto è: " + Codice + Environment.NewLine +
                "Il nome del prodotto è: " + Nome + Environment.NewLine + "Descrizione: " + Descrizione
                + Environment.NewLine + "Il Prezzo netto è: " + PrezzoSenzaIva() + Environment.NewLine
                + "Iva: " + Iva + Environment.NewLine + "Prezzo compreso d'Iva: " + Prezzo);
            return InfoProdotto;
        }

        public virtual void StampaProdotto()
        {

            Console.WriteLine("Prodotto acqua");
            Console.WriteLine("Prezzo senza IVA: " + PrezzoSenzaIva());
            Console.WriteLine("Prezzo con IVA: " + Prezzo);
            Console.WriteLine("Descrizione prodotto: " + Descrizione);
            Console.WriteLine("Nome esteso prodotto " + Codice + Nome);
        }



    }
}
