namespace losChavalos
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnRegresar;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tablas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGVEmpleados = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dGVHabitacion = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dGVPedidoServicio = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dGVHuesped = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dGVPrestamos = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dGVReservacion = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dGVServicios = new System.Windows.Forms.DataGridView();
            btnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Tablas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmpleados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHabitacion)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPedidoServicio)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHuesped)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPrestamos)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReservacion)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(155)))), ((int)(((byte)(194)))));
            btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            btnRegresar.Location = new System.Drawing.Point(576, 53);
            btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new System.Drawing.Size(188, 48);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(155)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 46);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione la tabla a consultar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seleccione el nombre de la tabla que quiera consultar";
            // 
            // Tablas
            // 
            this.Tablas.Controls.Add(this.tabPage1);
            this.Tablas.Controls.Add(this.tabPage2);
            this.Tablas.Controls.Add(this.tabPage3);
            this.Tablas.Controls.Add(this.tabPage4);
            this.Tablas.Controls.Add(this.tabPage5);
            this.Tablas.Controls.Add(this.tabPage6);
            this.Tablas.Controls.Add(this.tabPage7);
            this.Tablas.Location = new System.Drawing.Point(21, 117);
            this.Tablas.Name = "Tablas";
            this.Tablas.SelectedIndex = 0;
            this.Tablas.Size = new System.Drawing.Size(743, 325);
            this.Tablas.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.tabPage1.Controls.Add(this.dGVEmpleados);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleado";
            // 
            // dGVEmpleados
            // 
            this.dGVEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dGVEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmpleados.Location = new System.Drawing.Point(0, 3);
            this.dGVEmpleados.Name = "dGVEmpleados";
            this.dGVEmpleados.RowHeadersWidth = 51;
            this.dGVEmpleados.RowTemplate.Height = 24;
            this.dGVEmpleados.Size = new System.Drawing.Size(735, 291);
            this.dGVEmpleados.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.tabPage2.Controls.Add(this.dGVHabitacion);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Habitacion";
            // 
            // dGVHabitacion
            // 
            this.dGVHabitacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dGVHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHabitacion.Location = new System.Drawing.Point(0, 0);
            this.dGVHabitacion.Name = "dGVHabitacion";
            this.dGVHabitacion.RowHeadersWidth = 51;
            this.dGVHabitacion.RowTemplate.Height = 24;
            this.dGVHabitacion.Size = new System.Drawing.Size(735, 291);
            this.dGVHabitacion.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.tabPage3.Controls.Add(this.dGVPedidoServicio);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(735, 290);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pedido Servicio";
            // 
            // dGVPedidoServicio
            // 
            this.dGVPedidoServicio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dGVPedidoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPedidoServicio.Location = new System.Drawing.Point(0, 0);
            this.dGVPedidoServicio.Name = "dGVPedidoServicio";
            this.dGVPedidoServicio.RowHeadersWidth = 51;
            this.dGVPedidoServicio.RowTemplate.Height = 24;
            this.dGVPedidoServicio.Size = new System.Drawing.Size(735, 291);
            this.dGVPedidoServicio.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.tabPage4.Controls.Add(this.dGVHuesped);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(735, 290);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Huésped";
            // 
            // dGVHuesped
            // 
            this.dGVHuesped.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dGVHuesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHuesped.Location = new System.Drawing.Point(0, 0);
            this.dGVHuesped.Name = "dGVHuesped";
            this.dGVHuesped.RowHeadersWidth = 51;
            this.dGVHuesped.RowTemplate.Height = 24;
            this.dGVHuesped.Size = new System.Drawing.Size(735, 291);
            this.dGVHuesped.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.tabPage5.Controls.Add(this.dGVPrestamos);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(735, 290);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Prestamos";
            // 
            // dGVPrestamos
            // 
            this.dGVPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dGVPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPrestamos.Location = new System.Drawing.Point(0, 0);
            this.dGVPrestamos.Name = "dGVPrestamos";
            this.dGVPrestamos.RowHeadersWidth = 51;
            this.dGVPrestamos.RowTemplate.Height = 24;
            this.dGVPrestamos.Size = new System.Drawing.Size(734, 291);
            this.dGVPrestamos.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.tabPage6.Controls.Add(this.dGVReservacion);
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(735, 290);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Reservación";
            // 
            // dGVReservacion
            // 
            this.dGVReservacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dGVReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReservacion.Location = new System.Drawing.Point(0, 0);
            this.dGVReservacion.Name = "dGVReservacion";
            this.dGVReservacion.RowHeadersWidth = 51;
            this.dGVReservacion.RowTemplate.Height = 24;
            this.dGVReservacion.Size = new System.Drawing.Size(734, 291);
            this.dGVReservacion.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.tabPage7.Controls.Add(this.dGVServicios);
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(735, 290);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Servicios";
            // 
            // dGVServicios
            // 
            this.dGVServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dGVServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVServicios.Location = new System.Drawing.Point(0, 0);
            this.dGVServicios.Name = "dGVServicios";
            this.dGVServicios.RowHeadersWidth = 51;
            this.dGVServicios.RowTemplate.Height = 24;
            this.dGVServicios.Size = new System.Drawing.Size(734, 291);
            this.dGVServicios.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(765, 446);
            this.ControlBox = false;
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnRegresar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tablas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmpleados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHabitacion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPedidoServicio)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHuesped)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPrestamos)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVReservacion)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl Tablas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dGVEmpleados;
        private System.Windows.Forms.DataGridView dGVHabitacion;
        private System.Windows.Forms.DataGridView dGVPedidoServicio;
        private System.Windows.Forms.DataGridView dGVHuesped;
        private System.Windows.Forms.DataGridView dGVPrestamos;
        private System.Windows.Forms.DataGridView dGVReservacion;
        private System.Windows.Forms.DataGridView dGVServicios;
    }
}