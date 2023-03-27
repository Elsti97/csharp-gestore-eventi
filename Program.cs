using System;
using System.Globalization;




// Dati dell'evento
Console.Write("Inserisci il nome dell'evento: ");
string? titolo = Console.ReadLine();
Console.Write("Inserisci la data dell'evento (formato dd/MM/yyyy): ");
DateTime data = DateTime.Parse(Console.ReadLine());
Console.Write("Inserisci il numero di posti totali: ");
int capienza = int.Parse(Console.ReadLine());

// Crea l'evento
Evento evento = new Evento(titolo, data, capienza);

// Chiedi all'utente di prenotare dei posti
bool continuaPrenotazioni = true;
while (continuaPrenotazioni)
{
    Console.Write("Quanti posti desideri prenotare? ");
    int postiDaPrenotare = int.Parse(Console.ReadLine());
    try
    {
        evento.PrenotaPosti(postiDaPrenotare);
        Console.WriteLine($"Numero di posti prenotati: {evento.Prenotazioni}");
        Console.WriteLine($"Numero di posti disponibili: {evento.Capienza - evento.Prenotazioni}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Errore: {e.Message}");
    }

    Console.Write("Vuoi prenotare altri posti (si/no)? ");
    string? risposta = Console.ReadLine();
    continuaPrenotazioni = risposta is "si";
}

// Chiedi all'utente di disdire dei posti
bool continuaDisdette = true;
while (continuaDisdette)
{
    Console.Write("Vuoi disdire dei posti (si/no)? ");
    string? risposta = Console.ReadLine();
    if (risposta is "si")
    {
        Console.Write("Indica il numero di posti da disdire: ");
        int postiDaDisdire = int.Parse(Console.ReadLine());
        try
        {
            evento.DisdiciPosti(postiDaDisdire);
            Console.WriteLine($"Numero di posti prenotati: {evento.Prenotazioni}");
            Console.WriteLine($"Numero di posti disponibili: {evento.Capienza - evento.Prenotazioni}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Errore: {e.Message}");
        }
    }
    else
    {
        continuaDisdette = false;
    }
}

Console.WriteLine("Ok va bene!");
Console.WriteLine($"Numero di posti prenotati: {evento.Prenotazioni}");
Console.WriteLine($"Numero di posti disponibili: {evento.Capienza - evento.Prenotazioni}");
