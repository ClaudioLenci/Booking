﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Calendario
    {
        public List<Prenotazione> prenotazioni { get; }
        public int min;
        public int max;

        public Calendario(int min, int max)
        {
            prenotazioni = new List<Prenotazione>();
            this.min = min;
            this.max = max;
        }

        public List<Prenotazione> GetPrenotazioni()
        {
            return prenotazioni.OrderBy(p => p.inizio).ToList();
        }

        public List<Prenotazione> GetPrenotazioniFuture()
        {
            return prenotazioni.OrderBy(p => p.inizio).Where(p => p.inizio >= DateTime.Now).ToList();
        }

        public bool Libero(Prenotazione p)
        {
            return prenotazioni.Any(p2 => (p2.inizio > p.inizio && p2.inizio < p.fine) || (p2.fine > p.inizio && p2.fine < p.fine));
        }

        public bool Exists(int id)
        {
            return prenotazioni.Any(p => p.id == id);
        }

        public void AddPrenotazione(string nome, DateTime data_nascita, string tipologia, DateTime inizio, int durata, string altro)
        {
            prenotazioni.Add(new Prenotazione(prenotazioni.Count, nome, data_nascita, tipologia, inizio, durata, altro));
        }

        public void RemovePrenotazione(int id)
        {
            var p = prenotazioni.Find(p2 => p2.id == id);
            if(p != null)
            {
                prenotazioni.Remove(p);
            }
        }
    }
}
