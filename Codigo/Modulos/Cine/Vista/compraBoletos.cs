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
    public partial class compraBoletos : Form
    {
        csControladort cn = new csControladort();
        public compraBoletos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ayudacompraboleto a = new ayudacompraboleto("clientes", "idClientes");



            if (cn.IDS == null && Txt_cliente.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                Txt_cliente.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ayudacompraboleto a = new ayudacompraboleto("peliculas", "idPeliculas");



            if (cn.IDS == null && txtpelicula.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                txtpelicula.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void txtpelicula_TextChanged(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtsala, txthorario};
            if(txtpelicula.Text.Length != 0)
            {
                cn.verificarhorario(txtpelicula.Text,textBoxes );
            }
        }

        private void txtsala_TextChanged(object sender, EventArgs e)
        {
            ComboBox[] comboBoxes = { cbofila, cbocolumna };
            if (txtsala.Text.Length != 0)
            {
                cn.llenartotal(txtsala.Text, txttotal);
                cn.llenarcombos(comboBoxes, txtsala.Text);
            }
            
        }

        private void compraBoletos_Load(object sender, EventArgs e)
        {
            TextBox[] bloqueados = { Txt_id, txtpelicula, txthorario, txtsala, txttotal, Txt_cliente };
            TextBox[] textBoxes = { Txt_id, txtpelicula, txthorario, txtsala, txttotal, Txt_cliente };
            ComboBox[] comboBoxes = { cbofila, cbocolumna };
            cn.iniciocompraboleto(Txt_id, bloqueados, textBoxes, comboBoxes );
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

            TextBox[] bloqueados = { Txt_id, txtpelicula, txthorario, txtsala, txttotal, Txt_cliente };
            TextBox[] textBoxes = { Txt_id, txtpelicula, txthorario, txtsala, txttotal, Txt_cliente };
            ComboBox[] comboBoxes = { cbofila, cbocolumna };
            cn.iniciocompraboleto(Txt_id, bloqueados, textBoxes, comboBoxes);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            
            TextBox[] textBoxes = { Txt_id,  txtsala, txttotal, Txt_cliente};
            TextBox[] bloqueados = { Txt_id, txtpelicula, txthorario, txtsala, txttotal, Txt_cliente };
            ComboBox[] comboBoxes = { cbofila, cbocolumna };
            cn.llenarcompraboleto(textBoxes, comboBoxes, Txt_id,  bloqueados);
            

        }
    }
}
