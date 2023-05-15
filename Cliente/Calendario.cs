using System;
using System.Collections.Generic;
using System.Linq;

namespace Cliente
{
    public class Calendario
    {
        public List<Prenotazione> prenotazioni { get; }

        public Calendario()
        {
            prenotazioni = new List<Prenotazione>();
        }

        public List<Prenotazione> GetPrenotazioni()
        {
            return prenotazioni.OrderBy(p => p.inizio).ToList();
        }

        public List<Prenotazione> GetPrenotazioniFuture()
        {
            return prenotazioni.OrderBy(p => p.inizio).Where(p => p.inizio >= DateTime.Now).ToList();
        }

        bool Libero(Prenotazione p)
        {
            int n = prenotazioni.Count(p2 => (p2.inizio > p.inizio && p2.inizio < p.fine) || (p2.fine > p.inizio && p2.fine < p.fine));
            return n == 0;
        }
    }
}
