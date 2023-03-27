using System;
using System.Globalization;

using System;
using System.Collections.Generic;



// Inserimento dati

string nomeProgramma = "";
while (string.IsNullOrEmpty(nomeProgramma))
{
    Console.Write("Inserisci il nome del tuo programma Eventi: ");
    nomeProgramma = Console.ReadLine();
    if (string.IsNullOrEmpty(nomeProgramma))
    {
        Console.WriteLine("Il nome del programma non può essere vuoto. Inserisci nuovamente.");
    }
}

ProgrammaEventi programma = new ProgrammaEventi(nomeProgramma);

int numEventi = 0;
while (numEventi <= 0)
{
    Console.Write("Indica il numero di eventi da inserire: ");
    if (!int.TryParse(Console.ReadLine(), out numEventi) || numEventi <= 0)
    {
        Console.WriteLine("Inserire un numero intero positivo.");
    }
}

// Ciclo per tutti gli eventi
for (int i = 0; i < numEventi; i++)
{
    Console.Write("Inserisci il nome del " + (i + 1) + "° evento: ");
    string nomeEvento = Console.ReadLine();

    Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
    DateTime dataEvento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

    Console.Write("Inserisci il numero di posti totali: ");
    int postiTotali = int.Parse(Console.ReadLine());

    // Crea un nuovo oggetto Evento con i dati inseriti dall'utente
    Evento evento = new Evento(nomeEvento, dataEvento, postiTotali);


    programma.AggiungiEvento(evento);
}

// Stampa il numero di eventi presenti nel programma
Console.WriteLine("Il numero di eventi del programma è: " + programma.NumeroEventi());

// Stampa la lista di eventi inseriti nel programma
Console.WriteLine("Ecco il tuo programma eventi: ");
Console.WriteLine(programma);

// Richiedi all'utente una data e stampa tutti gli eventi in quella data
Console.Write("Inserisci una data per sapere che eventi ci saranno(gg/mm/yyyy): ");
DateTime dataRichiesta = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
List<Evento> eventiInData = programma.EventiInData(dataRichiesta);
if (eventiInData.Count == 0)
{
    Console.WriteLine("Nessun evento trovato in data richiesta.");
}
else
{
    Console.WriteLine(ProgrammaEventi.StampaEventi(eventiInData));
}

//programma.SvuotaEventi();
//Console.WriteLine("Eventi eliminati");


// BONUS
Console.WriteLine("---- BONUS ----");
Console.WriteLine();
Console.WriteLine("Aggiungiamo anche una conferenza!");

// Chiedi all'utente di inserire i dati della conferenza
Console.Write("Inserisci il nome della conferenza: ");
string titolo = Console.ReadLine();

Console.Write("Inserisci la data della conferenza (formato dd/mm/yyyy): ");
DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

Console.Write("Inserisci il numero di posti per la conferenza: ");
int capienza = int.Parse(Console.ReadLine());

Console.Write("Inserisci il relatore della conferenza: ");
string relatore = Console.ReadLine();

Console.Write("Inserisci il prezzo del biglietto della conferenza: ");
double prezzo = double.Parse(Console.ReadLine());

// Crea un oggetto Conferenza con i dati inseriti dall'utente
Conferenza conferenza = new Conferenza(titolo, data, capienza, relatore, prezzo);

// Aggiungi la conferenza alla lista degli eventi
programma.AggiungiEvento(conferenza);
Console.WriteLine();

// Stampa la lista degli eventi
Console.WriteLine("Ecco il tuo programma eventi con anche le Conferenze: ");
Console.WriteLine(programma);




/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//// Dati dell'evento
//Console.Write("Inserisci il nome dell'evento: ");
//string? titolo = Console.ReadLine();
//Console.Write("Inserisci la data dell'evento (formato gg/mm/yyyy): ");
//DateTime data = DateTime.Parse(Console.ReadLine());
//Console.Write("Inserisci il numero di posti totali: ");
//int capienza = int.Parse(Console.ReadLine());

//// Crea l'evento
//Evento evento = new Evento(titolo, data, capienza);

//// Chiedi all'utente di prenotare dei posti
//bool continuaPrenotazioni = true;
//while (continuaPrenotazioni)
//{
//    Console.Write("Quanti posti desideri prenotare? ");
//    int postiDaPrenotare = int.Parse(Console.ReadLine());
//    try
//    {
//        evento.PrenotaPosti(postiDaPrenotare);
//        Console.WriteLine($"Numero di posti prenotati: {evento.Prenotazioni}");
//        Console.WriteLine($"Numero di posti disponibili: {evento.Capienza - evento.Prenotazioni}");
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Errore: {e.Message}");
//    }

//    Console.Write("Vuoi prenotare altri posti (si/no)? ");
//    string? risposta = Console.ReadLine();
//    continuaPrenotazioni = risposta is "si";
//}

//// Chiedi all'utente di disdire dei posti
//bool continuaDisdette = true;
//while (continuaDisdette)
//{
//    Console.Write("Vuoi disdire dei posti (si/no)? ");
//    string? risposta = Console.ReadLine();
//    if (risposta is "si")
//    {
//        Console.Write("Indica il numero di posti da disdire: ");
//        int postiDaDisdire = int.Parse(Console.ReadLine());
//        try
//        {
//            evento.DisdiciPosti(postiDaDisdire);
//            Console.WriteLine($"Numero di posti prenotati: {evento.Prenotazioni}");
//            Console.WriteLine($"Numero di posti disponibili: {evento.Capienza - evento.Prenotazioni}");
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine($"Errore: {e.Message}");
//        }
//    }
//    else
//    {
//        continuaDisdette = false;
//    }
//}

//Console.WriteLine("Ok va bene!");
//Console.WriteLine($"Numero di posti prenotati: {evento.Prenotazioni}");
//Console.WriteLine($"Numero di posti disponibili: {evento.Capienza - evento.Prenotazioni}");
