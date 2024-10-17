using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Recibir el valor de n
            if (int.TryParse(textBox1.Text, out int n))
            {
                // Calcular el valor de pi
                double pi = Algoritmo.CalcularPi(n);
                // Mostrar el valor de pi
                label1.Text = pi.ToString();
                // Llenar el DataGridView
                DataTable tabla = new DataTable();
                DataColumn columna = new DataColumn("X");
                DataColumn columna2 = new DataColumn("Y");
                tabla.Columns.Add(columna);
                tabla.Columns.Add(columna2);

            }
            else
            {
                // Handle invalid input
                label1.Text = "Invalid input";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Crear una tabla
            DataTable tabla = new DataTable();
            // Crear una columna
            DataColumn columna = new DataColumn("X");
            DataColumn columna2 = new DataColumn("Y");
            // Agregar la columna a la tabla
            tabla.Columns.Add(columna);
            tabla.Columns.Add(columna2);
            // Agregar filas a la tabla
            for (int i = 0; i < 10; i++)
            {
                DataRow fila = tabla.NewRow();
                fila["X"] = i;
                fila["Y"] = Math.Pow(i, 2);
                tabla.Rows.Add(fila);
            }

            // Mostrar la tabla en el DataGridView
            dataGridView1.DataSource = tabla;






        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llenar el DataGridView
            DataTable tabla = new DataTable();
            DataColumn columna = new DataColumn("X");
            DataColumn columna2 = new DataColumn("Y");
            tabla.Columns.Add(columna);
            tabla.Columns.Add(columna2);
            for (int i = 0; i < 10; i++)
            {
                DataRow fila = tabla.NewRow();
                fila["X"] = i;
                fila["Y"] = Math.Pow(i, 2);
                tabla.Rows.Add(fila);
            }
            dataGridView1.DataSource = tabla;


        }
    }
}
