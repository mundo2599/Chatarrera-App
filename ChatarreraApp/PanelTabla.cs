using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatarreraApp {

    class PanelTabla : Panel {

        FlowLayoutPanel panelMateriales, panelKg, panelPagado;
        Label[] labelsMateriales, labelsKgs, labelsPagado;
        Label labelTotal;

        Compras compras;
        decimal total;

        public PanelTabla(Compras compras) {

            this.compras = compras;

            //this.BorderStyle = BorderStyle.FixedSingle;
            //this.BackColor = Color.DarkGray;
            this.Width = 230;
            this.Dock = (DockStyle.Fill);

            panelMateriales = new FlowLayoutPanel() {
                FlowDirection = FlowDirection.TopDown,
                //Width = this.Width / 3,
                AutoSize = true,
                Dock = DockStyle.Left,
                //BackColor = Color.Gold
            };

            panelKg = new FlowLayoutPanel() {
                FlowDirection = FlowDirection.TopDown,
                //Width = this.Width / 3,
                AutoSize = true,
                Dock = DockStyle.Left,
                //BackColor = Color.Brown
            };

            panelPagado = new FlowLayoutPanel() {
                FlowDirection = FlowDirection.TopDown,
                // Width = this.Width / 3,
                AutoSize = true,
                Dock = DockStyle.Left,
                //BackColor= Color.DarkOrange
            };

            inicializarLabels();


            this.Controls.Add(panelPagado);
            this.Controls.Add(panelKg);
            this.Controls.Add(panelMateriales);

            this.Controls.Add(new Panel() { Dock = DockStyle.Top, Height = 30 });

        }//Fin constructor

        private void inicializarLabels() {
            labelsMateriales = new Label[compras.Objetos.Count];
            labelsKgs = new Label[compras.Objetos.Count];
            labelsPagado = new Label[compras.Objetos.Count];

            //titulos
            panelMateriales.Controls.Add(new Label() { Text = "Materiales", Font = Form1.fuenteNegrita, AutoSize = true, Padding = new Padding(0, 0, 0, 15) });
            panelKg.Controls.Add(new Label() { Text = "   Kg", Font = Form1.fuenteNegrita, AutoSize = true, Padding = new Padding(0, 0, 0, 15) });
            panelPagado.Controls.Add(new Label() { Text = "Pagado", Font = Form1.fuenteNegrita, AutoSize = true, Padding = new Padding(0, 0, 0, 15) });

            for (int i = 0; i < compras.Objetos.Count; i++) {
                labelsMateriales[i] = new Label() {
                    Text = compras.Objetos[i] + ":",
                    Font = Form1.fuente,
                    Width = 70
                };

                labelsKgs[i] = new Label() {
                    Text = compras.Cantidad[i].ToString(),
                    Width = 50,
                    Font = Form1.fuente,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                labelsPagado[i] = new Label() {
                    Text = compras.Pagado[i].ToString(),
                    Width = 50,
                    Font = Form1.fuente,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                panelMateriales.Controls.Add(labelsMateriales[i]);
                panelKg.Controls.Add(labelsKgs[i]);
                panelPagado.Controls.Add(labelsPagado[i]);

            }//fin del for

            panelMateriales.Controls.Add(new Label() { Font = Form1.fuenteNegrita, Text = "TOTAL:", Padding = new Padding(0, 20, 0, 0), AutoSize = true });

            labelTotal = new Label() {
                Text = total.ToString(),
                Padding = new Padding(0, 20, 0, 0),
                AutoSize = true,
                Font = Form1.fuenteNegrita,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            panelPagado.Controls.Add(labelTotal);
        }//fin inicializarLabels

        public void actualizarLabel(int material) {
            labelsKgs[material].Text = compras.Cantidad[material].ToString();
            labelsPagado[material].Text = compras.Pagado[material].ToString();
            total = 0;
            foreach (int valor in compras.Pagado) {
                total += valor;
            }
            labelTotal.Text = total.ToString();
        }//fin actualizarLabel

    }//Fin clase paneltabla
}
