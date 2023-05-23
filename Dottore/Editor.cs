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
    public partial class Editor : Form
    {
        public Prenotazione prenotazione { get; set; }

        public Editor()
        {
            InitializeComponent();
        }
    }
}
