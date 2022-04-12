// See https://aka.ms/new-console-template for more information

using C_Sharp_shop;

Prodotto Moto = new Prodotto("Honda", "ADV 350", 6990, 1537.80);

Console.WriteLine(Moto.VisualizzaDati());

Console.ReadKey();
Console.Clear();

Acqua bottiglia = new Acqua("Acqua", "Minerale", 2.50, 0.2, 1.5, 7.5, "Sorgente");

bottiglia.StampaProdotto();

bottiglia.Bevi(1.5);

bottiglia.Svuota();

bottiglia.Riempi(0.5);

Acqua.ConvertiInGalloni(1.5);







