using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class frmCrearConsul : Form
    {
        public List<Consultorio> listaGuardar = new List<Consultorio>();
        List<Consultorio> listaGuardarEliminado = new List<Consultorio>();

        public frmCrearConsul()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "esta seguro de agregar los datos", "Sistema POE", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                agregarDatos();
            }
        }

        public void agregarDatos()
        {
            Consultorio objConsultorio = new Consultorio();
            objConsultorio.Nombre = txtNombreConsul.Text.Trim();
            objConsultorio.Direccion = txtDireccionConsul.Text.Trim();
            objConsultorio.Encargado = txtDoctorEnc.Text.Trim();
            objConsultorio.FechaReg = dtpFechaReg.Text.Trim();

            listaGuardar.Add(objConsultorio);

        }

    }
}
