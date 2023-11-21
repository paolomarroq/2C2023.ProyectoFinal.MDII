using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        string dato = "";
        ArbolB miArbol = new ArbolB(null);
        Graphics g;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Ingrese un valor");
            }
            else
            {
                dato = txtValor.Text;
                if (miArbol.raiz == null)
                {
                    miArbol.Insertar(dato);
                }
                else
                {
                    string padre = txtPadre.Text;
                    miArbol.InsertarDesdeTextBox(dato, padre);
                }
                txtValor.Clear();
                txtValor.Focus();
                Invalidate();
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;

            miArbol.dibujarArbol(g, this.Font, Brushes.White, Brushes.Black, Pens.Black, Brushes.White);
        }

        private void btnPostorden_Click(object sender, EventArgs e)
        {
            if (miArbol.raiz != null)
            {
                string postorden = ObtenerPostorden(miArbol.raiz);
                MessageBox.Show("Recorrido Postorden: " + postorden);
            }
            else
            {
                MessageBox.Show("El árbol está vacío.");
            }
        }

        private string ObtenerPostorden(Nodo nodo)
        {
            if (nodo == null)
            {
                return string.Empty;
            }

            string resultado = ObtenerPostorden(nodo.Izquierdo);
            resultado += ObtenerPostorden(nodo.Derecho);
            resultado += nodo.valor + " ";

            return resultado;
        }


        private void btnInorden_Click(object sender, EventArgs e)
        {
            if (miArbol.raiz != null)
            {
                string inorden = ObtenerInorden(miArbol.raiz);
                MessageBox.Show("Recorrido Inorden: " + inorden);
            }
            else
            {
                MessageBox.Show("El árbol está vacío.");
            }
        }

        private string ObtenerInorden(Nodo nodo)
        {
            if (nodo == null)
            {
                return string.Empty;
            }

            string resultado = ObtenerInorden(nodo.Izquierdo);
            resultado += nodo.valor + " ";
            resultado += ObtenerInorden(nodo.Derecho);

            return resultado;
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            if (miArbol.raiz != null)
            {
                string preorden = ObtenerPreorden(miArbol.raiz);
                MessageBox.Show("Recorrido Preorden: " + preorden);
            }
            else
            {
                MessageBox.Show("El árbol está vacío.");
            }
        }

        private string ObtenerPreorden(Nodo nodo)
        {
            if (nodo == null)
            {
                return string.Empty;
            }

            string resultado = nodo.valor + " ";
            resultado += ObtenerPreorden(nodo.Izquierdo);
            resultado += ObtenerPreorden(nodo.Derecho);

            return resultado;
        }

        private void btnCalcularNivel_Click(object sender, EventArgs e)
        {
            string valor = txtOrden.Text;
            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Por favor, ingrese un valor de nodo para calcular su nivel.");
                return;
            }

            int nivel = miArbol.raiz?.CalcularNivel(valor) ?? -1;

            if (nivel != -1)
            {
                MessageBox.Show($"El nivel del nodo con valor '{valor}' es: {nivel}");
            }
            else
            {
                MessageBox.Show("Nodo no encontrado en el árbol.");
            }
        }

        private void heightbutton_click(object sender, EventArgs e)
        {
            if (miArbol.raiz != null)
            {
                int height = CalculateTreeHeight(miArbol.raiz);
                MessageBox.Show($"La altura del Àrbol es: {height}");
            }
            else
            {
                MessageBox.Show("El Árbol esta vacìo.");
            }
        }

        private int CalculateTreeHeight(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            int leftHeight = CalculateTreeHeight(nodo.Izquierdo);
            int rightHeight = CalculateTreeHeight(nodo.Derecho);

            // The height of the tree is the maximum height of its subtrees plus 1
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        private void leafbttn_Click(object sender, EventArgs e)
        {
            if (miArbol.raiz != null)
            {
                List<string> leafNodes = miArbol.GetLeafNodes();

                if (leafNodes.Count > 0)
                {
                    string leafNodesMessage = string.Join(", ", leafNodes);
                    MessageBox.Show($"Nodos Hojas: {leafNodesMessage}");
                }
                else
                {
                    MessageBox.Show("El Àrbol no tiene nodos hojas.");
                }
            }
            else
            {
                MessageBox.Show("El Árbol esta vacío.");
            }
        }
    }

    class Nodo
    {
        public string valor;
        public Nodo Izquierdo;
        public Nodo Derecho;
        public Nodo Padre;
        public Rectangle nodo;

        private ArbolB arbol;

        public Nodo() { }
        public ArbolB Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }
        public Nodo(string nuevovalor, Nodo nuevoizquierdo, Nodo nuevoderecho, Nodo nuevopadre)
        {
            valor = nuevovalor;
            Izquierdo = nuevoizquierdo;
            Derecho = nuevoderecho;
            Padre = nuevopadre;
        }




        private const int radio = 30;
        private const int distanciaH = 80;
        private const int distanciaV = 10;

        private int CoordenadaX;
        private int CoordenadaY;

        public void posNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + radio / 2);
            if (Izquierdo != null)
            {
                Izquierdo.posNodo(ref xmin, ymin + radio + distanciaV);
            }
            if ((Izquierdo != null) && (Derecho != null))
            {
                xmin += distanciaH;
            }
            if (Derecho != null)
            {
                Derecho.posNodo(ref xmin, ymin + radio + distanciaV);
            }
            if (Izquierdo != null && Derecho != null)
            {
                CoordenadaX = (int)((Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2);
            }
            else if (Izquierdo != null)
            {
                aux1 = Izquierdo.CoordenadaX;
                Izquierdo.CoordenadaX = CoordenadaX - 80;
                CoordenadaX = aux1;
            }
            else if (Derecho != null)
            {
                aux2 = Derecho.CoordenadaX;
                Derecho.CoordenadaX = CoordenadaX + 80;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + radio / 2);
                xmin += radio;
            }
        }
        public void Ramas(Graphics graf, Pen lapiz)
        {
            if (Izquierdo != null)
            {
                graf.DrawLine(lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX, Izquierdo.CoordenadaY);
                Izquierdo.Ramas(graf, lapiz);
            }
            if (Derecho != null)
            {
                graf.DrawLine(lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX, Derecho.CoordenadaY);
                Derecho.Ramas(graf, lapiz);
            }
        }

        public void dibujarNodo(Graphics graf, Font fuente, Brush relleno, Brush rellenoFuente, Pen lapiz, Brush encuentro)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - radio / 2), (int)(CoordenadaY - radio / 2), radio, radio);
            graf.FillEllipse(encuentro, rect);
            graf.FillEllipse(relleno, rect);
            graf.DrawEllipse(lapiz, rect);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            graf.DrawString(valor.ToString(), fuente, rellenoFuente, CoordenadaX, CoordenadaY, formato);
            if (Izquierdo != null)
            {
                Izquierdo.dibujarNodo(graf, fuente, relleno, rellenoFuente, lapiz, encuentro);
            }
            if (Derecho != null)
            {
                Derecho.dibujarNodo(graf, fuente, relleno, rellenoFuente, lapiz, encuentro);
            }
        }
        public int CalcularNivel(string valor, int nivel = 1)
        {
            if (this.valor == valor)
            {
                return nivel;
            }

            int nivelIzquierdo = Izquierdo?.CalcularNivel(valor, nivel + 1) ?? -1;
            int nivelDerecho = Derecho?.CalcularNivel(valor, nivel + 1) ?? -1;

            return Math.Max(nivelIzquierdo, nivelDerecho);
        }
    }
    class ArbolB
    {
        public Nodo raiz;
        public Nodo aux;
        public ArbolB()
        {
            aux = new Nodo();
        }
        public ArbolB(Nodo nuevaraiz)
        {
            raiz = nuevaraiz;
        }
        public void Insertar(string x)
        {
            Nodo nuevo = new Nodo(x, null, null, null);
            if (raiz == null)
            {
                this.raiz = nuevo;
            }
            else
            {
                raiz = this.InsertarNodo(raiz, nuevo);
            }
        }
        public Nodo InsertarNodo(Nodo actual, Nodo nuevo)
        {
            if (nuevo.valor.CompareTo(actual.valor) < 0)
            {
                if (actual.Izquierdo == null)
                {
                    actual.Izquierdo = nuevo;
                    return actual;
                }
                else
                {
                    actual.Izquierdo = InsertarNodo(actual.Izquierdo, nuevo);
                    return actual;
                }
            }
            else if (nuevo.valor.CompareTo(actual.valor) > 0)
            {
                if (actual.Derecho == null)
                {
                    actual.Derecho = nuevo;
                    return actual;
                }
                else
                {
                    actual.Derecho = InsertarNodo(actual.Derecho, nuevo);
                    return actual;
                }
            }
            else
            {
                return actual;
            }
        }
        public void InsertarDesdeTextBox(string nuevoValor, string valorPadre)
        {
            Nodo nodoPadre = EncontrarNodo(this.raiz, valorPadre);

            if (nodoPadre != null)
            {
                Nodo nuevoNodo = new Nodo(nuevoValor, null, null, nodoPadre);

                if (nodoPadre.Izquierdo == null)
                {
                    nodoPadre.Izquierdo = nuevoNodo;
                }
                else if (nodoPadre.Derecho == null)
                {
                    nodoPadre.Derecho = nuevoNodo;
                }
                else
                {
                    MessageBox.Show("El nodo padre ya tiene ambos hijos.");
                }
            }
            else
            {
                MessageBox.Show("El nodo padre no se encontró en el árbol.");
            }
        }
        public Nodo EncontrarNodo(Nodo nodo, string valor)
        {
            if (nodo == null || nodo.valor == valor)
            {
                return nodo;
            }

            Nodo izquierda = EncontrarNodo(nodo.Izquierdo, valor);
            Nodo derecha = EncontrarNodo(nodo.Derecho, valor);

            return izquierda ?? derecha;
        }
        public void dibujarArbol(Graphics graf, Font funete, Brush relleno, Brush rellenoFuente, Pen lapiz, Brush encuentro)
        {
            int x = 500;
            int y = 100;
            if (raiz != null)
            {
                raiz.posNodo(ref x, y);
                raiz.Ramas(graf, lapiz);
                raiz.dibujarNodo(graf, funete, relleno, rellenoFuente, lapiz, encuentro);
            }
            else
            {
                return;
            }
        }

        public List<string> GetLeafNodes()
        {
            List<string> leafNodes = new List<string>();
            CollectLeafNodes(raiz, leafNodes);
            return leafNodes;
        }

        private void CollectLeafNodes(Nodo nodo, List<string> leafNodes)
        {
            if (nodo != null)
            {
                if (nodo.Izquierdo == null && nodo.Derecho == null)
                {
                    leafNodes.Add(nodo.valor);
                }

                CollectLeafNodes(nodo.Izquierdo, leafNodes);
                CollectLeafNodes(nodo.Derecho, leafNodes);
            }
        }
    }
}
