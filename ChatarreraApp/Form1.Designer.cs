namespace ChatarreraApp
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCompras = new System.Windows.Forms.TabPage();
            this.panelGuardado = new System.Windows.Forms.Panel();
            this.buttonGuardarCompras = new System.Windows.Forms.Button();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.panelEntradas = new System.Windows.Forms.Panel();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxPagado = new System.Windows.Forms.TextBox();
            this.labelPagado = new System.Windows.Forms.Label();
            this.textBoxKg = new System.Windows.Forms.TextBox();
            this.labelKg = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.tabPageMateriales = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPageCompras.SuspendLayout();
            this.panelGuardado.SuspendLayout();
            this.panelIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMateriales);
            this.tabControl.Controls.Add(this.tabPageCompras);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1066, 558);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCompras
            // 
            this.tabPageCompras.Controls.Add(this.panelGuardado);
            this.tabPageCompras.Controls.Add(this.panelTabla);
            this.tabPageCompras.Controls.Add(this.panelEntradas);
            this.tabPageCompras.Controls.Add(this.panelIntro);
            this.tabPageCompras.Location = new System.Drawing.Point(4, 29);
            this.tabPageCompras.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCompras.Name = "tabPageCompras";
            this.tabPageCompras.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCompras.Size = new System.Drawing.Size(1058, 525);
            this.tabPageCompras.TabIndex = 0;
            this.tabPageCompras.Text = "Compras";
            this.tabPageCompras.UseVisualStyleBackColor = true;
            // 
            // panelGuardado
            // 
            this.panelGuardado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGuardado.Controls.Add(this.buttonGuardarCompras);
            this.panelGuardado.Location = new System.Drawing.Point(755, 4);
            this.panelGuardado.Name = "panelGuardado";
            this.panelGuardado.Size = new System.Drawing.Size(303, 61);
            this.panelGuardado.TabIndex = 3;
            // 
            // buttonGuardarCompras
            // 
            this.buttonGuardarCompras.Location = new System.Drawing.Point(16, 15);
            this.buttonGuardarCompras.Name = "buttonGuardarCompras";
            this.buttonGuardarCompras.Size = new System.Drawing.Size(80, 27);
            this.buttonGuardarCompras.TabIndex = 0;
            this.buttonGuardarCompras.Text = "Guardar";
            this.buttonGuardarCompras.UseVisualStyleBackColor = true;
            // 
            // panelTabla
            // 
            this.panelTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTabla.Location = new System.Drawing.Point(755, 65);
            this.panelTabla.Margin = new System.Windows.Forms.Padding(4);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(303, 458);
            this.panelTabla.TabIndex = 2;
            // 
            // panelEntradas
            // 
            this.panelEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEntradas.Location = new System.Drawing.Point(0, 65);
            this.panelEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.panelEntradas.Name = "panelEntradas";
            this.panelEntradas.Size = new System.Drawing.Size(755, 458);
            this.panelEntradas.TabIndex = 1;
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
            this.panelIntro.Location = new System.Drawing.Point(0, 4);
            this.panelIntro.Margin = new System.Windows.Forms.Padding(4);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(755, 61);
            this.panelIntro.TabIndex = 0;
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
            // tabPageMateriales
            // 
            this.tabPageMateriales.Location = new System.Drawing.Point(4, 29);
            this.tabPageMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMateriales.Name = "tabPageMateriales";
            this.tabPageMateriales.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMateriales.Size = new System.Drawing.Size(1058, 525);
            this.tabPageMateriales.TabIndex = 1;
            this.tabPageMateriales.Text = "Materiales";
            this.tabPageMateriales.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 557);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Chatarrera";
            this.tabControl.ResumeLayout(false);
            this.tabPageCompras.ResumeLayout(false);
            this.panelGuardado.ResumeLayout(false);
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCompras;
        private System.Windows.Forms.TabPage tabPageMateriales;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.Panel panelEntradas;
        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Panel panelGuardado;
        private System.Windows.Forms.Button buttonGuardarCompras;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxPagado;
        private System.Windows.Forms.Label labelPagado;
        private System.Windows.Forms.TextBox textBoxKg;
        private System.Windows.Forms.Label labelKg;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
    }
}

