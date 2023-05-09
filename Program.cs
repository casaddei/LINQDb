// See https://aka.ms/new-console-template for more information
using SQLite;

Console.WriteLine("Hello, DBWorld!");
// 27.4.2023
// connessione al db 
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtist = cn1.Query<Artist>( "select * from artists" );
Console.WriteLine( $" In questa tabella ci sono {tblArtist.Count} record!");

// Langugage INtegrate Query permette di fare query all'interno del codice c#
// LINQ

// 4.5.2023
/*int x=0;
Artist[] vettore = new Artist[tblArtist.Count];
while(x<tblArtist.Count)
{
    vettore[x] = tblArtist[x].Name;
    x++;
}
*/
var temporanea = tblArtist.OrderByDescending(x => x.Name).Max(y=>y.ArtistId); // il max fa da solo un foreach su tutti gli elementi 
// sintassi LINQ ogni volta che usi un metodo si cera un oggetto su cui si può usare una latro metodo e andare avanti all'infinito
// sia applica all'intero oggetto lo stesso metodo; quando c'è => è una lambda expression;
foreach (var artista in tblArtist)                       // foreach che passa tutti i record e poi stampa tutti i nomi degli artisti 
{
    Console.WriteLine($"{artista.Name}");
}
Console.WriteLine(temporanea);
// ----------------------
// fine del main inzio delle dichiarazioni 
public class Artist
{
    public int ArtistId{get;set;}
    public string Name{get;set;}
}
