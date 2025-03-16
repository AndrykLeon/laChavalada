using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losChavalos
{
    public partial class Form4 : Form
    {
        SqlDataReader lector;
        string bD = "";
        string mensaje = "";
        public SqlConnection cn; 
        string query = "";
        public SqlCommand cmd;
        public Form4(string e)
        {
            InitializeComponent();
            BD = e;
            LlenarDatas();
        }


        public string BD { get => bD; set => bD = value; }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarDatas()
        {
            LlenarData(tabPage1.Text, dGVEmpleados);
            LlenarData(tabPage2.Text, dGVHabitacion);
            LlenarData("PedidoServicio", dGVPedidoServicio);
            LlenarData("Huesped", dGVHuesped);
            LlenarData("Prestamos", dGVPrestamos);
            LlenarData("Reservacion", dGVReservacion);
            LlenarData("Servicio", dGVServicios);
            MessageBox.Show(mensaje);
        }

        private void LlenarData(string tabla, DataGridView data)
        {
            try
            {
                data.ForeColor = Color.Black;
                cn = new SqlConnection("Server=MSI\\SERVIDOR;integrated security=true;database=" + bD); 
                query = "SELECT * FROM " + tabla;
                cmd = new SqlCommand(query, cn); 
                data.Rows.Clear();
                cn.Open();
                lector = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(lector);

                cn.Close();

                data.DataSource = dt;
                mensaje = "Consulta Exitosa";
            }
            catch (System.Exception ex)
            {
                mensaje = "No se pudo consultar la Base de Datos: \n" + ex.Message;
            }
        }
    }
}
