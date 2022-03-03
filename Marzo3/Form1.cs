using Marzo3.servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marzo3
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

        private void button1_Click(object sender, EventArgs e)
        {
            CalculadoraSrv srv = new CalculadoraSrv();
                        // control y click
            var obj = srv.Factory(numericUpDown1.Value, numericUpDown2.Value);

            decimal total = srv.Sumar(obj);

            etiquetaTotal.Text = total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculadoraSrv srv = new CalculadoraSrv();
            // control y click
            var obj = srv.Factory(numericUpDown1.Value, numericUpDown2.Value);

            decimal total = srv.Restar(obj);

            etiquetaTotal.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculadoraSrv srv = new CalculadoraSrv();
            // control y click
            var obj = srv.Factory(numericUpDown1.Value, numericUpDown2.Value);

            decimal total = srv.Multiplicar(obj);

            etiquetaTotal.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculadoraSrv srv = new CalculadoraSrv();
            // control y click
            var obj = srv.Factory(numericUpDown1.Value, numericUpDown2.Value);

            decimal total = srv.Dividir(obj);

            etiquetaTotal.Text = total.ToString();
        }
    }
}
