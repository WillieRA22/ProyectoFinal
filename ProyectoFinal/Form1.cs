using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q54CMT3;Initial Catalog=DbPrueba;Integrated Security=True");


        public void Loguear(string usuario, string contraseña)
        {


        }
        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_USUARIO WHERE USUARIOS = '" + txtUsuario.Text + "' AND UCLAVE = '" + txtContraseña.Text + "'", con);
                //   cmd.Parameters.AddWithValue("usuario", usuario);
                //   cmd.Parameters.AddWithValue("pas", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                   
                    this.Hide();
                    Prueba usuario = new Prueba();
                    usuario.Show();


                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            /*
            private void button2_Click(object sender, EventArgs e)
            {
                Loguear(this.textBox1.Text, this.textBox2.Text);
            } */
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}