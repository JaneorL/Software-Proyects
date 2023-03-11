using Visual;

namespace ConsultaMedica
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearConsul frm = new frmCrearConsul();
            frm.ShowDialog();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmVisualizarConsul frm = new frmVisualizarConsul();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarConsul frm = new frmEditarConsul();
            frm.ShowDialog();
        }
    }
}