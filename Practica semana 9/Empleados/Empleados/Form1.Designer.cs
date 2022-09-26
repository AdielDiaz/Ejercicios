
namespace Empleados
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnAFP = new System.Windows.Forms.Button();
            this.btnISSS = new System.Windows.Forms.Button();
            this.btnNeto = new System.Windows.Forms.Button();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtISSS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(90, 229);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(48, 44);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(48, 92);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(48, 139);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(29, 13);
            this.labelDUI.TabIndex = 3;
            this.labelDUI.Text = "DUI:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(119, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(119, 136);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 6;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(116, 264);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(48, 183);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(42, 13);
            this.labelSalario.TabIndex = 8;
            this.labelSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(119, 180);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 10;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(382, 41);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 11;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnAFP
            // 
            this.btnAFP.Location = new System.Drawing.Point(283, 39);
            this.btnAFP.Name = "btnAFP";
            this.btnAFP.Size = new System.Drawing.Size(75, 23);
            this.btnAFP.TabIndex = 12;
            this.btnAFP.Text = "AFP";
            this.btnAFP.UseVisualStyleBackColor = true;
            this.btnAFP.Click += new System.EventHandler(this.btnAFP_Click);
            // 
            // btnISSS
            // 
            this.btnISSS.Location = new System.Drawing.Point(283, 87);
            this.btnISSS.Name = "btnISSS";
            this.btnISSS.Size = new System.Drawing.Size(75, 23);
            this.btnISSS.TabIndex = 13;
            this.btnISSS.Text = "ISSS";
            this.btnISSS.UseVisualStyleBackColor = true;
            this.btnISSS.Click += new System.EventHandler(this.btnISSS_Click);
            // 
            // btnNeto
            // 
            this.btnNeto.Location = new System.Drawing.Point(283, 134);
            this.btnNeto.Name = "btnNeto";
            this.btnNeto.Size = new System.Drawing.Size(75, 23);
            this.btnNeto.TabIndex = 14;
            this.btnNeto.Text = "Neto";
            this.btnNeto.UseVisualStyleBackColor = true;
            this.btnNeto.Click += new System.EventHandler(this.btnNeto_Click);
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(382, 136);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(100, 20);
            this.txtNeto.TabIndex = 15;
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(382, 89);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(100, 20);
            this.txtISSS.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 331);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.btnNeto);
            this.Controls.Add(this.btnISSS);
            this.Controls.Add(this.btnAFP);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Button btnAFP;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Button btnNeto;
        private System.Windows.Forms.Button btnISSS;
    }
}

