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
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3002";
            TextBox[] textBoxes = { txt_id, txt_nombre, txt_Dirección};
            TextBox[] textBoxes1 = { txt_id, txt_nombre };
            navegador1.actual = this;
            navegador1.tabla = Dgv_cines;
            navegador1.textbox = textBoxes;
            navegador1.textboxi = textBoxes1;
            navegador1.cargar(Dgv_cines, textBoxes, "colchoneria");
        }
    }
}
