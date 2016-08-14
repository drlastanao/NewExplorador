using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewExplorador
{
    public partial class Form1 : Form
    {
        RecorrerDirectorio r = new RecorrerDirectorio("c:\\");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataSource = r.filtrar();

            comboBox1.DataSource = r.ObtenerExtensiones(); 


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                dataGridView1.DataSource = r.filtrar(comboBox1.SelectedItem.ToString());
            }
            else
                dataGridView1.DataSource = r.filtrar();

        }
    }
}
