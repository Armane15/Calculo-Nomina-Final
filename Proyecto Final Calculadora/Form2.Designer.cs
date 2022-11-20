namespace Proyecto_Final_Calculadora
{
    partial class frmcalculosalario
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
            this.grpinfempleado = new System.Windows.Forms.GroupBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.cmbbono = new System.Windows.Forms.ComboBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblbono = new System.Windows.Forms.Label();
            this.lbldescripprof = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.grpcargadato = new System.Windows.Forms.GroupBox();
            this.txthoraprof = new System.Windows.Forms.TextBox();
            this.txthoraextra = new System.Windows.Forms.TextBox();
            this.txthoraordinaria = new System.Windows.Forms.TextBox();
            this.txtnumconsecutivo = new System.Windows.Forms.TextBox();
            this.cmbingreempleado = new System.Windows.Forms.ComboBox();
            this.cmbfechahora = new System.Windows.Forms.ComboBox();
            this.lblfechaingrempleado = new System.Windows.Forms.Label();
            this.lblfechhoraingre = new System.Windows.Forms.Label();
            this.lblantiguedad = new System.Windows.Forms.Label();
            this.lblcosthora = new System.Windows.Forms.Label();
            this.lblhoraextra = new System.Windows.Forms.Label();
            this.lblhoraordi = new System.Windows.Forms.Label();
            this.lblnumconsec = new System.Windows.Forms.Label();
            this.lvvisualisardato = new System.Windows.Forms.ListView();
            this.btncerrar = new System.Windows.Forms.Button();
            this.bntlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.grpinfempleado.SuspendLayout();
            this.grpcargadato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpinfempleado
            // 
            this.grpinfempleado.Controls.Add(this.cmbsexo);
            this.grpinfempleado.Controls.Add(this.txtdescripcion);
            this.grpinfempleado.Controls.Add(this.cmbbono);
            this.grpinfempleado.Controls.Add(this.txtcedula);
            this.grpinfempleado.Controls.Add(this.txtedad);
            this.grpinfempleado.Controls.Add(this.txtnombre);
            this.grpinfempleado.Controls.Add(this.lblbono);
            this.grpinfempleado.Controls.Add(this.lbldescripprof);
            this.grpinfempleado.Controls.Add(this.lblsexo);
            this.grpinfempleado.Controls.Add(this.lblcedula);
            this.grpinfempleado.Controls.Add(this.lbledad);
            this.grpinfempleado.Controls.Add(this.lblnombre);
            this.grpinfempleado.Location = new System.Drawing.Point(13, 13);
            this.grpinfempleado.Name = "grpinfempleado";
            this.grpinfempleado.Size = new System.Drawing.Size(343, 233);
            this.grpinfempleado.TabIndex = 0;
            this.grpinfempleado.TabStop = false;
            this.grpinfempleado.Text = "Informacion del Empleado";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(148, 167);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 12;
            // 
            // cmbbono
            // 
            this.cmbbono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbono.FormattingEnabled = true;
            this.cmbbono.Items.AddRange(new object[] {
            "1-Aplica Bono",
            "2-No Aplica Bono"});
            this.cmbbono.Location = new System.Drawing.Point(148, 199);
            this.cmbbono.Name = "cmbbono";
            this.cmbbono.Size = new System.Drawing.Size(121, 21);
            this.cmbbono.TabIndex = 11;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(148, 106);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 8;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(148, 66);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(148, 34);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // lblbono
            // 
            this.lblbono.AutoSize = true;
            this.lblbono.Location = new System.Drawing.Point(7, 199);
            this.lblbono.Name = "lblbono";
            this.lblbono.Size = new System.Drawing.Size(128, 13);
            this.lblbono.TabIndex = 5;
            this.lblbono.Text = "Bono(Aplica o No Aplica):";
            // 
            // lbldescripprof
            // 
            this.lbldescripprof.AutoSize = true;
            this.lbldescripprof.Location = new System.Drawing.Point(6, 167);
            this.lbldescripprof.Name = "lbldescripprof";
            this.lbldescripprof.Size = new System.Drawing.Size(139, 13);
            this.lbldescripprof.TabIndex = 4;
            this.lbldescripprof.Text = "Descripción de la Profesion:\r\n";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(6, 138);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(34, 13);
            this.lblsexo.TabIndex = 3;
            this.lblsexo.Text = "Sexo:";
            this.lblsexo.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Location = new System.Drawing.Point(7, 106);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(43, 13);
            this.lblcedula.TabIndex = 2;
            this.lblcedula.Text = "Cedula:";
            this.lblcedula.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(7, 69);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(35, 13);
            this.lbledad.TabIndex = 1;
            this.lbledad.Text = "Edad:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(6, 34);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // grpcargadato
            // 
            this.grpcargadato.Controls.Add(this.txthoraprof);
            this.grpcargadato.Controls.Add(this.txthoraextra);
            this.grpcargadato.Controls.Add(this.txthoraordinaria);
            this.grpcargadato.Controls.Add(this.txtnumconsecutivo);
            this.grpcargadato.Controls.Add(this.cmbingreempleado);
            this.grpcargadato.Controls.Add(this.cmbfechahora);
            this.grpcargadato.Controls.Add(this.lblfechaingrempleado);
            this.grpcargadato.Controls.Add(this.lblfechhoraingre);
            this.grpcargadato.Controls.Add(this.lblantiguedad);
            this.grpcargadato.Controls.Add(this.lblcosthora);
            this.grpcargadato.Controls.Add(this.lblhoraextra);
            this.grpcargadato.Controls.Add(this.lblhoraordi);
            this.grpcargadato.Controls.Add(this.lblnumconsec);
            this.grpcargadato.Location = new System.Drawing.Point(372, 13);
            this.grpcargadato.Name = "grpcargadato";
            this.grpcargadato.Size = new System.Drawing.Size(288, 233);
            this.grpcargadato.TabIndex = 1;
            this.grpcargadato.TabStop = false;
            this.grpcargadato.Text = "Datos para la Carga de la planilla";
            this.grpcargadato.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txthoraprof
            // 
            this.txthoraprof.Location = new System.Drawing.Point(143, 103);
            this.txthoraprof.Name = "txthoraprof";
            this.txthoraprof.Size = new System.Drawing.Size(100, 20);
            this.txthoraprof.TabIndex = 12;
            // 
            // txthoraextra
            // 
            this.txthoraextra.Location = new System.Drawing.Point(143, 73);
            this.txthoraextra.Name = "txthoraextra";
            this.txthoraextra.Size = new System.Drawing.Size(100, 20);
            this.txthoraextra.TabIndex = 11;
            // 
            // txthoraordinaria
            // 
            this.txthoraordinaria.Location = new System.Drawing.Point(143, 41);
            this.txthoraordinaria.Name = "txthoraordinaria";
            this.txthoraordinaria.Size = new System.Drawing.Size(100, 20);
            this.txthoraordinaria.TabIndex = 10;
            // 
            // txtnumconsecutivo
            // 
            this.txtnumconsecutivo.Location = new System.Drawing.Point(143, 13);
            this.txtnumconsecutivo.Name = "txtnumconsecutivo";
            this.txtnumconsecutivo.Size = new System.Drawing.Size(100, 20);
            this.txtnumconsecutivo.TabIndex = 9;
            // 
            // cmbingreempleado
            // 
            this.cmbingreempleado.FormattingEnabled = true;
            this.cmbingreempleado.Location = new System.Drawing.Point(161, 195);
            this.cmbingreempleado.Name = "cmbingreempleado";
            this.cmbingreempleado.Size = new System.Drawing.Size(121, 21);
            this.cmbingreempleado.TabIndex = 8;
            // 
            // cmbfechahora
            // 
            this.cmbfechahora.FormattingEnabled = true;
            this.cmbfechahora.Location = new System.Drawing.Point(143, 136);
            this.cmbfechahora.Name = "cmbfechahora";
            this.cmbfechahora.Size = new System.Drawing.Size(121, 21);
            this.cmbfechahora.TabIndex = 7;
            // 
            // lblfechaingrempleado
            // 
            this.lblfechaingrempleado.AutoSize = true;
            this.lblfechaingrempleado.Location = new System.Drawing.Point(6, 198);
            this.lblfechaingrempleado.Name = "lblfechaingrempleado";
            this.lblfechaingrempleado.Size = new System.Drawing.Size(157, 13);
            this.lblfechaingrempleado.TabIndex = 6;
            this.lblfechaingrempleado.Text = "Fecha de Ingreso a la Empresa:";
            // 
            // lblfechhoraingre
            // 
            this.lblfechhoraingre.AutoSize = true;
            this.lblfechhoraingre.Location = new System.Drawing.Point(9, 141);
            this.lblfechhoraingre.Name = "lblfechhoraingre";
            this.lblfechhoraingre.Size = new System.Drawing.Size(127, 13);
            this.lblfechhoraingre.TabIndex = 5;
            this.lblfechhoraingre.Text = "Fecha y Hora de Ingreso:";
            // 
            // lblantiguedad
            // 
            this.lblantiguedad.AutoSize = true;
            this.lblantiguedad.Location = new System.Drawing.Point(88, 167);
            this.lblantiguedad.Name = "lblantiguedad";
            this.lblantiguedad.Size = new System.Drawing.Size(128, 13);
            this.lblantiguedad.TabIndex = 4;
            this.lblantiguedad.Text = "Antiguedad del Empleado";
            // 
            // lblcosthora
            // 
            this.lblcosthora.AutoSize = true;
            this.lblcosthora.Location = new System.Drawing.Point(9, 106);
            this.lblcosthora.Name = "lblcosthora";
            this.lblcosthora.Size = new System.Drawing.Size(127, 13);
            this.lblcosthora.TabIndex = 3;
            this.lblcosthora.Text = "Costo hora por Profeción:";
            // 
            // lblhoraextra
            // 
            this.lblhoraextra.AutoSize = true;
            this.lblhoraextra.Location = new System.Drawing.Point(9, 73);
            this.lblhoraextra.Name = "lblhoraextra";
            this.lblhoraextra.Size = new System.Drawing.Size(70, 13);
            this.lblhoraextra.TabIndex = 2;
            this.lblhoraextra.Text = "Horas Extras:";
            // 
            // lblhoraordi
            // 
            this.lblhoraordi.AutoSize = true;
            this.lblhoraordi.Location = new System.Drawing.Point(9, 41);
            this.lblhoraordi.Name = "lblhoraordi";
            this.lblhoraordi.Size = new System.Drawing.Size(88, 13);
            this.lblhoraordi.TabIndex = 1;
            this.lblhoraordi.Text = "Horas Ordinarias:";
            // 
            // lblnumconsec
            // 
            this.lblnumconsec.AutoSize = true;
            this.lblnumconsec.Location = new System.Drawing.Point(9, 16);
            this.lblnumconsec.Name = "lblnumconsec";
            this.lblnumconsec.Size = new System.Drawing.Size(112, 13);
            this.lblnumconsec.TabIndex = 0;
            this.lblnumconsec.Text = "Numero(Consecutivo):";
            this.lblnumconsec.Click += new System.EventHandler(this.label7_Click);
            // 
            // lvvisualisardato
            // 
            this.lvvisualisardato.HideSelection = false;
            this.lvvisualisardato.Location = new System.Drawing.Point(13, 265);
            this.lvvisualisardato.Name = "lvvisualisardato";
            this.lvvisualisardato.Size = new System.Drawing.Size(647, 173);
            this.lvvisualisardato.TabIndex = 2;
            this.lvvisualisardato.UseCompatibleStateImageBehavior = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(666, 265);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // bntlimpiar
            // 
            this.bntlimpiar.Location = new System.Drawing.Point(666, 294);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(75, 23);
            this.bntlimpiar.TabIndex = 4;
            this.bntlimpiar.Text = "Limpiar";
            this.bntlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(666, 323);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(667, 353);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 6;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // cmbsexo
            // 
            this.cmbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsexo.Location = new System.Drawing.Point(148, 136);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(100, 21);
            this.cmbsexo.TabIndex = 13;
            // 
            // frmcalculosalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.bntlimpiar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.lvvisualisardato);
            this.Controls.Add(this.grpcargadato);
            this.Controls.Add(this.grpinfempleado);
            this.Name = "frmcalculosalario";
            this.Text = "Calculo de Salario del Empleado";
            this.Load += new System.EventHandler(this.frmempleado_Load);
            this.grpinfempleado.ResumeLayout(false);
            this.grpinfempleado.PerformLayout();
            this.grpcargadato.ResumeLayout(false);
            this.grpcargadato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpinfempleado;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldescripprof;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox cmbbono;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblbono;
        private System.Windows.Forms.GroupBox grpcargadato;
        private System.Windows.Forms.Label lblnumconsec;
        private System.Windows.Forms.TextBox txthoraprof;
        private System.Windows.Forms.TextBox txthoraextra;
        private System.Windows.Forms.TextBox txthoraordinaria;
        private System.Windows.Forms.TextBox txtnumconsecutivo;
        private System.Windows.Forms.ComboBox cmbingreempleado;
        private System.Windows.Forms.ComboBox cmbfechahora;
        private System.Windows.Forms.Label lblfechaingrempleado;
        private System.Windows.Forms.Label lblfechhoraingre;
        private System.Windows.Forms.Label lblantiguedad;
        private System.Windows.Forms.Label lblcosthora;
        private System.Windows.Forms.Label lblhoraextra;
        private System.Windows.Forms.Label lblhoraordi;
        private System.Windows.Forms.ListView lvvisualisardato;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button bntlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.ComboBox cmbsexo;
    }
}