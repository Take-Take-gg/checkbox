using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if(checkBox1.Checked== true)
            {
                conteo++;
            }
            if(checkBox3.Checked == true)
            {
                conteo++;
            }
            if(radioButton1.Checked==true)
            {
                seleccion = "tarjeta de credito";
            }
            else
            {
                seleccion = "PayPal";
            }
            MessageBox.Show("has seleccionado" + conteo + "cursos y tu metodo de pago es " + seleccion);
        }
    }
}
