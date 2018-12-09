
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatarreraApp
{
    public partial class Form1 : Form {

        Compras compras;
        PanelTabla panelTable;

        //constructor
        public Form1() {
            InitializeComponent();

            compras = new Compras(1, "Perro", 3.5F, 4.3D, 5);

            comboBoxMaterial.Items.AddRange(compras.Objetos.ToArray());
            comboBoxMaterial.SelectedIndex = 0;

            panelTable = new PanelTabla(compras);
            panelTabla.Controls.Add(panelTable);
        }//fin constructor

        public int actualizarTabla(int material) {
            panelTable.actualizarLabel(material);
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

//------------------------------variables usadas por otras clases-------------------------------------------------------------------------//
        public static readonly Font fuenteNegrita = new Font("Arial", 12, FontStyle.Bold);
        public static Font fuente = new Font("Arial", 12, FontStyle.Regular);
        public static readonly int PAD_TOP = 24, PAD_BOT = 0, PAD_LEFT = 10, PAD_RIGHT = 20, TEXT_BOX_WIDHT = 70;

    }//fin form
}//fin namespace
