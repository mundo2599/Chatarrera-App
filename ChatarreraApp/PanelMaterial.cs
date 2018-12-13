using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChatarreraApp {
    public partial class PanelMaterial : UserControl {

        public Configs configs;
        public Form1 form;

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
                Location = new System.Drawing.Point(190, 7 + (30 * textBoxesPrecios.Count)),
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
                    Location = new System.Drawing.Point(190, 7 + (30 * textBoxesPrecios.Count)),
                    Text = subMateriales[i++].Precio.ToString()
                };  //nuevo text box de precio
                this.panelPrecios.Controls.Add(t);
                textBoxesPrecios.Add(t);
            }

            treeView1.ExpandAll();
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
            //verificar que el campo no este vacio
            //verificar si el material ya existe

            Material material = new Material(textBoxMaterial.Text);
            List<Material> subMateriales = new List<Material>();
            foreach (TextBox t in textBoxesSubs) {
                //verificar campo t
                subMateriales.Add(new Material(t.Text));
            }

            textBoxesSubs.Clear();
            textBoxMaterial.Clear();
            panelSubs.Controls.Clear();

            Form.agregarMaterial(material, subMateriales);
            //limpiar panel de agregar entrada
        }

        //guardar cambios en precios
        private void buttonUpdatePrecios_Click(object sender, EventArgs e) {
            int i = 0;
            foreach(TreeNode treeC in treeView1.Nodes) {
                configs.actualizarPrecio(treeC.Text, decimal.Parse(textBoxesPrecios[i++].Text));
                foreach (TreeNode treeNode in treeC.Nodes) {
                    configs.actualizarPrecio(treeNode.Text, decimal.Parse(textBoxesPrecios[i++].Text));
                } 
            }
            Configs.guardar(configs);
        }

        //----------------------------------------Setters y getters--------------------------------//
        public Configs Configs {
            set {
                configs = value;
                //limpiar treeview y cargarlo de nuevo de config
                treeView1.Nodes.Clear();
                foreach (var v in configs.DictionaryMateriales) {
                    agregarMaterial(v.Key, v.Value);
                }
            }
            get => configs;
        }

        public Form1 Form {
            set => form = value;
            get => form;
        }
    }
}
