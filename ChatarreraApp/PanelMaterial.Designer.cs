namespace ChatarreraApp {
    partial class PanelMaterial {
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
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelAgregarMaterial = new System.Windows.Forms.Panel();
            this.panelSubs = new System.Windows.Forms.Panel();
            this.buttonAgregarSubMaterial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAgregarMaterial = new System.Windows.Forms.Button();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.panelPrecios = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdatePrecios = new System.Windows.Forms.Button();
            this.panelAgregarMaterial.SuspendLayout();
            this.panelPrecios.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar material";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(4, 3);
            this.treeView1.Margin = new System.Windows.Forms.Padding(5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(219, 440);
            this.treeView1.TabIndex = 1;
            // 
            // panelAgregarMaterial
            // 
            this.panelAgregarMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAgregarMaterial.Controls.Add(this.panelSubs);
            this.panelAgregarMaterial.Controls.Add(this.buttonAgregarSubMaterial);
            this.panelAgregarMaterial.Controls.Add(this.label2);
            this.panelAgregarMaterial.Controls.Add(this.buttonAgregarMaterial);
            this.panelAgregarMaterial.Controls.Add(this.textBoxMaterial);
            this.panelAgregarMaterial.Controls.Add(this.labelMaterial);
            this.panelAgregarMaterial.Controls.Add(this.label1);
            this.panelAgregarMaterial.Location = new System.Drawing.Point(661, 55);
            this.panelAgregarMaterial.Name = "panelAgregarMaterial";
            this.panelAgregarMaterial.Size = new System.Drawing.Size(254, 403);
            this.panelAgregarMaterial.TabIndex = 2;
            // 
            // panelSubs
            // 
            this.panelSubs.AutoScroll = true;
            this.panelSubs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubs.Location = new System.Drawing.Point(13, 115);
            this.panelSubs.Name = "panelSubs";
            this.panelSubs.Size = new System.Drawing.Size(222, 235);
            this.panelSubs.TabIndex = 6;
            // 
            // buttonAgregarSubMaterial
            // 
            this.buttonAgregarSubMaterial.Location = new System.Drawing.Point(120, 82);
            this.buttonAgregarSubMaterial.Name = "buttonAgregarSubMaterial";
            this.buttonAgregarSubMaterial.Size = new System.Drawing.Size(27, 27);
            this.buttonAgregarSubMaterial.TabIndex = 5;
            this.buttonAgregarSubMaterial.Text = "+";
            this.buttonAgregarSubMaterial.UseVisualStyleBackColor = true;
            this.buttonAgregarSubMaterial.Click += new System.EventHandler(this.buttonAgregarSubMaterial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SubMaterial";
            // 
            // buttonAgregarMaterial
            // 
            this.buttonAgregarMaterial.Location = new System.Drawing.Point(9, 356);
            this.buttonAgregarMaterial.Name = "buttonAgregarMaterial";
            this.buttonAgregarMaterial.Size = new System.Drawing.Size(75, 29);
            this.buttonAgregarMaterial.TabIndex = 3;
            this.buttonAgregarMaterial.Text = "Agregar";
            this.buttonAgregarMaterial.UseVisualStyleBackColor = true;
            this.buttonAgregarMaterial.Click += new System.EventHandler(this.buttonAgregarMaterial_Click);
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(97, 46);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(111, 26);
            this.textBoxMaterial.TabIndex = 2;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(21, 47);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(69, 20);
            this.labelMaterial.TabIndex = 1;
            this.labelMaterial.Text = "Material:";
            // 
            // panelPrecios
            // 
            this.panelPrecios.AutoScroll = true;
            this.panelPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrecios.Controls.Add(this.treeView1);
            this.panelPrecios.Location = new System.Drawing.Point(43, 36);
            this.panelPrecios.Name = "panelPrecios";
            this.panelPrecios.Size = new System.Drawing.Size(456, 450);
            this.panelPrecios.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // buttonUpdatePrecios
            // 
            this.buttonUpdatePrecios.Location = new System.Drawing.Point(505, 460);
            this.buttonUpdatePrecios.Name = "buttonUpdatePrecios";
            this.buttonUpdatePrecios.Size = new System.Drawing.Size(134, 26);
            this.buttonUpdatePrecios.TabIndex = 6;
            this.buttonUpdatePrecios.Text = "Guardar Precios";
            this.buttonUpdatePrecios.UseVisualStyleBackColor = true;
            this.buttonUpdatePrecios.Click += new System.EventHandler(this.buttonUpdatePrecios_Click);
            // 
            // PanelMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonUpdatePrecios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelAgregarMaterial);
            this.Controls.Add(this.panelPrecios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelMaterial";
            this.Size = new System.Drawing.Size(1050, 515);
            this.panelAgregarMaterial.ResumeLayout(false);
            this.panelAgregarMaterial.PerformLayout();
            this.panelPrecios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panelAgregarMaterial;
        private System.Windows.Forms.Button buttonAgregarMaterial;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSubs;
        private System.Windows.Forms.Button buttonAgregarSubMaterial;
        private System.Windows.Forms.Panel panelPrecios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdatePrecios;
    }
}
