using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasVista
{
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3001";
            TextBox[] textBoxes = { txt_id, txt_nombre, txt_clasificacion, txt_genero, txt_subtitulado, txt_idioma, txt_precio };
            TextBox[] textBoxes1 = { txt_id, txt_nombre };
            navegador1.actual = this;
            navegador1.tabla = Dgv_peliculas;
            navegador1.textbox = textBoxes;
            navegador1.textboxi = textBoxes1;
            navegador1.cargar(Dgv_peliculas,textBoxes, "colchoneria");
        }
    }
}
