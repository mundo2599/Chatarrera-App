using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ChatarreraApp {

    class ManejadorExcel {

        Configs configs;

        Excel.Application application;
        Excel.Workbook workbook;
        Excel._Worksheet sheetInventario,
                sheetEntradas,
                sheetSalidas;

        //Constructor
        public ManejadorExcel(Configs configs) {
            this.configs = configs;
            abrirApp();
        }

        ~ManejadorExcel() {
            cerrarApp();    
        }

        private void abrirApp() {
            if (application == null) {
                try {
                    application = new Excel.Application();
                } catch {
                    MessageBox.Show("No se pudo abrir la aplicacion de Excel :c", "Error");
                }
            }
        }//fin abrir app

        private void cerrarApp() {
            if (application != null)
                application.Quit();
        }//fin cerrar app

        public int guardarsalida() {
            //comprobar libro abierto
            return 1;
        }// fin guardar salida

        public int abrirLibro() {
            if (workbook == null) {
                try {   //abrir libro
                    workbook = application.Workbooks.Open(configs.DireccionArchivo);
                } catch {
                    workbook = null;
                    return -1;
                }
                try {   //abrir hojas
                    sheetInventario = (Excel._Worksheet)workbook.Worksheets.get_Item(1);
                    sheetEntradas = (Excel._Worksheet)workbook.Worksheets.get_Item(2);
                    sheetSalidas = (Excel._Worksheet)workbook.Worksheets.get_Item(3);
                } catch {
                    cerrarLibro();
                    return -1;
                }
            }
            return 1;
        }// fin abrir libro

        public int cerrarLibro() {
            if (workbook != null) {
                workbook.Save();
                workbook.Close();
            }
            workbook = null;
            return 1;
        }//fin cerrar libro

        public int actualizarPrecios() {
            if (abrirLibro() == -1) {//si hubo error
                return -1;
            }

            for (int i = 0; i < configs.Materiales.Count; i++)
                sheetInventario.Cells[4, i + 2] = configs.Materiales[i].Precio;

            cerrarLibro();

            return 1;
        }//fin actualizar precios

        private int crearTablaEntradas(DateTime date) {
            if (abrirLibro() == -1) {//si hubo error
                return -1;
            }

            int lineaTabla;
            if (configs.LineaActualEntrada == -1) {  //si es la primer tabla
                lineaTabla = 1;
                configs.DateActualEntrada = date;
            } else {
                lineaTabla = (11 - configs.LineaActualEntrada % 11) + configs.LineaActualEntrada + 1;
            }

            //-------------------------crear tablas------------------------------------------
            Excel.Range rango, tablaKg, tablaPagado;
            DateTime dateLunes = StartOfWeek(date, DayOfWeek.Monday);
            //INICIO TABLAS
            //TITULO Kg de A a N
            rango = sheetEntradas.get_Range("A" + lineaTabla.ToString(), GetColumnName(configs.Materiales.Count + 1) + lineaTabla.ToString());
            rango.Merge();
            rango.Value2 = "Semana del " + dateLunes.Day + " de " + devolverMes(dateLunes.Month) + " al " + dateLunes.AddDays(6).Day + " de " + devolverMes(dateLunes.AddDays(6).Month);
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rango.Font.Bold = true;
            rango.Font.Size = 20;

            //TITULO Gastado de P a AC
            rango = sheetEntradas.get_Range(GetColumnName(configs.Materiales.Count + 3) + lineaTabla.ToString(), GetColumnName(configs.Materiales.Count*2 + 3) + lineaTabla.ToString());
            rango.Merge();
            rango.Value2 = "Pagado";
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rango.Font.Bold = true;
            rango.Font.Size = 20;

            //TITULO Ganancia de AE a AQ
            rango = sheetEntradas.get_Range(GetColumnName(configs.Materiales.Count*2 + 5) + lineaTabla.ToString(), GetColumnName(configs.Materiales.Count * 3 + 5) + lineaTabla.ToString());
            rango.Merge();
            rango.Value2 = "Ganancia";
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rango.Font.Bold = true;
            rango.Font.Size = 20;


            //INICIO Tabla kg de A2 a N9
            string nombreTablaKg = "tablaKg" + lineaTabla.ToString();
            tablaKg = rango = sheetEntradas.get_Range((Excel.Range)sheetEntradas.Cells[lineaTabla + 1, 1], (Excel.Range)sheetEntradas.Cells[lineaTabla + 7, configs.Materiales.Count + 1]);
            tablaKg.Value2 = "0";
            rango.Worksheet.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange,
                    rango, Type.Missing, Excel.XlYesNoGuess.xlYes, Type.Missing).Name = nombreTablaKg;
            rango[1, 1] = " ";
            sheetEntradas.ListObjects[nombreTablaKg].TableStyle = "TableStyleLight1";
            sheetEntradas.ListObjects[nombreTablaKg].ShowTotals = true;
            for (int i = 0; i < configs.Materiales.Count; i++) //Encabezado y totales
            {
                rango[1, i + 2] = configs.Materiales[i].Nombre;
                rango[8, i + 2].Formula = "=SUM([" + configs.Materiales[i].Nombre + "])";
            }
            for (int i = 2; i <= 7; i++) //fechas
            {
                rango[i, 1] = dateLunes.AddDays(i - 2).ToShortDateString();
                rango[i, 1].Font.Bold = true;
            }
            //FIN Tabla kg de A2 a N9


            //INICIO Tabla de pagado de P a AB
            string nombreTablaPagado = "tablaPagado" + lineaTabla.ToString();
            tablaPagado = rango = sheetEntradas.get_Range((Excel.Range)sheetEntradas.Cells[lineaTabla + 1, configs.Materiales.Count + 3], (Excel.Range)sheetEntradas.Cells[lineaTabla + 7, configs.Materiales.Count*2 + 2]);
            tablaPagado.Value2 = "0";
            rango.Worksheet.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange,
                    rango, Type.Missing, Excel.XlYesNoGuess.xlYes, Type.Missing).Name = nombreTablaPagado;
            rango[1, 1] = " ";
            sheetEntradas.ListObjects[nombreTablaPagado].TableStyle = "TableStyleLight1";
            sheetEntradas.ListObjects[nombreTablaPagado].ShowTotals = true;
            for (int i = 0; i < configs.Materiales.Count; i++) //Encabezado y totales
            {
                rango[1, i + 1] = configs.Materiales[i].Nombre;
                rango[8, i + 1].Formula = "=SUM([" + configs.Materiales[i].Nombre + "])";
            }
            //Columna de Total de pagado
            string nombreTablaPagadoTotal = "tablaPagadoTotal" + lineaTabla.ToString();
            rango = sheetEntradas.get_Range((Excel.Range)sheetEntradas.Cells[lineaTabla + 1, configs.Materiales.Count * 2 + 3], (Excel.Range)sheetEntradas.Cells[lineaTabla + 7, configs.Materiales.Count * 2 + 3]);
            rango.Worksheet.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange,
                    rango, Type.Missing, Excel.XlYesNoGuess.xlYes, Type.Missing).Name = nombreTablaPagadoTotal;
            sheetEntradas.ListObjects[nombreTablaPagadoTotal].TableStyle = "TableStyleLight1";
            sheetEntradas.ListObjects[nombreTablaPagadoTotal].ShowTotals = true;
            rango.Style = "Check Cell";
            rango[1, 1] = "Total";
            rango[1, 1].Style = "Check Cell";
            for (int i = 2; i <= 8; i++) {
                rango[i, 1] = "=SUM("+ GetColumnName(configs.Materiales.Count + 3) + (i + lineaTabla) + ":" + GetColumnName(configs.Materiales.Count * 2 + 2) + (i + lineaTabla) + ")";
                rango[i, 1].Style = "Check Cell";
            }
            //FIN Tabla de pagado


            //INICIO tabla ganancia AJ a AV
            string nombreTablaGanacia = "tablaGanancia" + lineaTabla.ToString();
            rango = sheetEntradas.get_Range((Excel.Range)sheetEntradas.Cells[lineaTabla + 1, configs.Materiales.Count * 2 + 5], (Excel.Range)sheetEntradas.Cells[lineaTabla + 7, configs.Materiales.Count * 2 + 5]);
            rango.Worksheet.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange,
                    rango, Type.Missing, Excel.XlYesNoGuess.xlYes, Type.Missing).Name = nombreTablaGanacia;
            rango[1, 1] = " ";
            sheetEntradas.ListObjects[nombreTablaGanacia].TableStyle = "TableStyleLight1";
            sheetEntradas.ListObjects[nombreTablaGanacia].ShowTotals = true;
            //Formulas de ganancia
            for (int i = 0; i < configs.Materiales.Count; i++) //Encabezado y totales
            {
                rango[1, i + 1] = configs.Materiales[i].Nombre;
                rango[8, i + 1].Formula = "=SUM([" + configs.Materiales[i].Nombre + "])";
                for (var j = 2; j <= 7; j++) {
                    rango[j, i + 1].Value2 =
                        "=(" +
                        GetColumnName(tablaKg[j, i + 2].Column) + tablaKg[j, i + 2].Row +
                        "*" + configs.Materiales[i].Precio + ")-" +
                        GetColumnName(tablaPagado[j, i + 1].Column) + tablaPagado[j, i + 1].Row;

                }
            }
            //Columna de Total de Ganancia
            string nombreTablaGananciaTotal = "tablaGananciaTotal" + lineaTabla.ToString();
            rango = sheetEntradas.get_Range((Excel.Range)sheetEntradas.Cells[lineaTabla + 1, configs.Materiales.Count * 3 + 5], (Excel.Range)sheetEntradas.Cells[lineaTabla + 7, configs.Materiales.Count * 3 + 5]);
            rango.Worksheet.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange,
                    rango, Type.Missing, Excel.XlYesNoGuess.xlYes, Type.Missing).Name = nombreTablaGananciaTotal;
            sheetEntradas.ListObjects[nombreTablaGananciaTotal].TableStyle = "TableStyleLight1";
            sheetEntradas.ListObjects[nombreTablaGananciaTotal].ShowTotals = true;
            rango.Style = "Check Cell";
            rango[1, 1] = "Total";
            rango[1, 1].Style = "Check Cell";
            for (int i = 2; i <= 8; i++) {
                rango[i, 1] = "=SUM(" + GetColumnName(configs.Materiales.Count * 2 + 5) + (i + lineaTabla) + ":" + GetColumnName(configs.Materiales.Count * 3 + 4) + (i + lineaTabla) + ")";
                rango[i, 1].Style = "Check Cell";
            }
            //FIN Tabla ganancia
            //FIN TABLAS
            

            //INICIO Vinculo de gastos
            for (int i = 2; i < configs.Materiales.Count + 2; i++) {
                if (configs.Materiales[i - 2].Nombre != "Bateria" && configs.Materiales[i - 2].Nombre != "Plomo")
                    sheetInventario.Cells[6, i].Formula += "+" + nombreTablaKg + "[[#Totals],[" + configs.Materiales[i - 2] + "]]";
                sheetInventario.Cells[12, i].Formula += "+" + nombreTablaPagado + "[[#Totals],[" + configs.Materiales[i - 2] + "]]";
            }


            /*int j = 325;
            foreach (Excel.Style style in libroChatarrera.Styles)
            {
                hojaInventario.Cells[j, 1].Value2 = style.Name.ToString();
                hojaInventario.Cells[j++, 1].Style = style;
            } */    //Ver ESTILOS DE CELDA
