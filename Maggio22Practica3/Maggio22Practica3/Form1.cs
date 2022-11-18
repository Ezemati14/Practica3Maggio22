using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maggio22Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EzequielMaggio Practica 3 2022
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //EzequielMaggio Practica 3 2022
            textoTelegrama = txtTelegrama.Text;
            //EzequielMaggio Practica 3 2022
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';

            //EzequielMaggio Practica 3 2022
            numPalabras = textoTelegrama.Length;
            //EzequielMaggio Practica 3 2022
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 25;
                else
                    coste = 0.5 * numPalabras;
            else
            //EzequielMaggio Practica 3 2022
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                //EzequielMaggio Practica 3 2022
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";

        }
    }
}
