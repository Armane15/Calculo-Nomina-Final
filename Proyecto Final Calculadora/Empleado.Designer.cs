namespace Proyecto_Final_Calculadora
{
    partial class frmempleado
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
            this.grpdatoempleado = new System.Windows.Forms.GroupBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblprimerapellido = new System.Windows.Forms.Label();
            this.lblsegundoapellido = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblfechanaci = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtprimerapelli = new System.Windows.Forms.TextBox();
            this.txtsegunapellido = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.cmbfechanaci = new System.Windows.Forms.ComboBox();
            this.lblselecprofe = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lvwverdato = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grpdatoempleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpdatoempleado
            // 
            this.grpdatoempleado.Controls.Add(this.comboBox3);
            this.grpdatoempleado.Controls.Add(this.lblselecprofe);
            this.grpdatoempleado.Controls.Add(this.cmbfechanaci);
            this.grpdatoempleado.Controls.Add(this.cmbsexo);
            this.grpdatoempleado.Controls.Add(this.txtcedula);
            this.grpdatoempleado.Controls.Add(this.txtsegunapellido);
            this.grpdatoempleado.Controls.Add(this.txtprimerapelli);
            this.grpdatoempleado.Controls.Add(this.txtnombre);
            this.grpdatoempleado.Controls.Add(this.lblfechanaci);
            this.grpdatoempleado.Controls.Add(this.lblsexo);
            this.grpdatoempleado.Controls.Add(this.lblcedula);
            this.grpdatoempleado.Controls.Add(this.lblsegundoapellido);
            this.grpdatoempleado.Controls.Add(this.lblprimerapellido);
            this.grpdatoempleado.Controls.Add(this.lblnombre);
            this.grpdatoempleado.Location = new System.Drawing.Point(12, 12);
            this.grpdatoempleado.Name = "grpdatoempleado";
            this.grpdatoempleado.Size = new System.Drawing.Size(277, 259);
            this.grpdatoempleado.TabIndex = 0;
            this.grpdatoempleado.TabStop = false;
            this.grpdatoempleado.Text = "Registro de los datos del empleado";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(7, 29);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblprimerapellido
            // 
            this.lblprimerapellido.AutoSize = true;
            this.lblprimerapellido.Location = new System.Drawing.Point(6, 64);
            this.lblprimerapellido.Name = "lblprimerapellido";
            this.lblprimerapellido.Size = new System.Drawing.Size(79, 13);
            this.lblprimerapellido.TabIndex = 1;
            this.lblprimerapellido.Text = "Primer Apellido:\r\n";
            // 
            // lblsegundoapellido
            // 
            this.lblsegundoapellido.AutoSize = true;
            this.lblsegundoapellido.Location = new System.Drawing.Point(6, 95);
            this.lblsegundoapellido.Name = "lblsegundoapellido";
            this.lblsegundoapellido.Size = new System.Drawing.Size(93, 13);
            this.lblsegundoapellido.TabIndex = 2;
            this.lblsegundoapellido.Text = "Segundo Apellido:\r\n";
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Location = new System.Drawing.Point(6, 126);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(43, 13);
            this.lblcedula.TabIndex = 3;
            this.lblcedula.Text = "Cedula:";
            this.lblcedula.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(6, 160);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(34, 13);
            this.lblsexo.TabIndex = 4;
            this.lblsexo.Text = "Sexo:";
            // 
            // lblfechanaci
            // 
            this.lblfechanaci.AutoSize = true;
            this.lblfechanaci.Location = new System.Drawing.Point(7, 196);
            this.lblfechanaci.Name = "lblfechanaci";
            this.lblfechanaci.Size = new System.Drawing.Size(111, 13);
            this.lblfechanaci.TabIndex = 5;
            this.lblfechanaci.Text = "Fecha de Nacimiento:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(129, 29);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtprimerapelli
            // 
            this.txtprimerapelli.Location = new System.Drawing.Point(129, 64);
            this.txtprimerapelli.Name = "txtprimerapelli";
            this.txtprimerapelli.Size = new System.Drawing.Size(100, 20);
            this.txtprimerapelli.TabIndex = 7;
            // 
            // txtsegunapellido
            // 
            this.txtsegunapellido.Location = new System.Drawing.Point(129, 95);
            this.txtsegunapellido.Name = "txtsegunapellido";
            this.txtsegunapellido.Size = new System.Drawing.Size(100, 20);
            this.txtsegunapellido.TabIndex = 8;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(129, 126);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 9;
            // 
            // cmbsexo
            // 
            this.cmbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsexo.Location = new System.Drawing.Point(129, 160);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(121, 21);
            this.cmbsexo.TabIndex = 10;
            // 
            // cmbfechanaci
            // 
            this.cmbfechanaci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfechanaci.FormattingEnabled = true;
            this.cmbfechanaci.Location = new System.Drawing.Point(129, 193);
            this.cmbfechanaci.Name = "cmbfechanaci";
            this.cmbfechanaci.Size = new System.Drawing.Size(121, 21);
            this.cmbfechanaci.TabIndex = 11;
            // 
            // lblselecprofe
            // 
            this.lblselecprofe.AutoSize = true;
            this.lblselecprofe.Location = new System.Drawing.Point(7, 229);
            this.lblselecprofe.Name = "lblselecprofe";
            this.lblselecprofe.Size = new System.Drawing.Size(121, 13);
            this.lblselecprofe.TabIndex = 12;
            this.lblselecprofe.Text = "Seleccione la Profesión:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(129, 226);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // lvwverdato
            // 
            this.lvwverdato.HideSelection = false;
            this.lvwverdato.Location = new System.Drawing.Point(331, 13);
            this.lvwverdato.Name = "lvwverdato";
            this.lvwverdato.Size = new System.Drawing.Size(284, 258);
            this.lvwverdato.TabIndex = 1;
            this.lvwverdato.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 320);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvwverdato);
            this.Controls.Add(this.grpdatoempleado);
            this.Name = "frmempleado";
            this.Text = "Ingreso de Empleado";
            this.grpdatoempleado.ResumeLayout(false);
            this.grpdatoempleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpdatoempleado;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label lblsegundoapellido;
        private System.Windows.Forms.Label lblprimerapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblfechanaci;
        private System.Windows.Forms.ComboBox cmbfechanaci;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtsegunapellido;
        private System.Windows.Forms.TextBox txtprimerapelli;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblselecprofe;
        private System.Windows.Forms.ListView lvwverdato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}