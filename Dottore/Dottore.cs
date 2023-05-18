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
        public Calendario calendario;

        public Dottore()
        {
            InitializeComponent();
        }
        public void CaricaListview()
        {
            foreach (var p in calendario.GetPrenotazioni())
            {
                ListViewItem item= new ListViewItem(p.id.ToString());
                item.SubItems.Add(p.nome);
                item.SubItems.Add(p.data_nascita.Date.ToString().Substring(0, 10));
                item.SubItems.Add(p.tipologia);
                item.SubItems.Add(p.inizio.Date.ToString().Substring(0,10));
                item.SubItems.Add(p.inizio.TimeOfDay.ToString());
                item.SubItems.Add(p.durata.ToString());
                item.SubItems.Add(p.altro);
                lstPrenotazioni.Items.Add(item);
            }    
        }

        private void Dottore_Load(object sender, EventArgs e)
        {
            calendario = new Calendario(9, 20, @"../../../dati.csv");
            CaricaListview();
        }
    }
}
