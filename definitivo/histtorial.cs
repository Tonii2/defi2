using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace definitivo
{
    public partial class histtorial : Form
    {
        SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=pou2;Data Source=LAPTOP-RHMTR2G9\\SQLEXPRESS;TrustServerCertificate=True");
        public histtorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void histtorial_Load(object sender, EventArgs e)
        {
            refressPantalla();

        }
        public void refressPantalla()
        {
            dgvHistorial.DataSource = RegVehiculoDal.PresentarRegVehiculo();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            txtPlaca2.Text = Convert.ToString(dgvHistorial.CurrentRow.Cells["Placa"].Value);

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from multa where Placa='" + txtPlaca2.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvHistorial.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            conexion.Close();
        }
    }
}
