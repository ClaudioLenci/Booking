using Classi;
using System.Windows.Forms;

namespace Dottore
{
    public partial class Editor : Form
    {
        public Calendario calendario { get; set; }
        public int id { get; set; }

        public Editor()
        {
            InitializeComponent();
        }
        private void Riempi()
        {
            var prenotazione = calendario.SearchPrenotazione(id);
            dtpGiorno.Text = prenotazione.inizio.Date.ToString().Substring(0, 10);
            cmbOrario.Text = prenotazione.inizio.TimeOfDay.ToString().Substring(0, 5);
            nudDurata.Value = prenotazione.durata;
            rtbAltro.Text = prenotazione.altro;
            lblNome.Text = prenotazione.nome;
            lblData.Text = prenotazione.data_nascita.ToString().Substring(0, 10);
            lblTipologia.Text = prenotazione.tipologia;
        }

        private void btnModifica_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnCancella_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Editor_Load(object sender, System.EventArgs e)
        {
            Riempi();

        }
    }
}
