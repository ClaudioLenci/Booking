using Classi;
using System;
using System.Windows.Forms;

namespace Dottore
{
    public partial class Editor : Form
    {
        public Calendario calendario { get; set; }
        public int id { get; set; }
        private Prenotazione prenotazione;

        public Editor()
        {
            InitializeComponent();
        }

        private void Riempi()
        {
            prenotazione = calendario.SearchPrenotazione(id);
            lblNome.Text = prenotazione.nome;
            lblData.Text = prenotazione.data_nascita.ToString().Substring(0, 10);
            lblTipologia.Text = prenotazione.tipologia;
            if (prenotazione.inizio.Date <= DateTime.Today)
            {
                lblGiorno.Text = prenotazione.inizio.ToString().Substring(0, 10);
                lblOrario.Text = prenotazione.inizio.ToString().Substring(11, 5);
                lblDurata.Text = prenotazione.durata.ToString();
                dtpGiorno.Visible = false;
                cmbOrario.Visible = false;
                nudDurata.Visible = false;
            }
            else
            {
                dtpGiorno.Value = prenotazione.inizio.Date;
                cmbOrario.SelectedText = prenotazione.inizio.TimeOfDay.ToString().Substring(0, 5);
                nudDurata.Value = prenotazione.durata;
                lblGiorno.Visible = false;
                lblOrario.Visible = false;
                lblDurata.Visible = false;
            }
            rtbAltro.Text = prenotazione.altro;
        }

        private void btnModifica_Click(object sender, System.EventArgs e)
        {
            if (ControlloVuoti())
            {
                if (prenotazione.inizio.Date > DateTime.Today)
                {
                    string inizio = dtpGiorno.Value.ToString().Substring(0, 10) + " " + cmbOrario.Text + ":00";
                    prenotazione.inizio = DateTime.Parse(inizio);
                    prenotazione.durata = (int)nudDurata.Value;
                }
                prenotazione.altro = rtbAltro.Text;
                calendario.ModifyPrenotazione(id, prenotazione);
                this.Close();
            }
            else
            {
                MessageBox.Show("Immettere valori validi!");
            }
        }

        private bool ControlloVuoti()
        {
            if(prenotazione.inizio.Date > DateTime.Today)
                if (cmbOrario.SelectedIndex == -1)
                    if(prenotazione.inizio.ToString().Substring(11, 5) != cmbOrario.Text)
                        return false;
            return true;
        }

        private void btnCancella_Click(object sender, System.EventArgs e)
        {
            calendario.RemovePrenotazione(id);
            this.Close();
        }

        private void Editor_Load(object sender, System.EventArgs e)
        {
            Riempi();
            dtpGiorno.MinDate = dtpGiorno.Value;
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

        private void dtpGiorno_ValueChanged(object sender, EventArgs e)
        {
            AggiornaSlots();
        }

        private void nudDurata_ValueChanged(object sender, EventArgs e)
        {
            AggiornaSlots();
        }
    }
}
