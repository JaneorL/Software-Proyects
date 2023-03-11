namespace Visual
{
    partial class frmVisualizarConsul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvListado = new System.Windows.Forms.ListView();
            this.colNombre = new System.Windows.Forms.ColumnHeader();
            this.colDireccion = new System.Windows.Forms.ColumnHeader();
            this.colDoctorEnc = new System.Windows.Forms.ColumnHeader();
            this.colFechaReg = new System.Windows.Forms.ColumnHeader();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvListado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de consultorios";
            // 
            // lvListado
            // 
            this.lvListado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombre,
            this.colDireccion,
            this.colDoctorEnc,
            this.colFechaReg});
            this.lvListado.Location = new System.Drawing.Point(33, 32);
            this.lvListado.Name = "lvListado";
            this.lvListado.Size = new System.Drawing.Size(606, 321);
            this.lvListado.TabIndex = 0;
            this.lvListado.UseCompatibleStateImageBehavior = false;
            this.lvListado.View = System.Windows.Forms.View.Details;
            this.lvListado.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre del consultorio";
            this.colNombre.Width = 150;
            // 
            // colDireccion
            // 
            this.colDireccion.Text = "Direccion de consultorio";
            this.colDireccion.Width = 150;
            // 
            // colDoctorEnc
            // 
            this.colDoctorEnc.Text = "Doctor Encargado";
            this.colDoctorEnc.Width = 150;
            // 
            // colFechaReg
            // 
            this.colFechaReg.Text = "Fecha de Registro";
            this.colFechaReg.Width = 150;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(141, 394);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(132, 58);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver al menu";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(392, 394);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 58);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmVisualizarConsul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(700, 470);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVisualizarConsul";
            this.Text = "Visualizar Listado";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvListado;
        private ColumnHeader colNombre;
        private ColumnHeader colDireccion;
        private ColumnHeader colDoctorEnc;
        private ColumnHeader colFechaReg;
        private Button btnVolver;
        private Button btnEliminar;
    }
}