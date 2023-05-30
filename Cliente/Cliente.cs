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

namespace Cliente
{
    public partial class Cliente : Form
    {
        public Calendario calendario;

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            calendario = new Calendario(9, 20, @"../../../dati.csv", @"../../../tipi.txt");
            dtpGiorno.MinDate = DateTime.Today.AddDays(1);
            foreach(var t in calendario.tipologie)
            {
                cmbTipologia.Items.Add(t);
            }
            AggiornaSlots();
        }

        private void btnPrenota_Click(object sender, EventArgs e)
        {
            if (ControlloVuoti())
            {
                string inizio = dtpGiorno.Value.ToString().Substring(0, 10) + " " + cmbOrario.Items[cmbOrario.SelectedIndex] + ":00";
                calendario.AddPrenotazione(txtNome.Text, dtpNascita.Value.Date, cmbTipologia.Text, DateTime.Parse(inizio), (int)nudDurata.Value, rtbAltro.Text);
                Pulisci();
            }
            else
            {
                MessageBox.Show("Compilare tutti i campi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ControlloVuoti()
        {
            if(string.IsNullOrEmpty(txtNome.Text))
                return false;
            if (cmbTipologia.SelectedIndex == -1)
                return false;
            if (cmbOrario.SelectedIndex == -1)
                return false;
            return true;
        }

        private void Pulisci()
        {
            txtNome.Text = "";
            dtpNascita.Value = DateTime.Today;
            cmbTipologia.SelectedIndex = -1;
            dtpGiorno.Value = DateTime.Today.AddDays(1);
            cmbOrario.SelectedIndex = -1;
            nudDurata.Value = 1;
            rtbAltro.Text = "";
        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            calendario.salvadati();
        }

        private void dtpGiorno_ValueChanged(object sender, EventArgs e)
        {
            AggiornaSlots();
        }

        private void AggiornaSlots()
        {
            cmbOrario.SelectedIndex = -1;
            cmbOrario.Items.Clear();
            var slots = calendario.GetSlots(dtpGiorno.Value.Date, (int)nudDurata.Value);
            foreach (var item in slots)
            {
                cmbOrario.Items.Add(item);
            }
        }

        private void nudDurata_ValueChanged(object sender, EventArgs e)
        {
            AggiornaSlots();
        }
    }
}
