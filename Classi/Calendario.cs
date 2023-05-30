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
        public readonly List<string> tipologie;
        public int min;
        public int max;
        private string file;

        public Calendario(int min, int max, string filedati, string filetipi)
        {
            prenotazioni = new List<Prenotazione>();
            this.min = min;
            this.max = max;
            this.file = filedati;
            var file2 = filetipi;
            using (var reader = new StreamReader(file2))
            {
                tipologie = reader.ReadToEnd().Split('\n').ToList();
            }
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

        public Prenotazione SearchPrenotazione(int id)
        {
            return prenotazioni.Find(p => p.id == id);
        }

        public List<Prenotazione> GetPrenotazioni()
        {
            return prenotazioni.OrderBy(p => p.inizio).ToList();
        }

        public List<Prenotazione> GetPrenotazioni(DateTime inizio, DateTime fine)
        {
            return prenotazioni.Where(p => p.inizio.Date >= inizio.Date && p.inizio.Date <= fine.Date).OrderBy(p => p.inizio).ToList();
        }

        public bool Libero(DateTime inizio, DateTime fine)
        {
            return prenotazioni.All(p => (p.inizio <= inizio || p.inizio >= fine) && (p.fine <= inizio || p.inizio >= fine));
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

        public List<string> GetSlots(DateTime data, int durata)
        {
            var slots = new List<string>();
            for(int i=0;i<max-min;i++)
            {
                DateTime inizio = data.Date;
                inizio = inizio.AddHours(i + min);
                if (Libero(inizio, inizio.AddHours(durata)))
                {
                    slots.Add(inizio.ToString().Substring(11, 5));
                }
            }
            return slots;
        }

        public void ModifyPrenotazione(int id, Prenotazione newpr)
        {
            int index = prenotazioni.FindIndex(p => p.id == id);
            prenotazioni[index] = newpr;
        }
    }
}
