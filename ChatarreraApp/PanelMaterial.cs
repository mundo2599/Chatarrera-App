using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChatarreraApp {
    public partial class PanelMaterial : UserControl {

        private Configs configs;
        private Form1 form;

        private List<TextBox> textBoxesSubs;
        private List<TextBox> textBoxesPrecios;

        public PanelMaterial() {
            InitializeComponent();
            textBoxesSubs = new List<TextBox>();
            textBoxesPrecios = new List<TextBox>();
        }

        public void agregarMaterial(Material material, List<Material> subMateriales) {
            //agregar material al treeview
            treeView1.Nodes.Add(material.Nombre);
            //agregar textbox para el precio
            var t = new TextBox() {
                Size = new System.Drawing.Size(100, 26),
                Location = new System.Drawing.Point(250, 7 + (30 * textBoxesPrecios.Count)),
                Text = material.Precio.ToString()
            };  //nuevo text box de precio
            this.panelPrecios.Controls.Add(t);
            textBoxesPrecios.Add(t);

            int i = 0;
            foreach (Material s in subMateriales) {
                treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Add(s.Nombre);
                //agregar textbox para el precio
                t = new TextBox() {
                    Size = new System.Drawing.Size(100, 26),
                    Location = new System.Drawing.Point(250, 7 + (30 * textBoxesPrecios.Count)),
                    Text = subMateriales[i++].Precio.ToString()
                };  //nuevo text box de precio
                this.panelPrecios.Controls.Add(t);
                textBoxesPrecios.Add(t);
            }

            treeView1.Height = panelPrecios.DisplayRectangle.Height;
            treeView1.ExpandAll();
        }

        public void recargar() {
            foreach(TextBox t in textBoxesPrecios)
                t.Dispose();
            textBoxesPrecios.Clear();
            
            treeView1.Nodes.Clear();
            foreach (var v in configs.DictionaryMateriales)
                agregarMaterial(v.Key, v.Value);
        }

        //-------------------------------------Eventos------------------------------------//
        //agregar submaterial
        private void buttonAgregarSubMaterial_Click(object sender, EventArgs e) {
            TextBox textBox = new TextBox() {
                Size = new System.Drawing.Size(125, 26),
                Location = new System.Drawing.Point(10, 10 + (30 * textBoxesSubs.Count))
            };

            textBoxesSubs.Add(textBox);
            panelSubs.Controls.Add(textBox);
        }
   
        //agregar material
        private void buttonAgregarMaterial_Click(object sender, EventArgs e) {
            if(textBoxMaterial.Text.Length == 0) {//si esta vacio el campo
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            Material material = new Material(textBoxMaterial.Text);
            List<Material> subMateriales = new List<Material>();
            foreach (TextBox t in textBoxesSubs) {
                if (t.Text.Length != 0) {
                    subMateriales.Add(new Material(t.Text));
                }
            }

            //verificar si el material ya existe
            if (configs.buscarMaterial(textBoxMaterial.Text) != null) {//si el amterial ya existe
                Form.agregarSubMateriales(material, subMateriales);
            } else {
                Form.agregarNuevoMaterial(material, subMateriales);
            }

            //limpiar panel de agregar entrada
            textBoxesSubs.Clear();
            textBoxMaterial.Clear();
            panelSubs.Controls.Clear();
        }

        //guardar cambios en precios
        private void buttonUpdatePrecios_Click(object sender, EventArgs e) {
            int i = 0;
            try {
                foreach (TreeNode treeC in treeView1.Nodes) {
                    configs.actualizarPrecio(treeC.Text, decimal.Parse(textBoxesPrecios[i++].Text));
                    foreach (TreeNode treeNode in treeC.Nodes) {
                        configs.actualizarPrecio(treeNode.Text, decimal.Parse(textBoxesPrecios[i++].Text));
                    }
                }
            } catch {
                System.Media.SystemSounds.Beep.Play();
                return;
                //error al castear a decimal
            }
            Configs.guardar(configs);
            form.actualizarPrecios();
        }

        //----------------------------------------Setters y getters--------------------------------//
        public Configs Configs {
            /*set {
                configs = value;
                //limpiar treeview y cargarlo de nuevo de config
                treeView1.Nodes.Clear();
                if(configs != null)
                    foreach (var v in configs.DictionaryMateriales)
                        agregarMaterial(v.Key, v.Value);
            }*/
            set => configs = value;
            get => configs;
        }

        public Form1 Form {
            set => form = value;
            get => form;
        }
    }
}
