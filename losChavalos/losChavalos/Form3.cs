using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace losChavalos
{
    public partial class Form3 : Form
    {
        string cn = "";
        string query = "";
        string cmd = "";
        string mensaje = "";
        string texto = "";
        string BD;
        metodosDeConexion metodos;
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();
        public Form3(string bd)
        {
            BD = bd;
            InitializeComponent();
            this.Load += form3_Load;       // Evento Load
            this.Resize += form3_Resize;   // Evento Resize
        }
        public string Texto { get => texto; set => texto = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            mensaje = "";
            texto = richTextBox1.Text;
            try
            {
                metodos = new metodosDeConexion(BD);
                metodos.EjecutarQuery(texto);
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


        private void form3_Load(object sender, EventArgs e)
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
        private void form3_Resize(object sender, EventArgs e)
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
    }
}
