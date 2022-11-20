namespace Proyecto_Final_Calculadora
{
    partial class frmingresoempleado
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
            this.grpingredatoprof = new System.Windows.Forms.GroupBox();
            this.lblnombreprofe = new System.Windows.Forms.Label();
            this.lblsaldohora = new System.Windows.Forms.Label();
            this.lbldescrpprofe = new System.Windows.Forms.Label();
            this.lblprofcodigo = new System.Windows.Forms.Label();
            this.txtnombreprofe = new System.Windows.Forms.TextBox();
            this.txtsaldohora = new System.Windows.Forms.TextBox();
            this.txtprofecodig = new System.Windows.Forms.TextBox();
            this.txtdecripprof = new System.Windows.Forms.TextBox();
            this.lvwverdato = new System.Windows.Forms.ListView();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.grpingredatoprof.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpingredatoprof
            // 
            this.grpingredatoprof.Controls.Add(this.txtdecripprof);
            this.grpingredatoprof.Controls.Add(this.txtprofecodig);
            this.grpingredatoprof.Controls.Add(this.txtsaldohora);
            this.grpingredatoprof.Controls.Add(this.txtnombreprofe);
            this.grpingredatoprof.Controls.Add(this.lblprofcodigo);
            this.grpingredatoprof.Controls.Add(this.lbldescrpprofe);
            this.grpingredatoprof.Controls.Add(this.lblsaldohora);
            this.grpingredatoprof.Controls.Add(this.lblnombreprofe);
            this.grpingredatoprof.Location = new System.Drawing.Point(13, 13);
            this.grpingredatoprof.Name = "grpingredatoprof";
            this.grpingredatoprof.Size = new System.Drawing.Size(556, 110);
            this.grpingredatoprof.TabIndex = 0;
            this.grpingredatoprof.TabStop = false;
            this.grpingredatoprof.Text = "Ingreso de los Datos Según la Profesión";
            // 
            // lblnombreprofe
            // 
            this.lblnombreprofe.AutoSize = true;
            this.lblnombreprofe.Location = new System.Drawing.Point(10, 23);
            this.lblnombreprofe.Name = "lblnombreprofe";
            this.lblnombreprofe.Size = new System.Drawing.Size(117, 13);
            this.lblnombreprofe.TabIndex = 0;
            this.lblnombreprofe.Text = "Nombre de la Pofesión:";
            // 
            // lblsaldohora
            // 
            this.lblsaldohora.AutoSize = true;
            this.lblsaldohora.Location = new System.Drawing.Point(10, 56);
            this.lblsaldohora.Name = "lblsaldohora";
            this.lblsaldohora.Size = new System.Drawing.Size(81, 13);
            this.lblsaldohora.TabIndex = 1;
            this.lblsaldohora.Text = "Saldo por Hora:";
            // 
            // lbldescrpprofe
            // 
            this.lbldescrpprofe.AutoSize = true;
            this.lbldescrpprofe.Location = new System.Drawing.Point(248, 51);
            this.lbldescrpprofe.Name = "lbldescrpprofe";
            this.lbldescrpprofe.Size = new System.Drawing.Size(139, 13);
            this.lbldescrpprofe.TabIndex = 2;
            this.lbldescrpprofe.Text = "Descripción de la Profesion:";
            // 
            // lblprofcodigo
            // 
            this.lblprofcodigo.AutoSize = true;
            this.lblprofcodigo.Location = new System.Drawing.Point(248, 19);
            this.lblprofcodigo.Name = "lblprofcodigo";
            this.lblprofcodigo.Size = new System.Drawing.Size(93, 13);
            this.lblprofcodigo.TabIndex = 3;
            this.lblprofcodigo.Text = "Profesion(Codigo):";
            // 
            // txtnombreprofe
            // 
            this.txtnombreprofe.Location = new System.Drawing.Point(130, 19);
            this.txtnombreprofe.Name = "txtnombreprofe";
            this.txtnombreprofe.Size = new System.Drawing.Size(100, 20);
            this.txtnombreprofe.TabIndex = 4;
            // 
            // txtsaldohora
            // 
            this.txtsaldohora.Location = new System.Drawing.Point(130, 53);
            this.txtsaldohora.Name = "txtsaldohora";
            this.txtsaldohora.Size = new System.Drawing.Size(100, 20);
            this.txtsaldohora.TabIndex = 5;
            // 
            // txtprofecodig
            // 
            this.txtprofecodig.Location = new System.Drawing.Point(390, 16);
            this.txtprofecodig.Name = "txtprofecodig";
            this.txtprofecodig.Size = new System.Drawing.Size(100, 20);
            this.txtprofecodig.TabIndex = 6;
            // 
            // txtdecripprof
            // 
            this.txtdecripprof.Location = new System.Drawing.Point(390, 48);
            this.txtdecripprof.Multiline = true;
            this.txtdecripprof.Name = "txtdecripprof";
            this.txtdecripprof.Size = new System.Drawing.Size(160, 56);
            this.txtdecripprof.TabIndex = 7;
            // 
            // lvwverdato
            // 
            this.lvwverdato.HideSelection = false;
            this.lvwverdato.Location = new System.Drawing.Point(13, 144);
            this.lvwverdato.Name = "lvwverdato";
            this.lvwverdato.Size = new System.Drawing.Size(556, 97);
            this.lvwverdato.TabIndex = 1;
            this.lvwverdato.UseCompatibleStateImageBehavior = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(13, 248);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 2;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(111, 247);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnmodif
            // 
            this.btnmodif.Location = new System.Drawing.Point(378, 248);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(75, 23);
            this.btnmodif.TabIndex = 4;
            this.btnmodif.Text = "Modificar";
            this.btnmodif.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(494, 247);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // frmingresoempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 282);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.lvwverdato);
            this.Controls.Add(this.grpingredatoprof);
            this.Name = "frmingresoempleado";
            this.Text = "Ingreso de Empleado según la profesión";
            this.grpingredatoprof.ResumeLayout(false);
            this.grpingredatoprof.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpingredatoprof;
        private System.Windows.Forms.TextBox txtdecripprof;
        private System.Windows.Forms.TextBox txtprofecodig;
        private System.Windows.Forms.TextBox txtsaldohora;
        private System.Windows.Forms.TextBox txtnombreprofe;
        private System.Windows.Forms.Label lblprofcodigo;
        private System.Windows.Forms.Label lbldescrpprofe;
        private System.Windows.Forms.Label lblsaldohora;
        private System.Windows.Forms.Label lblnombreprofe;
        private System.Windows.Forms.ListView lvwverdato;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button btnguardar;
    }
}