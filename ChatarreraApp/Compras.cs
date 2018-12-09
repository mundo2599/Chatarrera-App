using System.Collections.Generic;

namespace ChatarreraApp
{
    class Compras {

        private List<object> objetos;
        private decimal[] cantidad, pagado;

        public Compras(params object[] objetos) {
            this.objetos = new List<object>();
            this.objetos.AddRange(objetos);

            cantidad = new decimal[objetos.Length];
            pagado = new decimal[objetos.Length];
        }//fin constructor

        public void agregarCompra(object objeto, decimal cantidad, decimal pagado) {
            //int indice = objetos.IndexOf(objeto);
            int indice = objetos.FindIndex(x => x.ToString() == objeto.ToString());
            agregarCompra(indice, cantidad, pagado);
        }

        public void agregarCompra(int indice, decimal cantidad, decimal pagado) {
            this.cantidad[indice] += cantidad;
            this.pagado[indice] += pagado;
        }

        public void restarCompra(int indice, decimal cantidad, decimal pagado) {
            this.cantidad[indice] -= cantidad;
            this.pagado[indice] -= pagado;
        }

        public decimal[] Cantidad { get => cantidad;}
        public decimal[] Pagado { get => pagado;}
        public List<object> Objetos { get => objetos; }

        public override string ToString() {
            string s = "Objeto".PadRight(10);
            s += "Cantidad".PadRight(10);
            s += "Pagado";
            s += "\n";

            for(int i = 0; i < objetos.Count; i++) {
                s += objetos[i].ToString().PadRight(10);
                s += cantidad[i].ToString().PadRight(10);
                s += pagado[i] + "\n";
            }
            return s;
        }

    }//fin clase Compras
}//fin namespace
