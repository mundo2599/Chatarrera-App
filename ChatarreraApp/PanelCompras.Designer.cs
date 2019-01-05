namespace ChatarreraApp {
    partial class PanelCompras {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelGuardado = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonGuardarCompras = new System.Windows.Forms.Button();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.ColumnMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEntradas = new System.Windows.Forms.Panel();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxPagado = new System.Windows.Forms.TextBox();
            this.labelPagado = new System.Windows.Forms.Label();
            this.textBoxKg = new System.Windows.Forms.TextBox();
            this.labelKg = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.panelGuardado.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.panelIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGuardado
            // 
            this.panelGuardado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGuardado.Controls.Add(this.dateTimePicker1);
            this.panelGuardado.Controls.Add(this.buttonGuardarCompras);
            this.panelGuardado.Location = new System.Drawing.Point(716, -2);
            this.panelGuardado.Name = "panelGuardado";
            this.panelGuardado.Size = new System.Drawing.Size(334, 61);
            this.panelGuardado.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonGuardarCompras
            // 
            this.buttonGuardarCompras.Location = new System.Drawing.Point(185, 14);
            this.buttonGuardarCompras.Name = "buttonGuardarCompras";
            this.buttonGuardarCompras.Size = new System.Drawing.Size(80, 27);
            this.buttonGuardarCompras.TabIndex = 0;
            this.buttonGuardarCompras.Text = "Guardar";
            this.buttonGuardarCompras.UseVisualStyleBackColor = true;
            this.buttonGuardarCompras.Click += new System.EventHandler(this.buttonGuardarCompras_Click);
            // 
            // panelTabla
            // 
            this.panelTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTabla.Controls.Add(this.tabla);
            this.panelTabla.Location = new System.Drawing.Point(716, 59);
            this.panelTabla.Margin = new System.Windows.Forms.Padding(4);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(333, 458);
            this.panelTabla.TabIndex = 6;
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaterial,
            this.ColumnKg,
            this.ColumnPagado});
            this.tabla.Location = new System.Drawing.Point(6, 5);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersVisible = false;
            this.tabla.Size = new System.Drawing.Size(322, 447);
            this.tabla.TabIndex = 0;
            // 
            // ColumnMaterial
            // 
            this.ColumnMaterial.HeaderText = "Material";
            this.ColumnMaterial.Name = "ColumnMaterial";
            // 
            // ColumnKg
            // 
            this.ColumnKg.HeaderText = "Kg";
            this.ColumnKg.Name = "ColumnKg";
            // 
            // ColumnPagado
            // 
            this.ColumnPagado.HeaderText = "Pagado";
            this.ColumnPagado.Name = "ColumnPagado";
            // 
            // panelEntradas
            // 
            this.panelEntradas.AutoScroll = true;
            this.panelEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEntradas.Location = new System.Drawing.Point(-4, 59);
            this.panelEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.panelEntradas.Name = "panelEntradas";
            this.panelEntradas.Size = new System.Drawing.Size(720, 458);
            this.panelEntradas.TabIndex = 5;
            // 
            // panelIntro
            // 
            this.panelIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIntro.Controls.Add(this.buttonAgregar);
            this.panelIntro.Controls.Add(this.textBoxPagado);
            this.panelIntro.Controls.Add(this.labelPagado);
            this.panelIntro.Controls.Add(this.textBoxKg);
            this.panelIntro.Controls.Add(this.labelKg);
            this.panelIntro.Controls.Add(this.comboBoxMaterial);
            this.panelIntro.Controls.Add(this.labelMaterial);
            this.panelIntro.Location = new System.Drawing.Point(-4, -2);
            this.panelIntro.Margin = new System.Windows.Forms.Padding(4);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(720, 61);
            this.panelIntro.TabIndex = 4;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(588, 15);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 29);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxPagado
            // 
            this.textBoxPagado.Location = new System.Drawing.Point(455, 15);
            this.textBoxPagado.Name = "textBoxPagado";
            this.textBoxPagado.Size = new System.Drawing.Size(100, 26);
            this.textBoxPagado.TabIndex = 5;
            this.textBoxPagado.Text = "0";
            this.textBoxPagado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPagado_KeyDown);
            // 
            // labelPagado
            // 
            this.labelPagado.AutoSize = true;
            this.labelPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagado.Location = new System.Drawing.Point(427, 18);
            this.labelPagado.Name = "labelPagado";
            this.labelPagado.Size = new System.Drawing.Size(24, 20);
            this.labelPagado.TabIndex = 4;
            this.labelPagado.Text = "$:";
            // 
            // textBoxKg
            // 
            this.textBoxKg.Location = new System.Drawing.Point(306, 15);
            this.textBoxKg.Name = "textBoxKg";
            this.textBoxKg.Size = new System.Drawing.Size(100, 26);
            this.textBoxKg.TabIndex = 3;
            this.textBoxKg.Text = "0";
            this.textBoxKg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKg_KeyDown);
            // 
            // labelKg
            // 
            this.labelKg.AutoSize = true;
            this.labelKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKg.Location = new System.Drawing.Point(268, 18);
            this.labelKg.Name = "labelKg";
            this.labelKg.Size = new System.Drawing.Size(35, 20);
            this.labelKg.TabIndex = 2;
            this.labelKg.Text = "Kg:";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(122, 15);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMaterial.TabIndex = 1;
            this.comboBoxMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterial.Location = new System.Drawing.Point(46, 18);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(78, 20);
            this.labelMaterial.TabIndex = 0;
            this.labelMaterial.Text = "Material:";
            // 
            // PanelCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGuardado);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelEntradas);
            this.Controls.Add(this.panelIntro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PanelCompras";
            this.Size = new System.Drawing.Size(1050, 515);
            this.panelGuardado.ResumeLayout(false);
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGuardado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonGuardarCompras;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.Panel panelEntradas;
        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxPagado;
        private System.Windows.Forms.Label labelPagado;
        private System.Windows.Forms.TextBox textBoxKg;
        private System.Windows.Forms.Label labelKg;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPagado;
    }
}
