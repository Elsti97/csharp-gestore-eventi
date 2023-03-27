using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Conferenza : Evento
{
    // Attributi
    public string? relatore;
    public double prezzo;


    // Costruttore che richiama costruttore Evento
    public Conferenza(string titolo, DateTime data, int capienza, string relatore, double prezzo)
        : base(titolo, data, capienza)
    {
        Relatore = relatore;
        Prezzo = prezzo;
    }


    // Vari Get/Set
    public string? Relatore
    {
        get { return relatore; }
        set { relatore = value; }
    }

    public double Prezzo
    {
        get { return prezzo; }
        set { prezzo = value; }
    }


    // Metodo per Prezzo formattato
    public string PrezzoFormattato()
    {
        return prezzo.ToString("0.00") + " euro";
    }
}


