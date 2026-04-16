using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Mantenimiento
{
    public partial class Frm_mantenimiento : Form
    {
        public Frm_mantenimiento()
        {
            InitializeComponent();
            //parametros para navegador
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_empleados"
            };

            string[] columnas = {
     "Peliculas",
     "idPeliculas",
     "Nombre",
     "Clasificación",
     "Genero",
     "Subtitulado",
     "Idioma",
     "precio"


 };

            string[] sEtiquetas = {
    "ID Peliculas",
     "Nombre",
     "Clasificación",
     "Genero",
     "Subtitulado",
     "Idioma",
     "precio"

 };



            int id_aplicacion = 900;
            int id_modulo = 5;

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        
    }
    }
}
