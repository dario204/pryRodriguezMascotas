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
            if (lstMascotas.Text=="Caniche")
            {
                pbMascotas.Image = Image.FromFile("caniche2.jpg");
                lblTipo.Visible = true;
                lblEdad.Visible = true;
            }
            else
            {
                if (lstMascotas.Text=="Gato")
                {
                    pbMascotas.Image = Image.FromFile("gato.jpg");
                    lblTipo.Visible = true;
                    lblEdad.Visible = true;
                }
                else
                {
                    if (lstMascotas.Text=="Loro")
                    {
                        pbMascotas.Image = Image.FromFile("loro.jpg");
                        lblTipo.Visible = true;
                        lblEdad.Visible = true;
                    }
                    else
                    {
                        if (lstMascotas.Text=="Hamster")
                        {
                            pbMascotas.Image = Image.FromFile("hamster.jpg");
                            lblTipo.Visible = true;
                            lblEdad.Visible = true;
                        }
                        else
                        {
                            if (lstMascotas.Text=="Pez")
                            {
                                pbMascotas.Image = Image.FromFile("pez.jpg");
                                lblTipo.Visible = true;
                                lblEdad.Visible = true;
                            }
                        }
                    }
                }
            }



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
            clsMascota nuevaMascota = new clsMascota();
            nuevaMascota.Nombre = txtNombre.Text;
            nuevaMascota.Edad = txtEdad.Text;
            nuevaMascota.TipoMascota = cboTipo.Text;
            List<clsMascota> listaMascotas = new List<clsMascota>();
            listaMascotas.Add(nuevaMascota);

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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }

}
