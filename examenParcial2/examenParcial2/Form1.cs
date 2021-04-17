using examenParcial2.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenParcial2
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;

        public object ENUMCOLUMNA { get; private set; }
        public object clsENUMCOLUMNAS { get; private set; }
        public Form1()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] Arreglodosdomenciones = new string[ArregloNotas.Length, 6];

            int numerolinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosunitarios = linea.Split(';');
                Arreglodosdomenciones[numerolinea, Clscolumnas.correlativo] = datosunitarios[0];
                Arreglodosdomenciones[numerolinea, Clscolumnas.nombre] = datosunitarios[1];
                Arreglodosdomenciones[numerolinea, Clscolumnas.parcial1] = datosunitarios[2];
                Arreglodosdomenciones[numerolinea, Clscolumnas.parcial2] = datosunitarios[3];
                Arreglodosdomenciones[numerolinea, Clscolumnas.parcial3] = datosunitarios[4];
                Arreglodosdomenciones[numerolinea, Clscolumnas.seccion] = datosunitarios[5];

                numerolinea++;

                listBox1.Items.Add($"{datosunitarios[Clscolumnas.nombre]} nota: { datosunitarios[Clscolumnas.parcial1]}");
            }
            int promedio = Fncpromedio(Arreglodosdomenciones, 1);
            MessageBox.Show($"el promedio del parcial 1");
            promedio = 0;
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Clsarchivos ar = new Clsarchivos();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "seleciona tu archivo plano";
            ofd.InitialDirectory = @"Escritorio";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeertodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBox1.Text = resultado;

            }
        }
    }
}
