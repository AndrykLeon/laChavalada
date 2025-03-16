using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losChavalos
{
    internal class metodosDeConexion
    {
        private SqlConnection cn;
        string query = "";
        string bD = "";
        string mensaje = "";
        private SqlCommand cmd;
        DataTable dt;

        public SqlConnection Cn { get => cn; set => cn = value; }
        public string Query { get => query; set => query = value; }
        public string BD { get => bD; set => bD = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public DataTable Dt { get => dt; set => dt = value; }

        public metodosDeConexion(string baseDatos)
        {
            BD = baseDatos;
        }

        public void CrearBD()
        {
            mensaje = "";
            try
            {
                if (ExisteBD(BD))
                    mensaje = "Eligió no crear la base de datos";
                else
                {
                    cn = new SqlConnection("Server=MSI\\SERVIDOR;integrated security=true;database=master");
                    query = "Create Database " + BD;
                    cmd = new SqlCommand(query, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    mensaje = "Base de Datos creada con éxito";
                }
            }
            catch (System.Exception ex)
            {
                mensaje = "Hubo un error con la creación de la base de datos: \n" + ex.Message;
            }
            finally
            {
                MessageBox.Show(mensaje);
            }
        }

        public void EjecutarQuery(string texto)
        {
            mensaje = "";
            try
            {
                if (ExisteBD(BD))
                    mensaje = "Eligió no crear la base de datos";
                else
                {
                    cn = new SqlConnection("Server=MSI\\SERVIDOR;integrated security=true;database=" + BD);
                    query = texto.ToString();
                    cmd = new SqlCommand(query, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    mensaje = "Script ejecutado con éxito";
                }
            }
            catch (System.Exception ex)
            {
                mensaje = "Hubo un error con la creación de la base de datos: \n" + ex.Message;
            }
            finally
            {
                MessageBox.Show(mensaje);
            }
        }


        private bool ExisteBD(string nombre)
        {
            bool respuesta = false;
            try
            {
                cn = new SqlConnection("Server=MSI\\SERVIDOR;integrated security=true;database=master");
                query = "IF EXISTS (SELECT name FROM sys.databases WHERE name = '" + nombre + "') " +
                        "SELECT 1 AS Existe " +
                        "ELSE " +
                        "SELECT 0 AS Existe";
                cn.Open();
                using (cmd = new SqlCommand(query, cn))
                {
                    int num = (int)cmd.ExecuteScalar();
                    if (num == 1)
                    {
                        respuesta = true;
                    }
                }
                cn.Close();
            }
            catch (System.Exception ex)
            {
                mensaje = "Ocurrió un error con la búsqueda de la base datos: \n" + ex.Message;
            }
            return respuesta;
        }
    }
}
