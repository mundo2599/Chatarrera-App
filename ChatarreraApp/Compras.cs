using System.Collections;
using System.Collections.Generic;

namespace ChatarreraApp
{
    public class Compras {

        private List<object> objetos;
        private List<decimal> cantidad, pagado;

        public Compras(params object[] objetos) {
            this.objetos = new List<object>();
            cantidad = new List<decimal>();
            pagado = new List<decimal>();

            foreach (object o in objetos) {
                if (o is IEnumerable && !(o is string))
                    foreach (var v in o as IEnumerable)
                        agregarObjeto(v);
                else 
                    agregarObjeto(o);
                
            }
        }//fin constructor

        public Compras() {
            this.objetos = new List<object>();
            cantidad = new List<decimal>();
            pagado = new List<decimal>();
        }//fin constructor

        public void agregarObjeto(object objeto) {
            this.objetos.Add(objeto);
            this.cantidad.Add(0.0m);
            this.pagado.Add(0.0m);
        }

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

        public List<decimal> Cantidad { get => cantidad; }
        public List<decimal> Pagado { get => pagado; }
        public List<object> Objetos { get => objetos; }
        public decimal TotalPagado {
            get {
                decimal total = 0;
                foreach (decimal d in pagado)
                    total += d;
                return total;
            }
        }

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
