namespace Consultorio
{
    partial class MedicosF
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
            this.dtMedico = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMedico
            // 
            this.dtMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMedico.Location = new System.Drawing.Point(12, 84);
            this.dtMedico.Name = "dtMedico";
            this.dtMedico.Size = new System.Drawing.Size(538, 354);
            this.dtMedico.TabIndex = 0;
            this.dtMedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMedico_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Consultorio.Properties.Resources.agregar1;
            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 55);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Medico";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // MedicosF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtMedico);
            this.Name = "MedicosF";
            this.Text = "Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.dtMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMedico;
        private System.Windows.Forms.Button btnAgregar;
    }
}