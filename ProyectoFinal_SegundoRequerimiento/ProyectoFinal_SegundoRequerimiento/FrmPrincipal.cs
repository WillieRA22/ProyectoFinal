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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void pantalla0k()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pantalla0k();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new FrmInformation("¿SEGURO DESEA SALIR DEL SISTEMA?");
            resultado = mensaje.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                Application.Exit();
                this.Hide();
            }
        }

       public void SeleccionandoBotones(Bunifu.Framework.UI.BunifuFlatButton sender)
       {
            btnDashboard.Textcolor = Color.White;
            btnProductos.Textcolor = Color.White;
            btnVentas.Textcolor = Color.White;
            btnCompras.Textcolor = Color.White;
            btnTrabajadores.Textcolor = Color.White;
            btnClientes.Textcolor = Color.White;
            btnProveedores.Textcolor = Color.White;
            btnGanancias.Textcolor = Color.White;

            sender.selected = true;

            if(sender.selected)
            {
                sender.Textcolor = Color.FromArgb(98, 195, 140);
            }
        }
        
        private void SeguirBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            Flecha.Top = sender.Top;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Flecha_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
