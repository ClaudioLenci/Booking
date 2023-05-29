using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Prenotazione
    {
        public int id { get; set; }
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
                return inizio.AddHours(durata);
            }
        }

        public Prenotazione(int id, string nome, DateTime data_nascita, string tipologia, DateTime inizio, int durata, string altro)
        {
            this.id = id;
            this.nome = nome;
            this.data_nascita = data_nascita;
            this.tipologia = tipologia;
            this.inizio = inizio;
            this.durata = durata;
            this.altro = altro;
        }
    }
}
