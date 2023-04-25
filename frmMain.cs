using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezMascotas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            clsMascota Alimentar = new clsMascota();
            Alimentar.Nombre = lstMascotas.SelectedItems.ToString();
            MessageBox.Show(Alimentar.AlimentarMascota());
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            clsMascota Jugar = new clsMascota();
            Jugar.Nombre = lstMascotas.SelectedItems.ToString();
            MessageBox.Show(Jugar.JugarConMascota());
        }

        private void btnCuidar_Click(object sender, EventArgs e)
        {
            clsMascota Cuidar = new clsMascota();
            Cuidar.Nombre = lstMascotas.SelectedItems.ToString();
            MessageBox.Show(Cuidar.CuidarMascota());

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] GuardarNombre = new string[10];
            clsMascota nuevaMacota = new clsMascota();
            nuevaMacota.Nombre = txtNombre.Text;
            nuevaMacota.Edad = txtEdad.Text;
            nuevaMacota.TipoMascota = cboTipo.Text;
            List<clsMascota> listaMascotas = new List<clsMascota>();
            listaMascotas.Add(nuevaMacota);

            foreach (var item in listaMascotas)
            {
                lstMascotas.Items.Add(item.TipoMascota);
                cboTipo.Text = item.Nombre;
                txtEdad.Text = item.Edad + " " + "Años";
            }
            txtNombre.Clear();
            txtEdad.Clear();
            cboTipo.SelectedIndex = -1;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
