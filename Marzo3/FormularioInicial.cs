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
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            Console.WriteLine("inicio");
            InitializeComponent();
        }

        private void FormularioInicial_Load(object sender, EventArgs e)
        {
            Console.WriteLine("se llamo al load");
        }

        private void FormularioInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("cerrando..");
        }

        private void FormularioInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("cerrado");
        }
    }
}
