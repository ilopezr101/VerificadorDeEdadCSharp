using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadorDeEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Edad;

            Edad = double.Parse(txtedad.Text);


            if (Edad >=18) {
                lblRespuesta.Text = " Usted es mayor de edad ";
                

            }
            else if(Edad <18 ) {
                lblRespuesta.Text = "Usted es menor de edad !!!";
                

            }
            lblRespuesta.Visible = true;
        }

        private void btnLimpiarCampo_Click(object sender, EventArgs e)
        {
            txtedad.Text = String.Empty;
            lblRespuesta.Text = String.Empty;
            txtedad.Focus();
        }
    }
    }

