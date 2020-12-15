﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseObjetoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCalcularResultado_Click(object sender, EventArgs e)
        {
            Fraccion f1 = new Fraccion((int)numNumerador1.Value, (int)numDenominador1.Value);
            Fraccion f2 = new Fraccion((int)numNumerador2.Value, (int)numDenominador2.Value);
            Fraccion resultado = null;

            switch (cboOperacion.Text)
            {
                case "+":
                    resultado = f1.Sumar(f2);
                    break;
                case "-":
                    resultado = f1.Restar(f2);
                    break;
                case "x":
                    resultado = f1.Multiplicar(f2);
                    break;
                case "/":
                    resultado = f1.Dividir(f2);
                    break;
                default:
                    MessageBox.Show("Falta seleccionar la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //break;
            }
            //lblResultado.Text = resultado.ToString();
            lblLinea.Text = "____";
            if (resultado.Entero == 0)
            {
                lblResultadoEntero.Text = "";
            }
            else
            {
                lblResultadoEntero.Text = resultado.Entero + "";
            }
            if (resultado.Numerador == 0)
            {
                lblResultadoNumerador.Text = "";
                lblResultadoDenominador.Text = "";
                lblLinea.Text = "";
            }
            else
            {
                lblResultadoNumerador.Text = resultado.Numerador + "";
                lblResultadoDenominador.Text = resultado.Denominador + "";
            }
        }

        private void lblLinea_Click(object sender, EventArgs e)
        {

        }
    }
}
