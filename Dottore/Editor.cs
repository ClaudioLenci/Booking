using Classi;
using System.Windows.Forms;

namespace Dottore
{
    public partial class Editor : Form
    {
        public Prenotazione prenotazione { get; set; }
        public bool Modifica { get; set; }

        public Editor()
        {
            InitializeComponent();
        }

        private void btnModifica_Click(object sender, System.EventArgs e)
        {
            Modifica = true;
            this.Close();
        }

        private void btnCancella_Click(object sender, System.EventArgs e)
        {
            Modifica = false;
            this.Close();
        }
    }
}
