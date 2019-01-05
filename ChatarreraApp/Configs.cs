
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChatarreraApp {

    [Serializable]
    public class Configs {
        private int lineaActualSalida,
                    lineaActualEntrada;

        private string direccionArchivo;
        private Dictionary<Material, List<Material>> dictionaryMateriales;

        private DateTime dateActualEntrada,
                         dateActualSalida;

        //constructor
        public Configs() {
            dictionaryMateriales = new Dictionary<Material, List<Material>>();
        }

        //agrega material que no existe
        public void agregarmaterial(Material material, List<Material> subMateriales) {
            dictionaryMateriales.Add(material, subMateriales);
            guardar(this);
        }

        //agrega submateriales a un material que ya existe
        public void agregarSubMaterial(Material material, List<Material> subMateriales) {
            dictionaryMateriales[buscarMaterial(material.Nombre)].AddRange(subMateriales);
            guardar(this);
        }

        public void actualizarPrecio(string material, decimal precio) {
            Material m = buscarMaterial(material);
            m.Precio = precio;
        }

        public Material buscarMaterial(string material) {
            foreach(var v in dictionaryMateriales) {
                if (v.Key.Nombre == material)
                    return v.Key;
                else
                    foreach(Material m in v.Value) {
                        if (m.Nombre == material)
                            return m;
                    }
            }
            return null;
        }

//-----------------------guardado y cargado-----------------------------------//

        public static Configs cargar() {
            if (!File.Exists("configs.txt")) {
                return null;
            } else {
                Configs c = null;
                FileStream stream = new FileStream("configs.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                c = (Configs)(formatter.Deserialize(stream));
                stream.Close();

                return c;
            }
        }

        public static void guardar(Configs c) {
            FileStream stream = new FileStream("configs.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, c);
            stream.Close();
        }

        /*public static Configs cargarJson() {
            if (!File.Exists("configs.json")) {
                return null;
            } else {
                Configs c = null;

                return c;
            }
        }*/

//---------------------------------Gets y Sets----------------------------------------------//

        //obtener materiales
        public List<Material> Materiales {
            get => new List<Material>(this.dictionaryMateriales.Keys);
        }

        public Dictionary<Material, List<Material>> DictionaryMateriales {
            get => dictionaryMateriales;
        }

        public string DireccionArchivo {
            get => direccionArchivo;
            set {
                direccionArchivo = value;
                guardar(this);
            }
        }

        public int LineaActualEntrada {
            get => lineaActualEntrada;
            set {
                lineaActualEntrada = value;
                guardar(this);
            }
        }

        public DateTime DateActualEntrada {
            get => dateActualEntrada;
            set {
                dateActualEntrada = value;
                guardar(this);
            }
        }
        
    }//fin compras

    [Serializable]
    public class Material {
        public string Nombre { set; get; }
        public decimal Precio { set; get; }

        public Material(string nombre = "", decimal precio = 0m) {
            Nombre = nombre;
            Precio = precio;
        }

        public override string ToString() {
            string s = Nombre;
            //s += ": " + Precio;
            return s;
        }

        public static bool operator == (Material a, Material b) {
            if (a is null && b is null)//iguales
                return true;
            else if (a is null || b is null)//distintos
                return false;
            else
                return a.Nombre == b.Nombre;
        }

        public static bool operator != (Material a, Material b) {
            if (a is null && b is null)//iguales
                return false;
            else if (a is null || b is null)//distintos
                return true;
            else
                return a.Nombre != b.Nombre;
        }

        public override bool Equals(object obj) {
            return this == (Material)obj;
        }

    }
}
