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
            ChatarreraApp.Compras compras2 = new ChatarreraApp.Compras();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMateriales = new System.Windows.Forms.TabPage();
            this.tabPageCompras = new System.Windows.Forms.TabPage();
            this.tabPageConfigs = new System.Windows.Forms.TabPage();
            this.panelMaterial = new ChatarreraApp.PanelMaterial();
            this.panelCompras = new ChatarreraApp.PanelCompras();
            this.panelConfigs1 = new ChatarreraApp.PanelConfigs();
            this.tabControl.SuspendLayout();
            this.tabPageMateriales.SuspendLayout();
            this.tabPageCompras.SuspendLayout();
            this.tabPageConfigs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMateriales);
            this.tabControl.Controls.Add(this.tabPageCompras);
            this.tabControl.Controls.Add(this.tabPageConfigs);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1066, 558);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageMateriales
            // 
            this.tabPageMateriales.Controls.Add(this.panelMaterial);
            this.tabPageMateriales.Location = new System.Drawing.Point(4, 29);
            this.tabPageMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMateriales.Name = "tabPageMateriales";
            this.tabPageMateriales.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMateriales.Size = new System.Drawing.Size(1058, 525);
            this.tabPageMateriales.TabIndex = 1;
            this.tabPageMateriales.Text = "Materiales";
            this.tabPageMateriales.UseVisualStyleBackColor = true;
            // 
            // tabPageCompras
            // 
            this.tabPageCompras.Controls.Add(this.panelCompras);
            this.tabPageCompras.Location = new System.Drawing.Point(4, 29);
            this.tabPageCompras.Name = "tabPageCompras";
            this.tabPageCompras.Size = new System.Drawing.Size(1058, 525);
            this.tabPageCompras.TabIndex = 2;
            this.tabPageCompras.Text = "Compras";
            this.tabPageCompras.UseVisualStyleBackColor = true;
            // 
            // tabPageConfigs
            // 
            this.tabPageConfigs.Controls.Add(this.panelConfigs1);
            this.tabPageConfigs.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfigs.Name = "tabPageConfigs";
            this.tabPageConfigs.Size = new System.Drawing.Size(1058, 525);
            this.tabPageConfigs.TabIndex = 3;
            this.tabPageConfigs.Text = "Configuraciones";
            this.tabPageConfigs.UseVisualStyleBackColor = true;
            // 
            // panelMaterial
            // 
            this.panelMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaterial.Configs = null;
            this.panelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMaterial.Form = null;
            this.panelMaterial.Location = new System.Drawing.Point(4, 5);
            this.panelMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMaterial.Name = "panelMaterial";
            this.panelMaterial.Size = new System.Drawing.Size(1050, 515);
            this.panelMaterial.TabIndex = 0;
            // 
            // panelCompras
            // 
            this.panelCompras.Compras = compras2;
            this.panelCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCompras.Form = null;
            this.panelCompras.Location = new System.Drawing.Point(4, 4);
            this.panelCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(1050, 515);
            this.panelCompras.TabIndex = 0;
            // 
            // panelConfigs1
            // 
            this.panelConfigs1.Location = new System.Drawing.Point(0, 0);
            this.panelConfigs1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelConfigs1.Name = "panelConfigs1";
            this.panelConfigs1.Size = new System.Drawing.Size(1050, 515);
            this.panelConfigs1.TabIndex = 0;
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
            this.tabPageMateriales.ResumeLayout(false);
            this.tabPageCompras.ResumeLayout(false);
            this.tabPageConfigs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMateriales;
        private PanelMaterial panelMaterial;
        private System.Windows.Forms.TabPage tabPageCompras;
        private PanelCompras panelCompras;
        private System.Windows.Forms.TabPage tabPageConfigs;
        private PanelConfigs panelConfigs1;
    }
}

