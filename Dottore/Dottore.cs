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
        DateTime inizio;
        DateTime fine;

        public Dottore()
        {
            InitializeComponent();
        }

        private void Dottore_Load(object sender, EventArgs e)
        {
            calendario = new Calendario(9, 20, @"../../../dati.csv");
            cbInizio.Checked = true;
            dtpInizio.Value = DateTime.Today;
            dtpInizio.MaxDate = DateTime.Today.AddDays(1);
            inizio = DateTime.Today;
            cbFine.Checked = false;
            dtpFine.Enabled = false;
            dtpFine.Value = inizio.AddDays(1);
            dtpFine.MinDate = inizio.AddDays(1);
            fine = DateTime.MaxValue;
            RiempiListview();
        }

        private void RiempiListview()
        {
            lstPrenotazioni.Items.Clear();
            foreach (var p in calendario.GetPrenotazioni(inizio, fine))
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
            for (int i=0; i<lstPrenotazioni.Columns.Count; i++)
            {
                lstPrenotazioni.Columns[i].Width = -1;
                int w = lstPrenotazioni.Columns[i].Width;
                lstPrenotazioni.Columns[i].Width = -2;
                w = Math.Max(w, lstPrenotazioni.Columns[i].Width);
                lstPrenotazioni.Columns[i].Width = w;
            }
        }

        private void lstPrenotazioni_DoubleClick(object sender, EventArgs e)
        {
            if (lstPrenotazioni.SelectedItems.Count > 0)
            {
                Editor editor = new Editor();
                editor.id = int.Parse(lstPrenotazioni.SelectedItems[0].SubItems[0].Text);
                editor.calendario = calendario;
                editor.ShowDialog();
                calendario = editor.calendario;
                RiempiListview();
            }
        }

        private void Dottore_FormClosing(object sender, FormClosingEventArgs e)
        {
            calendario.salvadati();
        }

        private void cbInizio_CheckedChanged(object sender, EventArgs e)
        {
            dtpInizio.Enabled = cbInizio.Checked;
            if (cbInizio.Checked)
                inizio = dtpInizio.Value.Date;
            else
                inizio = DateTime.MinValue;
            RiempiListview();
        }

        private void cbFine_CheckedChanged(object sender, EventArgs e)
        {
            dtpFine.Enabled = cbFine.Checked;
            if (cbFine.Checked)
                fine = dtpFine.Value.Date;
            else
                fine = DateTime.MaxValue;
            RiempiListview();
        }

        private void dtpInizio_ValueChanged(object sender, EventArgs e)
        {
            dtpFine.MinDate = dtpInizio.Value.Date;
            inizio = dtpInizio.Value.Date;
            RiempiListview();
        }

        private void dtpFine_ValueChanged(object sender, EventArgs e)
        {
            dtpInizio.MaxDate = dtpFine.Value.Date;
            fine = dtpFine.Value.Date;
            RiempiListview();
        }
    }
}
