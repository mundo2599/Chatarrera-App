using System;
using System.Windows.Forms;

namespace ChatarreraApp {
    class PanelFilaDatos : FlowLayoutPanel {
        ComboBox comboBox;
        Label labelKg, labelPagado, labelMaterial;
        TextBox textBoxKg, textBoxPagado;
        Button buttonEditarGuardar, buttonEliminarCancelar;

        int materialAnterior;
        decimal kgAnterior, pagadoAnterior;

        Compras compras;
        Func<int, int> actualizar;

        public PanelFilaDatos(int material, decimal kg, decimal pagado, Compras compras, Func<int, int> metodo) {
            this.compras = compras;
            this.actualizar = metodo;

            this.AutoSize = true;
            this.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            this.Dock = DockStyle.Top;

            comboBox = new ComboBox() {
                Font = Form1.fuente,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Margin = new Padding(0, Form1.PAD_TOP, Form1.PAD_RIGHT, 0),
                Enabled = false
            };
            comboBox.Items.AddRange(compras.Objetos.ToArray());
            comboBox.SelectedIndex = material;

            this.labelMaterial = new Label() {
                Font = Form1.fuente,
                Margin = new Padding(Form1.PAD_LEFT, Form1.PAD_TOP, 0, 0),
                Text = "Material:",
                AutoSize = true
            };

            labelKg = new Label() {
                Text = "Kg:",
                Font = Form1.fuente,
                Margin = new Padding(0, Form1.PAD_TOP, 0, 0),
                AutoSize = true
            };

            textBoxKg = new TextBox() {
                Font = Form1.fuente,
                Margin = new Padding(0, Form1.PAD_TOP, Form1.PAD_RIGHT, 0),
                Text = kg.ToString(),
                Enabled = false,
                Width = Form1.TEXT_BOX_WIDHT
            };

            labelPagado = new Label() {
                Text = "Pagado:",
                Font = Form1.fuente,
                Margin = new Padding(0, Form1.PAD_TOP, 0, 0),
                AutoSize = true
            };

            textBoxPagado = new TextBox() {
                Font = Form1.fuente,
                Margin = new Padding(0, Form1.PAD_TOP, 0, 0),
                Text = pagado.ToString(),
                Enabled = false,
                Width = Form1.TEXT_BOX_WIDHT
            };

            buttonEditarGuardar = new Button() {
                Text = "Editar",
                Font = Form1.fuente,
                Margin = new Padding(Form1.PAD_LEFT, Form1.PAD_TOP, 0, 0),
                AutoSize = true,
            };
            buttonEditarGuardar.Click += buttonEditarGuardar_Click;

            buttonEliminarCancelar = new Button() {
                Text = "Eliminar",
                Font = Form1.fuente,
                Margin = new Padding(Form1.PAD_LEFT, Form1.PAD_TOP, 0, 0),
                AutoSize = true,
            };
            buttonEliminarCancelar.Click += buttonEliminarCancelar_Click;

            this.Controls.Add(labelMaterial);
            this.Controls.Add(comboBox);
            this.Controls.Add(labelKg);
            this.Controls.Add(textBoxKg);
            this.Controls.Add(labelPagado);
            this.Controls.Add(textBoxPagado);
            this.Controls.Add(buttonEditarGuardar);
            this.Controls.Add(buttonEliminarCancelar);

        }//Fin Contructor

        //Button de Eliminar y cancelar
        private void buttonEliminarCancelar_Click(object sender, EventArgs e) {
            if (buttonEliminarCancelar.Text == "Eliminar") {//Eliminar
                compras.restarCompra(comboBox.SelectedIndex, decimal.Parse(textBoxKg.Text), decimal.Parse(textBoxPagado.Text));

                actualizar(comboBox.SelectedIndex);

                this.Dispose();

            } else {//Cancelar
                comboBox.SelectedIndex = materialAnterior;
                comboBox.Enabled = false;
                textBoxKg.Text = kgAnterior.ToString();
                textBoxKg.Enabled = false;
                textBoxPagado.Text = pagadoAnterior.ToString();
                textBoxPagado.Enabled = false;

                buttonEliminarCancelar.Text = "Eliminar";
                buttonEditarGuardar.Text = "Editar";
            }
        }

        //Button para cancelar y guardar
        private void buttonEditarGuardar_Click(object sender, EventArgs e) {
            if (buttonEditarGuardar.Text == "Editar") { //Editar
                materialAnterior = comboBox.SelectedIndex;
                kgAnterior = decimal.Parse(textBoxKg.Text);
                pagadoAnterior = decimal.Parse(textBoxPagado.Text);

                buttonEditarGuardar.Text = "Guardar";
                buttonEliminarCancelar.Text = "Cancelar";

                comboBox.Enabled = true;
                textBoxKg.Enabled = true;
                textBoxPagado.Enabled = true;


            } else {  //Guardar
                int material = comboBox.SelectedIndex;
                decimal kg = 0, pagado = 0;

                try {
                    kg = decimal.Parse(textBoxKg.Text);
                } catch {
                    MessageBox.Show("Revise los kilogramos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try {
                    pagado = decimal.Parse(textBoxPagado.Text);
                } catch {
                    MessageBox.Show("Revise lo pagado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (kg == 0 && pagado == 0) {
                    MessageBox.Show("Sin datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                buttonEditarGuardar.Text = "Editar";
                buttonEliminarCancelar.Text = "Eliminar";
                comboBox.Enabled = false;
                textBoxKg.Enabled = false;
                textBoxPagado.Enabled = false;

                compras.restarCompra(materialAnterior, kgAnterior, pagadoAnterior);
                compras.agregarCompra(material, kg, pagado);

                actualizar(comboBox.SelectedIndex);
                actualizar(materialAnterior);
            }
        }
    }//Fin clase PanelFilaDatos
}
