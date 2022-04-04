Console.WriteLine("Inserisci il Titolo");
string titolo = Console.ReadLine();

Console.WriteLine("Inserisci l'autore");
string autore = Console.ReadLine();

Console.WriteLine("Inserisci l'isbn");
int isbn = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il numero delle pagine");
int numPag = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il peso del libro");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la larghezza del libro");
float largh = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la lunghezza del libro");
double lungh = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la profondita del libro");
double profo = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la valutazione del libro");
double valutazione = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci le recensioni del libro");
int numRecensioni = int.Parse(Console.ReadLine());

Console.WriteLine("E' disponibile la versione Kindle?");
string kindle = Console.ReadLine();

Console.WriteLine("E' disponibile la copertina flessibile?");
string copertina = Console.ReadLine();

Console.WriteLine("----- IL LIBRO DI OGGI: " + titolo + " di " + autore);
Console.WriteLine("ISBN:" + isbn);
Console.WriteLine("Numero delle pagine:" + numPag);
Console.WriteLine("Peso del libro:" + peso);
Console.WriteLine("Dimensioni del libro:" + largh + "cm " + lungh + "cm " + profo + "cm");
Console.WriteLine("Informazioni Amazon:" );
Console.WriteLine("Numero di recensioni:" + numRecensioni);
Console.WriteLine("Valutazione media:" + valutazione);
Console.WriteLine("Kindle disponibile:" + kindle);
Console.WriteLine("Copertina flessibile disponibile:" + copertina);