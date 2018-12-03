namespace Consultorio
{
    partial class MostrarCuentas
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtvCuentas = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsr = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Location = new System.Drawing.Point(12, 45);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(706, 306);
            this.tbControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtvCuentas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(698, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuentas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtvCuentas
            // 
            this.dtvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCuentas.Location = new System.Drawing.Point(6, 6);
            this.dtvCuentas.Name = "dtvCuentas";
            this.dtvCuentas.Size = new System.Drawing.Size(686, 301);
            this.dtvCuentas.TabIndex = 0;
            this.dtvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvCuentas_CellContentClick);
            this.dtvCuentas.DoubleClick += new System.EventHandler(this.dtvCuentas_DoubleClick);
            // 
            // btnAgregarUsr
            // 
            this.btnAgregarUsr.Location = new System.Drawing.Point(22, 12);
            this.btnAgregarUsr.Name = "btnAgregarUsr";
            this.btnAgregarUsr.Size = new System.Drawing.Size(137, 23);
            this.btnAgregarUsr.TabIndex = 1;
            this.btnAgregarUsr.Text = "Agregar usuarios";
            this.btnAgregarUsr.UseVisualStyleBackColor = true;
            this.btnAgregarUsr.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(618, 16);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MostrarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 362);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregarUsr);
            this.Controls.Add(this.tbControl);
            this.Name = "MostrarCuentas";
            this.Text = "MostrarCuentas";
            this.Load += new System.EventHandler(this.MostrarCuentas_Load);
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtvCuentas;
        private System.Windows.Forms.Button btnAgregarUsr;
        private System.Windows.Forms.Button btnCerrar;
    }
}