//-------------------------------------------------------------------------------

            configs.LineaActualEntrada = lineaTabla + 2;
            configs.DateActualEntrada = dateLunes;

            //cerrarLibro();

            return 1;
        }//fin crear tabla entradas

        public int guardarEntrada(Compras compras, DateTime date) {
            //comprobar libro abierto
            if(abrirLibro() == -1)
                return -1;

            if (date.DayOfWeek == DayOfWeek.Sunday) {   //dia de guardado es domingo
                MessageBox.Show("El dia de guardado es domingo D:", "Error");
                return -2;
            }

            if (date.DayOfYear < configs.DateActualEntrada.DayOfYear) {//guardando en una fecha anterior
                DialogResult result = MessageBox.Show("Dia de guardado es anterior al ultimo dia guardado", "Precaucion");
                return - 2;
            }

            if (date.DayOfYear > StartOfWeek(configs.DateActualEntrada, DayOfWeek.Sunday).AddDays(7).DayOfYear) {//si es mayor a la semana
                crearTablaEntradas(date);//nueva semana
            }

            if (configs.LineaActualEntrada % 11 > 8 || configs.LineaActualEntrada == -1) {   //si llego al final de la semana
                crearTablaEntradas(date);   //crear tabla de siguiente semana
            }

            if (date.DayOfYear > configs.DateActualEntrada.DayOfYear) {//no es el dia que sigue, pero no pasa la semana
                TimeSpan diferencia = date - configs.DateActualEntrada;
                configs.LineaActualEntrada += diferencia.Days;
            }

            for (int i = 1; i <= configs.Materiales.Count; i++) {
                sheetEntradas.Cells[configs.LineaActualEntrada, i + 1] = compras.Cantidad[i - 1].ToString();
                sheetEntradas.Cells[configs.LineaActualEntrada, i + 1 + configs.Materiales.Count + 1] = compras.Pagado[i - 1].ToString();
            }

            configs.LineaActualEntrada++;
            configs.DateActualEntrada = date.AddDays(1);

            cerrarLibro();

            return 1;
        }//fin guardar entrada

        public bool crearLibro() {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = "Chatarrera";
            fileDialog.Filter = "Hoja de calculo (*.xlsx) | *.xlsx";
            fileDialog.AddExtension = true;

            if(fileDialog.ShowDialog() == DialogResult.OK) {
                configs.DireccionArchivo = fileDialog.FileName;

                try {
                    workbook = application.Workbooks.Add(Type.Missing);
                    inicializarLibro();
                    workbook.SaveAs(configs.DireccionArchivo);
                    return true;
                } catch {
                    return false;
                } finally {
                    cerrarLibro();
                }
            } else {
                return false;
            }
        }//fin crear libro

        private int inicializarLibro() {
            //comprobar libro abierto
            abrirLibro();

            //crear hojas
            var xlSheets = workbook.Sheets as Excel.Sheets;
            sheetInventario = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
            sheetInventario.Name = "Inventario";
            sheetEntradas = (Excel.Worksheet)xlSheets.Add(xlSheets[2], Type.Missing, Type.Missing, Type.Missing);
            sheetEntradas.Name = "Entradas";
            sheetSalidas = (Excel.Worksheet)xlSheets.Add(xlSheets[3], Type.Missing, Type.Missing, Type.Missing);
            sheetSalidas.Name = "Salidas";

            inicializarSheetInventario();

            configs.LineaActualEntrada = -1; //inicializar linea actual
            configs.DateActualEntrada = new DateTime(1900, 1, 1);//asignar ultima fecha guardado

            //application.Visible = true;
            //cerrarLibro();

            return 1;
        }//fin inicializar libro

        private void inicializarSheetInventario() {

            sheetInventario.Cells[3, 1] = "Materiales";
            //sheetInventario.Cells[3, 1].Italic = true;
            sheetInventario.Cells[4, 1] = "Precio Medio";
            sheetInventario.Cells[6, 1] = "Kg Entrada";
            sheetInventario.Cells[7, 1] = "Kg Salida";
            sheetInventario.Cells[8, 1] = "Kg Totales al dia";
            sheetInventario.Cells[10, 1] = "Proyeccion al dia";
            sheetInventario.Cells[12, 1] = "Gastado";
            sheetInventario.Cells[13, 1] = "Recibido";
            sheetInventario.Cells[14, 1] = "Ganancia";
            sheetInventario.Cells[16, 1] = "Diferencia";

            sheetInventario.get_Range("A3", "A16").Font.Bold = true;

            int i = 2;
            foreach (Material m in configs.Materiales) {
                var columna = sheetInventario.Cells[1, i].Column;
                sheetInventario.Cells[3, i] = m.Nombre;     //material
                sheetInventario.Cells[3, i].Font.Bold = true;
                sheetInventario.Cells[4, i] = m.Precio.ToString();//precio
                sheetInventario.Cells[4, i].NumberFormat = "#,###.00 $";

                sheetInventario.Cells[6, i] = "=0"; //kg entrada
                sheetInventario.Cells[7, i] = "=0"; //kg salida
                sheetInventario.Cells[8, i] = "=" + GetColumnName(columna) + "6-" + GetColumnName(columna) + "7"; //kg totales

                sheetInventario.Cells[10, i] = "=" + GetColumnName(columna) + "4*" + GetColumnName(columna) + "8"; //proyeccion
                sheetInventario.Cells[10, i].NumberFormat = "#,###.00 $";

                sheetInventario.Cells[12, i] = "=0"; //gastado
                sheetInventario.Cells[12, i].NumberFormat = "#,###.00 $";
                sheetInventario.Cells[13, i] = "=0"; //recibido
                sheetInventario.Cells[13, i].NumberFormat = "#,###.00 $";
                sheetInventario.Cells[14, i] = "=0"; //ganancia
                sheetInventario.Cells[14, i].NumberFormat = "#,###.00 $";

                sheetInventario.Cells[16, i] = "=" + GetColumnName(columna) + "10+" + GetColumnName(columna) + "14"; //diferencia
                sheetInventario.Cells[16, i].NumberFormat = "#,###.00 $";
                i++;
            }

            //gasto global
            var rango = sheetInventario.get_Range("A18", "B18");
            rango.Merge();
            rango.Value2 = "Gasto Global";
            rango.Font.Bold = true;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            sheetInventario.Cells[18, 3] = "=SUM(B12:" + GetColumnName(configs.Materiales.Count + 1) + "12)";
            sheetInventario.Cells[18, 3].NumberFormat = "#,###.00 $";

            //recibo global
            rango = sheetInventario.get_Range("A19", "B19");
            rango.Merge();
            rango.Value2 = "Recibo Global";
            rango.Font.Bold = true;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            sheetInventario.Cells[19, 3] = "=SUM(B13:" + GetColumnName(configs.Materiales.Count + 1) + "13)";
            sheetInventario.Cells[19, 3].NumberFormat = "#,###.00 $";

            //ganancia global
            rango = sheetInventario.get_Range("A21", "B21");
            rango.Merge();
            rango.Value2 = "Ganancia Global";
            rango.Font.Bold = true;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            sheetInventario.Cells[21, 3] = "= C19 - C18";
            sheetInventario.Cells[21, 3].NumberFormat = "#,###.00 $";

            //inventario global
            rango = sheetInventario.get_Range("A22", "B22");
            rango.Merge();
            rango.Value2 = "Inventario Fisico";
            rango.Font.Bold = true;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            sheetInventario.Cells[22, 3] = "=SUM(B10:" + GetColumnName(configs.Materiales.Count + 1) + "10)";
            sheetInventario.Cells[22, 3].NumberFormat = "#,###.00 $";

            //ganancia proyectada
            rango = sheetInventario.get_Range("A24", "B24");
            rango.Merge();
            rango.Value2 = "Ganancia Proyectada";
            rango.Font.Bold = true;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            sheetInventario.Cells[24, 3] = "=C21+C22";
            sheetInventario.Cells[24, 3].NumberFormat = "#,###.00 $";

        }//fin inicializar inventario

        private string GetColumnName(int columnNumber) {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0) {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }//fin get column name

        private string devolverMes(int mes) {
            switch (mes) {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
            }
            return " ";
        }

        private DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek) {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        public Excel.Workbook Libro { get => workbook; }

    }
}
