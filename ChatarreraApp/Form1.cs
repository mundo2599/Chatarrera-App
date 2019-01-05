
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChatarreraApp
{
    public partial class Form1 : Form {

        PanelTabla panelTable;

        Configs configs;
        ManejadorExcel excel;

        //constructor
        public Form1() {
            InitializeComponent();

            configs = Configs.cargar();
            if(configs is null)
                configs = new Configs();

            panelMaterial.Configs = configs;
            panelMaterial.Form = this;

            panelCompras.Form = this;

            panelConfigs1.Configs = configs;

            //agregar materiales
            foreach (var v in configs.DictionaryMateriales) 
                agregarMaterial(v.Key, v.Value);


            excel = new ManejadorExcel(configs);
            //Comprobar excel

        }//fin constructor

        public void guardarEntradasExcel(Compras compras, DateTime dateTime) {
            int res = excel.guardarEntrada(compras, dateTime);
            if (res == 1) {  
                MessageBox.Show("Los cambios se han guardado con exito", "Exito!");
            } else if(res == -1){ //si no existe el archivo
                if(crearArchivoExcel())//intentar crear un nuevo archivo
                    guardarEntradasExcel(compras, dateTime);
            }
            panelConfigs1.Configs = configs;
        }

        public void guardarSalidasExcel() {
            //pendiente
        }

        public void actualizarPreciosExcel() {
            //pendiente
        }

        public void actualizarPrecios() {
            if (excel.actualizarPrecios() == 1) {
                MessageBox.Show("Los precios han sido cambiados", "Exito!");
            } else { //si no existe el archivo
                if (crearArchivoExcel())//intentar crear un nuevo archivo
                    actualizarPrecios();
            }
        }

        //preguntar si se quiere crear un nuevo archivo
        public bool crearArchivoExcel() {
            DialogResult result = MessageBox.Show("No existe archivo de Excel\nCree un archivo :c", "Error", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                if (excel.crearLibro()) {
                    return true;
                } else {
                    MessageBox.Show("No se completo la creacion del libro de Excel", "Error");
                    return false;
                }
            } else {
                MessageBox.Show("No se completo la creacion del libro de Excel", "Error");
                return false;
            }
        }

        //agregar material
        public void agregarMaterial(Material material, List<Material> subMateriales = null) {
            panelMaterial.agregarMaterial(material, subMateriales);
            panelCompras.agregarMaterial(material);
        }

        public void agregarSubMateriales(Material material, List<Material> subMateriales) {
            configs.agregarSubMaterial(material, subMateriales);
            panelMaterial.recargar();
        }

        public void agregarNuevoMaterial(Material material, List<Material> subMateriales = null) {
            configs.agregarmaterial(material, subMateriales);
            agregarMaterial(material, subMateriales);
        }

        //=------------------------Eventos--------------------------------------------------------------------------------------------------------------------------//


//------------------------------variables usadas por otras clases-------------------------------------------------------------------------//
        public static readonly Font fuenteNegrita = new Font("Arial", 12, FontStyle.Bold);
        public static Font fuente = new Font("Arial", 12, FontStyle.Regular);
        public static readonly int PAD_TOP = 24, PAD_BOT = 0, PAD_LEFT = 10, PAD_RIGHT = 20, TEXT_BOX_WIDHT = 70;
    }//fin form
}//fin namespace
