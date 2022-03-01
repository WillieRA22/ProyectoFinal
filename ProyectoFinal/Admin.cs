using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Admin : Form
    {
        public Admin(string nombre)
        {
            InitializeComponent();
            lblmensajeAdmin.Text = "Bienvenido " + nombre;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
