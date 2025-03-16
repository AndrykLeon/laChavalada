using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losChavalos
{
    public partial class Form1 : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();
        public Form1()
        {
            InitializeComponent();
            this.Load += form1_Load;       // Evento Load
            this.Resize += form1_Resize;   // Evento Resize
        }
        form2 f2;
        Form3 f3;
        Form4 f4;
        public SqlConnection cn;
        string query = "";
        string bD = "";
        string mensaje = "";
        public SqlCommand cmd;

        private void crearBdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mensaje = "";
            try
            {
                f2 = new form2("NombreBD");
                f2.ShowDialog();
                if (f2.Eleccion == "Cancelar")
                    mensaje = "Eligió no crear la base de datos";
                else
                {
                    if (existeBD(f2.Eleccion))
                    {
                        mensaje = "El nombre que eligió para la base de datos ya existe";
                    }
                    else
                    {
                        bD = f2.Eleccion;
                        cn = new SqlConnection("Server=MSI\\SERVIDOR;integrated security=true;database=master");
                        query = "Create Database " + bD;
                        cmd = new SqlCommand(query, cn);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        mensaje = "Base de Datos creada con éxito";
                    }
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

        private void statusCrearTablas_Click(object sender, EventArgs e)
        {
            /*mensaje = "";
            try
            {
                form2 f2 = new form2("PreguntaModificarBD");
                f2.Show();

                if (f2.Eleccion == "Cancelar")
                    mensaje = "Eligió cancelar";
                else
                {
                    if (!existeBD(f2.Eleccion))
                    {
                        mensaje = "El nombre de la BD que escribió no existe";
                    }
                    else
                    {
                        bD = f2.Eleccion;
                        f2.Eleccion = "PreguntaTabla";
                        f2.Show();
                        if (validarNombreBD(f2.Eleccion))
                        {
                            switch (f2.Eleccion)
                            {
                                case "Si":
                                    f2.Eleccion = "PreguntaScript";
                                    f2.Show();
                                    cn = new SqlConnection("Server=MSI\\SERVIDOR;integrated security=true;database=" + bD);
                                    query = f2.Eleccion.ToString();
                                    cmd = new SqlCommand(query, cn);
                                    cn.Open();
                                    cmd.ExecuteNonQuery();
                                    cn.Close();
                                    mensaje = "Tablas creadas con éxito";
                                    break;
                                case "No":

                                    break;
                            }
                        }
                    }
                }

            }
            catch (System.Exception ex)
            {
                mensaje = "Hubo un error con la creación de tablas: \n" + ex.Message;
            }
            finally
            {
                MessageBox.Show(mensaje);
            }*/
        }

        private void statusQuery_Click(object sender, EventArgs e)
        {
            mensaje = "";
            try
            {
                form2 f2 = new form2("NombreBD");
                f2.ShowDialog();

                if (f2.Eleccion == "Cancelar")
                    mensaje = "Eligió cancelar";
                else
                {
                    if (existeBD(f2.Eleccion))
                    {
                        bD = f2.Eleccion;
                        f3 = new Form3();
                        f3.ShowDialog();
                        cn = new SqlConnection("Server=MSI\\SERVIDOR;integrated security=true;database=" + bD);
                        query = f3.Texto.ToString();
                        cmd = new SqlCommand(query, cn);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        mensaje = "Script ejecutado con éxito";
                    }
                    else
                    {
                        mensaje = "El nombre que eligió para la base de datos no existe";
                    }
                }
            }
            catch (System.Exception ex)
            {
                mensaje = "No se pudo ejecutar el script: \n" + ex.Message;
            }
            finally
            {
                MessageBox.Show(mensaje);
            }
        }

        private void statusInsertar_Click(object sender, EventArgs e)
        {
            /*
            string mensaje = "";
            string cS = txtBoxString.Text.ToString();
            DateTime fH = DateTime.Now;
            float dinero = Convert.ToSingle(txtBoxDinero.Text.ToString());
            float fl = Convert.ToSingle(txtBoxFloat.Text.ToString());

            try
            {
                cn = new SqlConnection("Server=MSI\\SERVIDOR;integrated security=true;database=BDPractica");
                dato = "Insert into Tabla1 (campoString, campoFechaHora, campoDinero, campoPtoFlotante)" +
                "Values (@CS, @CFH, @CD, @CPF)";
                cmd = new SqlCommand(dato, cn);
                cn.Open();
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@CS", SqlDbType.NVarChar).Value = cS;
                cmd.Parameters.Add("@CFH", SqlDbType.DateTime).Value = fH;
                cmd.Parameters.Add("@CD", SqlDbType.Money).Value = dinero;
                cmd.Parameters.Add("@CPF", SqlDbType.Float).Value = fl;

                cn.Close();
                mensaje = "Dato agregado con éxito";
            }
            catch (System.Exception ex)
            {
                mensaje = "No se pudo agregar la informacion " + ex.Message;
            }
            finally
            {
                MessageBox.Show(mensaje);
            }*/
        }

        private void statusVistas_Click(object sender, EventArgs e)
        {

        }

        private void statusTablas_Click(object sender, EventArgs e)
        {

        }

        private void statusEliminar_Click(object sender, EventArgs e)
        {
            mensaje = "";
            try
            {
                form2 f2 = new form2("PreguntaModificarBD");
                f2.ShowDialog();

                if (f2.Eleccion == "Cancelar")
                    mensaje = "Eligió cancelar";
                else
                {
                    if (existeBD(f2.Eleccion))
                    {
                        bD = f2.Eleccion;
                        cn = new SqlConnection("Server=MSI\\SERVIDOR;integrated security=true;database=" + bD);
                        query = "Drop Database " + bD;
                        cmd = new SqlCommand(query, cn);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        mensaje = "Base de Datos eliminada con éxito";
                    }
                    else
                    {
                        mensaje = "El nombre que eligió para la base de datos no existe";
                    }
                }
            }
            catch (System.Exception ex)
            {
                mensaje = "No se pudo eliminar la Base de Datos: \n" + ex.Message;
            }
            finally
            {
                MessageBox.Show(mensaje);
            }
        }


        private bool existeBD(string nombre)
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

        private void form1_Load(object sender, EventArgs e)
        {
            // Guardar el tamaño original del formulario
            originalWidth = this.ClientSize.Width;
            originalHeight = this.ClientSize.Height;

            // Guardar información original de cada control
            foreach (Control control in this.Controls)
            {
                controlInfo[control] = (control.Width, control.Height, control.Left, control.Top, control.Font.Size);
            }
        }
        private void form1_Resize(object sender, EventArgs e)
        {
            // Calcular el factor de escala
            float scaleX = this.ClientSize.Width / originalWidth;
            float scaleY = this.ClientSize.Height / originalHeight;

            foreach (Control control in this.Controls)
            {
                if (controlInfo.ContainsKey(control))
                {
                    var info = controlInfo[control];

                    // Ajustar las dimensiones
                    control.Width = (int)(info.width * scaleX);
                    control.Height = (int)(info.height * scaleY);
                    control.Left = (int)(info.left * scaleX);
                    control.Top = (int)(info.top * scaleY);

                    // Ajustar el tamaño de la fuente
                    control.Font = new Font(control.Font.FontFamily, info.fontSize * Math.Min(scaleX, scaleY));
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //cn = new SqlConnection("Server=MSI\\SERVIDOR;User ID=Albert;Pwd = abcd;Database=master");
    }
}
