﻿namespace Dependencia_lineal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtboxI1 = new System.Windows.Forms.TextBox();
            this.txtboxJ1 = new System.Windows.Forms.TextBox();
            this.txtboxK1 = new System.Windows.Forms.TextBox();
            this.txtboxK2 = new System.Windows.Forms.TextBox();
            this.txtboxJ2 = new System.Windows.Forms.TextBox();
            this.txtboxI2 = new System.Windows.Forms.TextBox();
            this.txtboxResult = new System.Windows.Forms.TextBox();
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.lblV3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnCross = new System.Windows.Forms.Button();
            this.btnSubs = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxI1
            // 
            this.txtboxI1.Location = new System.Drawing.Point(264, 59);
            this.txtboxI1.Name = "txtboxI1";
            this.txtboxI1.Size = new System.Drawing.Size(33, 20);
            this.txtboxI1.TabIndex = 0;
            this.txtboxI1.TextChanged += new System.EventHandler(this.textBoxV11_TextChanged);
            this.txtboxI1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV11_KeyPress);
            // 
            // txtboxJ1
            // 
            this.txtboxJ1.Location = new System.Drawing.Point(321, 59);
            this.txtboxJ1.Name = "txtboxJ1";
            this.txtboxJ1.Size = new System.Drawing.Size(33, 20);
            this.txtboxJ1.TabIndex = 1;
            this.txtboxJ1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV11_KeyPress);
            // 
            // txtboxK1
            // 
            this.txtboxK1.Location = new System.Drawing.Point(381, 60);
            this.txtboxK1.Name = "txtboxK1";
            this.txtboxK1.Size = new System.Drawing.Size(33, 20);
            this.txtboxK1.TabIndex = 2;
            this.txtboxK1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV11_KeyPress);
            // 
            // txtboxK2
            // 
            this.txtboxK2.Location = new System.Drawing.Point(380, 127);
            this.txtboxK2.Name = "txtboxK2";
            this.txtboxK2.Size = new System.Drawing.Size(33, 20);
            this.txtboxK2.TabIndex = 5;
            this.txtboxK2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV11_KeyPress);
            // 
            // txtboxJ2
            // 
            this.txtboxJ2.Location = new System.Drawing.Point(318, 128);
            this.txtboxJ2.Name = "txtboxJ2";
            this.txtboxJ2.Size = new System.Drawing.Size(33, 20);
            this.txtboxJ2.TabIndex = 4;
            this.txtboxJ2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV11_KeyPress);
            // 
            // txtboxI2
            // 
            this.txtboxI2.Location = new System.Drawing.Point(266, 128);
            this.txtboxI2.Name = "txtboxI2";
            this.txtboxI2.Size = new System.Drawing.Size(33, 20);
            this.txtboxI2.TabIndex = 3;
            this.txtboxI2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV11_KeyPress);
            // 
            // txtboxResult
            // 
            this.txtboxResult.Enabled = false;
            this.txtboxResult.Location = new System.Drawing.Point(259, 194);
            this.txtboxResult.Name = "txtboxResult";
            this.txtboxResult.Size = new System.Drawing.Size(155, 20);
            this.txtboxResult.TabIndex = 6;
            this.txtboxResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV11_KeyPress);
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV1.Location = new System.Drawing.Point(295, 33);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(59, 15);
            this.lblV1.TabIndex = 22;
            this.lblV1.Text = "Vector 1";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV2.Location = new System.Drawing.Point(295, 102);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(59, 15);
            this.lblV2.TabIndex = 23;
            this.lblV2.Text = "Vector 2";
            // 
            // lblV3
            // 
            this.lblV3.AutoSize = true;
            this.lblV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV3.Location = new System.Drawing.Point(303, 176);
            this.lblV3.Name = "lblV3";
            this.lblV3.Size = new System.Drawing.Size(72, 15);
            this.lblV3.TabIndex = 24;
            this.lblV3.Text = "Resultado";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnPoint);
            this.groupBox1.Controls.Add(this.btnCross);
            this.groupBox1.Controls.Add(this.btnSubs);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtboxI1);
            this.groupBox1.Controls.Add(this.txtboxJ1);
            this.groupBox1.Controls.Add(this.txtboxK1);
            this.groupBox1.Controls.Add(this.lblV3);
            this.groupBox1.Controls.Add(this.txtboxI2);
            this.groupBox1.Controls.Add(this.lblV2);
            this.groupBox1.Controls.Add(this.txtboxJ2);
            this.groupBox1.Controls.Add(this.lblV1);
            this.groupBox1.Controls.Add(this.txtboxK2);
            this.groupBox1.Controls.Add(this.txtboxResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 247);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(37, 162);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(165, 52);
            this.btnPoint.TabIndex = 39;
            this.btnPoint.Text = "Producto punto ( * )";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnCross
            // 
            this.btnCross.Location = new System.Drawing.Point(37, 102);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(165, 54);
            this.btnCross.TabIndex = 38;
            this.btnCross.Text = "Producto cruz ( x )";
            this.btnCross.UseVisualStyleBackColor = true;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // btnSubs
            // 
            this.btnSubs.Location = new System.Drawing.Point(127, 45);
            this.btnSubs.Name = "btnSubs";
            this.btnSubs.Size = new System.Drawing.Size(75, 43);
            this.btnSubs.TabIndex = 37;
            this.btnSubs.Text = "Resta ( - )";
            this.btnSubs.UseVisualStyleBackColor = true;
            this.btnSubs.Click += new System.EventHandler(this.btnSubs_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(37, 45);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(84, 43);
            this.btnSum.TabIndex = 36;
            this.btnSum.Text = "Suma (+)";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "i";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "j";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "k";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "i";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "j";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "k";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClear.Location = new System.Drawing.Point(12, 421);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(133, 40);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Limpiar";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(332, 421);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 40);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 160);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(82, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(209, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "Operaciones con vectores";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(434, 54);
            this.label17.TabIndex = 1;
            this.label17.Text = "Ingrese las coordenadas de los vectores y seleccione la operación correspondiente" +
    ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(82, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(252, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Instituto tecnológico de Tiijuana";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher1.Path = "..\\..";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(477, 473);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxI1;
        private System.Windows.Forms.TextBox txtboxJ1;
        private System.Windows.Forms.TextBox txtboxK1;
        private System.Windows.Forms.TextBox txtboxK2;
        private System.Windows.Forms.TextBox txtboxJ2;
        private System.Windows.Forms.TextBox txtboxI2;
        private System.Windows.Forms.TextBox txtboxResult;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblV3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCross;
        private System.Windows.Forms.Button btnSubs;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnPoint;
    }
}

