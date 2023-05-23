using Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dottore
{
    public partial class Dottore : Form
    {
        Calendario calendario;

        public Dottore()
        {
            InitializeComponent();
        }

        private void Dottore_Load(object sender, EventArgs e)
        {
            calendario = new Calendario(9, 20, @"../../../dati.csv");
            RiempiListview();
        }

        private void RiempiListview()
        {
            foreach (var p in calendario.prenotazioni)
            {
                ListViewItem item = new ListViewItem(p.id.ToString());
                item.SubItems.Add(p.nome);
                item.SubItems.Add(p.data_nascita.ToString().Substring(0, 10));
                item.SubItems.Add(p.tipologia);
                item.SubItems.Add(p.inizio.Date.ToString().Substring(0, 10));
                item.SubItems.Add(p.inizio.TimeOfDay.ToString().Substring(0, 5));
                item.SubItems.Add(p.durata.ToString() + " ore");
                item.SubItems.Add(p.altro);
                lstPrenotazioni.Items.Add(item);
            }
        }

        private void lstPrenotazioni_DoubleClick(object sender, EventArgs e)
        {
            if (lstPrenotazioni.SelectedItems.Count > 0)
            {
                int id = int.Parse(lstPrenotazioni.SelectedItems[0].SubItems[0].Text);
            }
        }
    }
}
