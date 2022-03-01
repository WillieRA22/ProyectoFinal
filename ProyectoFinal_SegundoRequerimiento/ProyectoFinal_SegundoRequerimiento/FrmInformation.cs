using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_SegundoRequerimiento
{
    public partial class FrmInformation : Form
    {
        public FrmInformation(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmInformation_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
