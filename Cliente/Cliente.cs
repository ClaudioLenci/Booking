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
            calendario = new Calendario(9, 20, @"../../../dati.csv");
            dtpGiorno.MinDate = DateTime.Today;
        }

        private void btnPrenota_Click(object sender, EventArgs e)
        {
            if (ControlloVuoti())
            {
                calendario.AddPrenotazione(txtNome.Text, dtpNascita.Value, cmbTipologia.Text, dtpGiorno.Value, (int)nudDurata.Value, rtbAltro.Text);
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
            dtpGiorno.Value = DateTime.Today;
            cmbOrario.SelectedIndex = -1;
            nudDurata.Value = 1;
            rtbAltro.Text = "";
        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            calendario.salvadati();
        }
    }
}
