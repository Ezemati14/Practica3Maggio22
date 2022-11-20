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
            int vueltas = 1;
            //EzequielMaggio Practica 3 2022
            textoTelegrama = txtTelegrama.Text;
            //EzequielMaggio Practica 3 2022
            while (vueltas == 1)      
            {
                tipoTelegrama = ' ';
                if (cbUrgente.Checked)
                {
                    tipoTelegrama = 'u';
                    vueltas = 2;
                }

                if (cbUrgente2.Checked)
                {
                    tipoTelegrama = 'o';
                    vueltas = 2; 
                }
                if (cbUrgente2.Checked == false && cbUrgente.Checked == false)
                {
                    MessageBox.Show("Tiene que marcar el tipo de telegama. Si urgente, u ordinario");
                    vueltas = 1; ;
                }
                   
               
            }
           
                

            //EzequielMaggio Practica 3 2022
            //numPalabras = textoTelegrama.Length;
            //EzequielMaggio Practica 3 2022
            if (cbUrgente2.Checked == true)
            {
                for (int i = 0; i < textoTelegrama.Length;i++ )
                {
                    if (textoTelegrama[i] == ' ' || textoTelegrama[i] == '.' || textoTelegrama[i] == ',')
                    {
                        numPalabras++;
                    }
                }
            
            
                if (numPalabras <= 10)
                    coste = 2.5;

                else
                {
                    coste = 0.5 * numPalabras;
                    coste = coste - 2.5;
                }
                    ;

            }
            else
            //EzequielMaggio Practica 3 2022
            if (cbUrgente.Checked == true)
            {
                for (int i = 0; i < textoTelegrama.Length; i++)
                {
                    if (textoTelegrama[i] == ' ' || textoTelegrama[i] == '.' || textoTelegrama[i] == ',')
                    {
                        numPalabras++;
                    }
                }

                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            }
                
            else
                //EzequielMaggio Practica 3 2022
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";

        }
    }
}
