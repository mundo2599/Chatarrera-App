using System;
using System.Windows.Forms;

namespace ChatarreraApp {

    public partial class PanelConfigs : UserControl {

        private Configs configs;

        public PanelConfigs() {
            InitializeComponent();
        }

        public Configs Configs {
            get => configs;
            set {
                configs = value;
                textBoxDireccion.Text = configs.DireccionArchivo;
                textBoxLineaEntrada.Text = configs.LineaActualEntrada.ToString();
                dateTimeEntrada.Value = configs.DateActualEntrada;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e) {
            try {
                configs.LineaActualEntrada = int.Parse(textBoxLineaEntrada.Text);
            } catch {
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            configs.DireccionArchivo = textBoxDireccion.Text;
            configs.DateActualEntrada = dateTimeEntrada.Value;
        }
    }
}
