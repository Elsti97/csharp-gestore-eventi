using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Evento
{
    public string titolo;
    public DateTime data;
    private int capienza;
    private int prenotazioni;


    // Vari Get/Set
    public string Titolo
    {
        get { return titolo; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Il titolo non può essere vuoto o nullo");
            }
            titolo = value;
        }
    }

    public DateTime Data
    {
        get { return data; }
        set
        {
            if (value < DateTime.Now)
                throw new ArgumentException("La data non può essere nel passato");
            data = value;
        }
    }

    public int Capienza
    {
        get { return capienza; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("La capienza massima deve essere un numero positivo");
            }
            capienza = value;
        }
    }

    public int Prenotazioni
    {
        get { return prenotazioni; }
        private set 
        {
            prenotazioni = value;
        }
    }


    // COSTRUTTORE
    public Evento(string titolo, DateTime data, int capienza)
    {
        Titolo = titolo;
        Data = data;
        Capienza = capienza;
        Prenotazioni = 0;
    }

    public void PrenotaPosti(int postiDaPrenotare)
    {
        if (DateTime.Now >= Data)
        {
            throw new Exception("L'evento è già passato");
        }
        if (Prenotazioni >= Capienza)
        {
            throw new Exception("L'evento è al completo, non ci sono posti disponibili");
        }
        int postiDisponibili = Capienza - Prenotazioni;
        if (postiDaPrenotare > postiDisponibili)
        {
            throw new Exception($"Sono disponibili solo {postiDisponibili} posti, impossibile prenotarne {postiDaPrenotare}");
        }
        Prenotazioni += postiDaPrenotare;
    }

    public void DisdiciPosti(int postiDaDisdire)
    {
        if (DateTime.Now >= Data)
        {
            throw new Exception("L'evento è già passato");
        }
        if (postiDaDisdire > Prenotazioni)
        {
            throw new Exception($"Non ci sono {postiDaDisdire} posti prenotati, ne sono stati prenotati solo {Prenotazioni}");
        }
        Prenotazioni -= postiDaDisdire;
    }

    public override string ToString()
    {
        return $"{Data.ToString("dd/MM/yyyy")} - {Titolo}";
    }
}

