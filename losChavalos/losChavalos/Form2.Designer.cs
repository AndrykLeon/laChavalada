﻿namespace losChavalos
{
    partial class form2
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
            System.Windows.Forms.Button btnAceptar;
            System.Windows.Forms.Button btnCancelar;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(155)))), ((int)(((byte)(194)))));
            btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            btnAceptar.Location = new System.Drawing.Point(152, 260);
            btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(138, 91);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(155)))), ((int)(((byte)(194)))));
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            btnCancelar.Location = new System.Drawing.Point(396, 260);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(138, 91);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese el nombre de la BD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(81, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese el nombre sin espacios o caractéres especiales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(155)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 100);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 28);
            this.textBox1.TabIndex = 11;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(705, 364);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(btnAceptar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form2";
            this.Text = "Los Chavalos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}