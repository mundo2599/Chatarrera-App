using System.Drawing;
using System.Windows.Forms;

namespace ChatarreraApp {

    public partial class PanelCompras : UserControl {

        Compras compras;
        //Configs configs;
        Form1 form;

        public PanelCompras() {
            InitializeComponent();
            this.compras = new Compras();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(tabla.Font, FontStyle.Bold);
            tabla.Rows[0].DefaultCellStyle = style;
            tabla[0, 0].Value = "TOTAL:";
            tabla[2, 0].Value = "0.0";
        }

        public void agregarMaterial(Material material) {
            this.compras.agregarObjeto(material);
            comboBoxMaterial.Items.Add(material.Nombre);
            tabla.Rows.Insert(tabla.Rows.Count - 1, material.Nombre, "0.0", "0.0");
        }

        public int actualizarTabla(int material) {
            tabla[1, material].Value = compras.Cantidad[material].ToString();
            tabla[2, material].Value = compras.Pagado[material].ToString();
            tabla[2, tabla.Rows.Count - 1].Value = compras.TotalPagado;
            return 0;
        }

        //=------------------------Eventos--------------------------------------------------------------------------------------------------------------------------//

        //Agregar entrada
        private void buttonAgregar_Click(object sender, System.EventArgs e) {
            int material = comboBoxMaterial.SelectedIndex;
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

            compras.agregarCompra(material, kg, pagado);

            panelEntradas.Controls.Add(new PanelFilaDatos(material, kg, pagado, compras, actualizarTabla));
            actualizarTabla(material);

            textBoxKg.Text = "0";
            textBoxPagado.Text = "0";
            comboBoxMaterial.Focus();
        }//fina de agregar entrada

        //Key event comboBox
        private void comboBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Down)
                if (!this.comboBoxMaterial.DroppedDown)
                    this.comboBoxMaterial.DroppedDown = true;

            if (e.KeyCode == Keys.Enter)
                textBoxKg.Focus();
        }//fin combo box key event

        private void textBoxKg_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                textBoxPagado.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxPagado_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                buttonAgregar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //----------------------------------------Setters y getters--------------------------------//
        public Compras Compras {
            set => compras = value;
            get => compras;
        }

        /*public Configs Configs {
            set => configs = value;
            get => configs;
        }*/

        public Form1 Form {
            set => form = value;
            get => form;
        }

        //guardar
        private void buttonGuardarCompras_Click(object sender, System.EventArgs e) {
            form.guardarEntradasExcel(compras, dateTimePicker1.Value);
        }
    }

}
