// See https://aka.ms/new-console-template for more information

/*In questo esercizio vogliamo inserire in maniera “hardcoded” (ossia scritte nel codice senza dover chiedere all’utente nessun input) 
 * tutte le informazioni che troviamo su Amazon di un libro (per esempio "Clean Code") per poi stamparne una piccola sintesi fatta bene.
Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
- Titolo
- Autore
- ISBN
- Numero pagine
- Peso del libro
- Larghezza, Altezza e Profondità del libro
- Valutazione media
- Numero di recensioni
- se è disponibile in versione Kindle
- se la copertina flessibile è disponibile
Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
A questo punto stampiamo bene le informazioni acquisite sulla console, dove per <<nomeVariabile>> indica di stampare l’informazione contenuta nella variabile.
Un esempio è il seguente:
——— IL LIBRO DI OGGI: <<titolo>> di <<autore>>——————-
Informazioni generiche:
ISBN: <<isbn>>
Numero delle pagine: <<numeroPagine>> pagine
Peso del libro: <<pesoLibro>> kg
Dimensioni del libro: <<larghezza>> cm x <<lunghezza>> cm x <<profondita>> cm
Informazioni Amazon:
Numero di recensioni: <<numeroRecensioni>> recensioni
Valutazione media: <<valutazioneMedia>> stelline
Kindle disponibile: Si o No
Copertina flessibile disponibile: Si o No*/

string titolo = "Clean Code A Handbook of Agile Software Craftsmanship";
string autore = "Robert C. Martin";
Int64 isbn = 9780132350884;
int numPag = 431;
int peso = 660;
double larg = 17.91;
double lungh = 2.54;
double profo = 23.5;
double valutazione = 4.7;
int numRecensioni = 3308;
string kindle = "si";
string copertina = "si";


Console.WriteLine("----- IL LIBRO DI OGGI: " +titolo +" di "+autore);
Console.WriteLine("ISBN:" + isbn);
Console.WriteLine("Numero delle pagine:" + numPag);
Console.WriteLine("Peso del libro:" + peso);
Console.WriteLine("Dimensioni del libro:" +larg +"cm " +lungh + "cm " +profo + "cm" );
Console.WriteLine("Informazioni Amazon:" + peso);
Console.WriteLine("Numero di recensioni:" +numRecensioni);
Console.WriteLine("Valutazione media:" + valutazione);
Console.WriteLine("Kindle disponibile:" +kindle);
Console.WriteLine("Copertina flessibile disponibile:" + copertina);