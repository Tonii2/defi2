using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace definitivo
{
    public partial class Form1 : Form
    {
        private static string connectionString = @"Data Source =LAPTOP-RHMTR2G9\SQLEXPRESS;Initial Catalog=pou2;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }


        private bool CheckCredentials(string usuario, string contraseña)
        {
            // Crear la conexión SQL.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el comando SQL.
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña", connection))
                {
                    // Agregar los parámetros al comando SQL.
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    // Abrir la conexión y ejecutar el comando.
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();

                    // Si userCount es 1, entonces las credenciales son correctas.
                    return userCount == 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text;
            string contraseña = txtContras.Text;

            if (CheckCredentials(usuario, contraseña))
            {

                // Aquí puedes abrir la siguiente ventana de tu aplicación.
                // Aquí puedes abrir la siguiente ventana de tu aplicación.url, href, direct string link=    que sea bool 1 act 0 inact nueva tabla   verifica si es 0 o 1  lo muestra si lo es
                Menu Menu = new Menu();
                Menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.MouseHover += (s, e) => { txtContras.PasswordChar = '\0'; };
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.MouseLeave += (s, e) => { txtContras.PasswordChar = '*'; };
        }
    }


}