using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_proyect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnUrgencias_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form formulario = new Form3();
            formulario.Show();
        }

        private void btnQuirofano_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form formulario = new Form4();
            formulario.Show();
        }

        private void btnRadiologia_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form formulario = new Form5();
            formulario.Show();
        }

        private void btnTococirugia_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form formulario = new Form6();
            formulario.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form formulario = new Form1();
            formulario.Show();
        }
    }
}
