using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ProgrammaEventi
{
    // Attributi
    public string Titolo;
    private List<Evento> eventi;


    // Costruttore
    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        eventi = new List<Evento>();
    }


    // Metodo aggiunta evento
    public void AggiungiEvento(Evento evento)
    {
        eventi.Add(evento);
    }


    // Metodo lista eventi
    public List<Evento> EventiInData(DateTime data)
    {
        return eventi.Where(evento => evento.Data == data).ToList();
    }


    // Metodo per stampare lista eventi
    public static string StampaEventi(List<Evento> eventi)
    {
        string output = "";
        foreach (Evento evento in eventi)
        {
            output += evento.Data.ToString("dd/MM/yyyy") + " - " + evento.Titolo + "\n";
        }
        return output;
    }


    // Metodo totale eventi
    public int NumeroEventi()
    {
        return eventi.Count;
    }


    // Metodo per svuotare la lista eventi
    public void SvuotaEventi()
    {
        eventi.Clear();
    }

    public override string ToString()
    {
        string output = Titolo + "\n";

        foreach (Evento evento in eventi)
        {
            output += evento.Data.ToString("dd/MM/yyyy") + "-" + evento.Titolo + "\n";
        }

        return output;
    }
}