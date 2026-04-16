using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Seguridad;
using Capa_Vista_Seguridad;
using Capa_Vista_Mantenimiento;

namespace Capa_Vista_Cine
{
    public partial class Frm_MDI : Form
    {
        public Frm_MDI()
        {
            InitializeComponent();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_mantenimiento prueba = new Frm_mantenimiento();
            prueba.Show();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Seguridad seguridad = new Frm_Seguridad();
            seguridad.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
