using csharp_oop_shop;

Console.WriteLine("Inserisci IVA: ");
int inputIva = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci nome prodotto: ");
string nomeProdotto = Console.ReadLine();

Console.WriteLine("Inserisci descrizione prodotto: ");
string descrizioneProdotto = Console.ReadLine();

Console.WriteLine("Inserisci prezzo prodotto: ");
double prezzoProdotto = double.Parse(Console.ReadLine());


Prodotto primoProdotto = new Prodotto(nomeProdotto, descrizioneProdotto, prezzoProdotto, inputIva);

Console.WriteLine("- - PRODOTTO N.1 - -");
Console.WriteLine();
primoProdotto.StampaProdottiSenzaIva();
Console.WriteLine(" ");
primoProdotto.StampaProdottiConIva();
Console.WriteLine(" ");
primoProdotto.StampaProdottiConcatenati();
Console.WriteLine();

Prodotto SecondoProdotto = new Prodotto("Tastiera", "Tastiera RGB Logitech", 59.99, 22);

Console.WriteLine("- - PRODOTTO N.2 - -");
Console.WriteLine();
SecondoProdotto.StampaProdottiSenzaIva();
Console.WriteLine(" ");
SecondoProdotto.StampaProdottiConIva();
Console.WriteLine(" ");
SecondoProdotto.StampaProdottiConcatenati();
Console.WriteLine();

Prodotto TerzoProdotto = new Prodotto("Delice", "Merendine Kinder", 3.29, 10);

Console.WriteLine("- - PRODOTTO N.3 - -");
Console.WriteLine();
TerzoProdotto.StampaProdottiSenzaIva();
Console.WriteLine(" ");
TerzoProdotto.StampaProdottiConIva();
Console.WriteLine(" ");
TerzoProdotto.StampaProdottiConcatenati();