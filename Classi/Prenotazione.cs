using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Prenotazione
    {
        public string nome { get; set; }
        public DateTime data_nascita { get; set; }
        public string tipologia { get; set; }
        public DateTime inizio { get; set; }
        public int durata { get; set; }
        public string altro { get; set; }

        public DateTime fine
        {
            get
            {
                DateTime fine = inizio;
                fine.AddHours(durata);
                return fine;
            }
        }

        public Prenotazione(string nome, DateTime data_nascita, string tipologia, DateTime inizio, int durata, string altro)
        {
            this.nome = nome;
            this.data_nascita = data_nascita;
            this.tipologia = tipologia;
            this.inizio = inizio;
            this.durata = durata;
            this.altro = altro;
        }
    }
}
