namespace Visual
{
    partial class frmCrearConsul
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreConsul = new System.Windows.Forms.TextBox();
            this.txtDireccionConsul = new System.Windows.Forms.TextBox();
            this.txtDoctorEnc = new System.Windows.Forms.TextBox();
            this.dtpFechaReg = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Consultorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del consultorio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección del consultorio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doctor Encargado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Registro:";
            // 
            // txtNombreConsul
            // 
            this.txtNombreConsul.Location = new System.Drawing.Point(270, 113);
            this.txtNombreConsul.Name = "txtNombreConsul";
            this.txtNombreConsul.Size = new System.Drawing.Size(200, 23);
            this.txtNombreConsul.TabIndex = 5;
            // 
            // txtDireccionConsul
            // 
            this.txtDireccionConsul.Location = new System.Drawing.Point(270, 157);
            this.txtDireccionConsul.Name = "txtDireccionConsul";
            this.txtDireccionConsul.Size = new System.Drawing.Size(200, 23);
            this.txtDireccionConsul.TabIndex = 6;
            this.txtDireccionConsul.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDoctorEnc
            // 
            this.txtDoctorEnc.Location = new System.Drawing.Point(270, 199);
            this.txtDoctorEnc.Name = "txtDoctorEnc";
            this.txtDoctorEnc.Size = new System.Drawing.Size(200, 23);
            this.txtDoctorEnc.TabIndex = 7;
            // 
            // dtpFechaReg
            // 
            this.dtpFechaReg.Location = new System.Drawing.Point(270, 246);
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaReg.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(215, 299);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 45);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmCrearConsul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 381);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFechaReg);
            this.Controls.Add(this.txtDoctorEnc);
            this.Controls.Add(this.txtDireccionConsul);
            this.Controls.Add(this.txtNombreConsul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearConsul";
            this.Text = "Crear Consultorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreConsul;
        private TextBox txtDireccionConsul;
        private TextBox txtDoctorEnc;
        private DateTimePicker dtpFechaReg;
        private Button btnRegistrar;
    }
}