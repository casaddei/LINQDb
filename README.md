# LINKDb
Aprire attraverso visual studio code la cartella creata sul desktop, avviare un nuovo terminale e creare un progetto c# attraverso il comando dotnet new console. 
A questo punto si può iniziare a lavorare sul progetto.

In questo programma ci occupiamo dell'ordinamento dei dati di un Db attraverso il linguaggio Linq(Langugage INtegrate Query); linguaggio che permette di inserire delle query all'interno del codice c#.
Per scaricare un Db di prova ci siamo recati sul seguente link: www.sqlitetutorial.net/wp-content/uploads/2018/03/chinook.zip

Dopo aver aggiunto il file del Db alla cartella, si esegue il collegamento tramite questa sintassi:
###
    SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
###
A questo punto dobbiamo aggiungere le librerie per usare sql; per prima cosa sul terminale aggiungiamo i pacchetti tramite add package sqlite-net-pcl e poi aggiungiamo nel program.cs la libreria using SQlite.
###
    var temporanea = tblArtist.OrderByDescending(x => x.Name).Max(y=>y.ArtistId)  // lambda expression 
###
Questa query integra C# e Linq e serve per ordinare gli artisti in ordine di ArtistId e Name. Il Max va a generare in automatico un ciclo foreach che confronta tutti gli artisti.
###
    foreach (var artista in tblArtist)  // foreach che passa tutti i record e poi stampa tutti i nomi degli artisti 
    {
        Console.WriteLine($"{artista.Name}");
    }
    Console.WriteLine(temporanea);
###
In queste righe di codice il foreach scorre tutti i record della tabella e scrive i nome degli artisti presenti nella tabella.
A fine ciclo stamperà il valore contenuto in temporanea.
