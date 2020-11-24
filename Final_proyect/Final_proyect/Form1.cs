using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Final_proyect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            INITIALIZER();
        }

        private void Sesion()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=inventory";
            string query = "select * from user where user ='" + userTxtBox.Text + "' AND password = SHA1('" + pswTxtBox.Text + "')";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Bienvenido al sistema");

                    this.Hide();

                    Form formulario = new Form2();
                    formulario.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrecto(s)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void INITIALIZER()
        {
            pswTxtBox.Text = "";
            pswTxtBox.PasswordChar = '•';
            pswTxtBox.MaxLength = 255;
        }
        private void pswTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Sesion();
        }
    }
}
