using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ChatarreraApp {

    class ManejadorExcel {

        Excel.Application application;
        Excel.Workbook workbook;
        Excel._Worksheet sheetInventario,
                sheetEntradas,
                sheetSalidas;

        Configs configs;

        //Constructor
        public ManejadorExcel(Configs configs) {
            this.configs = configs;

            application = new Excel.Application();
        }

        ~ManejadorExcel() {
            application.Quit();
        }

        public int abrirLibro() {
            try {
                workbook = application.Workbooks.Open(configs.DireccionArchivo);
            } catch {
                DialogResult result = MessageBox.Show("No existe archivo de Excel\nDesea crear uno nuevo?", "Error");
                if (result == DialogResult.OK) {
                    crearLibro();
                    return abrirLibro();
                } else {
                    return -1;
                }
            }
            sheetInventario = (Excel._Worksheet)workbook.Worksheets.get_Item(1);
            sheetEntradas = (Excel._Worksheet)workbook.Worksheets.get_Item(2);
            sheetSalidas = (Excel._Worksheet)workbook.Worksheets.get_Item(3);
            return 1;
        }

        public bool crearLibro() {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = "Chatarrera";
            fileDialog.Filter = "Hoja de calculo (*.xlsx) | *.xlsx";
            fileDialog.AddExtension = true;

            if(fileDialog.ShowDialog() == DialogResult.OK) {
                configs.DireccionArchivo = fileDialog.FileName;

                workbook = application.Workbooks.Add(Type.Missing);
                inicializarLibro();
                workbook.SaveAs(configs.DireccionArchivo);
                workbook.Close();

                return true;
            } else {
                return false;
            }
        }

        public void inicializarLibro() {
            //crear hojas
        }

        public int crearTabla() {

            return 1;
        }

        public int guardarEntrada() {

            return 1;
        }

        public int guardarsalida() {

            return 1;
        }

    }
}
