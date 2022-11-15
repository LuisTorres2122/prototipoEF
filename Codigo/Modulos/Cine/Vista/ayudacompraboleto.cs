using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComprasControlador;

namespace ComprasVista
{
    public partial class ayudacompraboleto : Form
    {
        csControladort cn = new csControladort();
        string table, ttipo;
        public ayudacompraboleto(string tabla, string tipo)
        {
            InitializeComponent();
            table = tabla;
            ttipo = tipo;
        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {
            cn.llenarfiltro(table, Dgv_ayuda, ttipo, Txt_codigo.Text);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (Dgv_ayuda.CurrentCell != null)
            {


                cn.IDS = Dgv_ayuda.CurrentRow.Cells[0].Value.ToString();

                this.Close();



            }
        }

        private void ayudacompraboleto_Load(object sender, EventArgs e)
        {
            cn.llenartablaa(table, Dgv_ayuda);
        }
    }
}
