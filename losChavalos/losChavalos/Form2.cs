using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losChavalos
{
    public partial class form2 : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();
        string eleccion = "";
        public form2(string e)
        {
            eleccion = e;
            InitializeComponent();
            MostrarForm();
            this.Load += form2_Load;       // Evento Load
            this.Resize += form2_Resize;   // Evento Resize
        }

        public string Eleccion { get => eleccion; set => eleccion = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            eleccion = textBox1.Text;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            eleccion = "Cancelar";
            this.Close();
        }

        private void MostrarForm()
        {
            switch (eleccion)
            {
                case "NombreBD":
                    label1.Text = "Ingrese el nombre de la BD";
                    label2.Text = "Ingrese el nombre sin espacios o caractéres especiales";
                    break;
                case "BD":

                    break;
            }
            eleccion = textBox1.Text;
        }


        private void form2_Load(object sender, EventArgs e)
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
        private void form2_Resize(object sender, EventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite caracteres de control (como Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Si el carácter es un espacio, se cancela la entrada
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                return;
            }

            // Si no es letra, número o guion bajo, cancela la entrada
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }
    }
}
