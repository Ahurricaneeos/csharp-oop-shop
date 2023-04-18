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