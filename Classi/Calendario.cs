using CsvHelper;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Calendario
    {
        public List<Prenotazione> prenotazioni { get; set; }
        public int min;
        public int max;
        private string file;

        public Calendario(int min, int max, string file)
        {
            prenotazioni = new List<Prenotazione>();
            this.min = min;
            this.max = max;
            this.file = file;
            apridati();
        }

        public void apridati()
        {
            using (var reader = new StreamReader(file))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    prenotazioni = csv.GetRecords<Prenotazione>().ToList();
                }
            }
        }

        public void salvadati()
        {
            using (var writer = new StreamWriter(file))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(prenotazioni);
                }
            }
        }

        public List<Prenotazione> GetPrenotazioni()
        {
            return prenotazioni.OrderBy(p => p.inizio).ToList();
        }

        public List<Prenotazione> GetPrenotazioniFuture()
        {
            return prenotazioni.OrderBy(p => p.inizio).Where(p => p.inizio >= DateTime.Today).ToList();
        }

        public bool Libero(Prenotazione p)
        {
            return prenotazioni.Any(p2 => (p2.inizio <= p.inizio || p2.inizio >= p.fine) && (p2.fine <= p.inizio || p2.fine >= p.fine));
        }

        public bool Exists(int id)
        {
            return prenotazioni.Exists(p => p.id == id);
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
