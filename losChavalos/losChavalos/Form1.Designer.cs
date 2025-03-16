namespace losChavalos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusCrear = new System.Windows.Forms.ToolStripSplitButton();
            this.crearBdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusCrearTablas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusQuery = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusInsertar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusConsultas = new System.Windows.Forms.ToolStripSplitButton();
            this.statusVistas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusTablas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusEliminar = new System.Windows.Forms.ToolStripDropDownButton();
            this.eliminarBdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.Location = new System.Drawing.Point(665, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 31);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(155)))), ((int)(((byte)(194)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusCrear,
            this.statusQuery,
            this.statusInsertar,
            this.statusConsultas,
            this.statusEliminar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 29);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusCrear
            // 
            this.statusCrear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearBdToolStripMenuItem,
            this.statusCrearTablas});
            this.statusCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.statusCrear.Name = "statusCrear";
            this.statusCrear.Size = new System.Drawing.Size(77, 27);
            this.statusCrear.Text = "Crear ";
            // 
            // crearBdToolStripMenuItem
            // 
            this.crearBdToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.crearBdToolStripMenuItem.Name = "crearBdToolStripMenuItem";
            this.crearBdToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.crearBdToolStripMenuItem.Text = "Crear Bd";
            this.crearBdToolStripMenuItem.Click += new System.EventHandler(this.crearBdToolStripMenuItem_Click);
            // 
            // statusCrearTablas
            // 
            this.statusCrearTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.statusCrearTablas.Name = "statusCrearTablas";
            this.statusCrearTablas.Size = new System.Drawing.Size(192, 28);
            this.statusCrearTablas.Text = "Crear Tablas";
            this.statusCrearTablas.Click += new System.EventHandler(this.statusCrearTablas_Click);
            // 
            // statusQuery
            // 
            this.statusQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.statusQuery.Name = "statusQuery";
            this.statusQuery.Size = new System.Drawing.Size(128, 23);
            this.statusQuery.Text = "Ejecutar Query";
            this.statusQuery.Click += new System.EventHandler(this.statusQuery_Click);
            // 
            // statusInsertar
            // 
            this.statusInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.statusInsertar.Name = "statusInsertar";
            this.statusInsertar.Size = new System.Drawing.Size(117, 23);
            this.statusInsertar.Text = "InsertarDatos";
            this.statusInsertar.Click += new System.EventHandler(this.statusInsertar_Click);
            // 
            // statusConsultas
            // 
            this.statusConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusVistas,
            this.statusTablas});
            this.statusConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.statusConsultas.Name = "statusConsultas";
            this.statusConsultas.Size = new System.Drawing.Size(105, 27);
            this.statusConsultas.Text = "Consultas";
            // 
            // statusVistas
            // 
            this.statusVistas.Name = "statusVistas";
            this.statusVistas.Size = new System.Drawing.Size(144, 28);
            this.statusVistas.Text = "Vistas";
            this.statusVistas.Click += new System.EventHandler(this.statusVistas_Click);
            // 
            // statusTablas
            // 
            this.statusTablas.Name = "statusTablas";
            this.statusTablas.Size = new System.Drawing.Size(144, 28);
            this.statusTablas.Text = "Tablas";
            this.statusTablas.Click += new System.EventHandler(this.statusTablas_Click);
            // 
            // statusEliminar
            // 
            this.statusEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarBdToolStripMenuItem,
            this.eliminarTablasToolStripMenuItem});
            this.statusEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.statusEliminar.Name = "statusEliminar";
            this.statusEliminar.Size = new System.Drawing.Size(90, 27);
            this.statusEliminar.Text = "Eliminar";
            this.statusEliminar.Click += new System.EventHandler(this.statusEliminar_Click);
            // 
            // eliminarBdToolStripMenuItem
            // 
            this.eliminarBdToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarBdToolStripMenuItem.Name = "eliminarBdToolStripMenuItem";
            this.eliminarBdToolStripMenuItem.Size = new System.Drawing.Size(215, 28);
            this.eliminarBdToolStripMenuItem.Text = "Eliminar Bd";
            // 
            // eliminarTablasToolStripMenuItem
            // 
            this.eliminarTablasToolStripMenuItem.Name = "eliminarTablasToolStripMenuItem";
            this.eliminarTablasToolStripMenuItem.Size = new System.Drawing.Size(215, 28);
            this.eliminarTablasToolStripMenuItem.Text = "Eliminar Tablas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(155)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(528, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Los Chavalos";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 399);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(736, 431);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Los Chavalos";
            this.Load += new System.EventHandler(this.form1_Load);
            this.Resize += new System.EventHandler(this.form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusQuery;
        private System.Windows.Forms.ToolStripStatusLabel statusInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSplitButton statusCrear;
        private System.Windows.Forms.ToolStripMenuItem crearBdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusCrearTablas;
        private System.Windows.Forms.ToolStripSplitButton statusConsultas;
        private System.Windows.Forms.ToolStripMenuItem statusVistas;
        private System.Windows.Forms.ToolStripMenuItem statusTablas;
        private System.Windows.Forms.ToolStripDropDownButton statusEliminar;
        private System.Windows.Forms.ToolStripMenuItem eliminarBdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTablasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

