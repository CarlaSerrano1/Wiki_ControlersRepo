using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wiki_Controlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeContextMenuStrip();
            comboBox1.Items.Add("euro");
            comboBox1.Items.Add("pesetas");
            comboBox1.Items.Add("yen");
            comboBox1.Items.Add("dolar");
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProvaComboBox();
        }

        private void ProvaComboBox()
        {
            if (comboBox1.SelectedIndex != null)
            {
                string opcio = comboBox1.SelectedItem.ToString();
                if (opcio == "euro")
                {
                    MessageBox.Show("S'ha seleccionat l'opció euro", " ", MessageBoxButtons.OK);

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola!!");

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void InitializeContextMenuStrip()
        {
            // Crear un nuevo ContextMenuStrip
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

            // Agregar elementos al menú contextual
            ToolStripMenuItem But1 = new ToolStripMenuItem("Opción 1");
            But1.Click += Item1_Click;
            contextMenuStrip.Items.Add(But1);

            ToolStripMenuItem But2 = new ToolStripMenuItem("Opción 2");
            But2.Click += Item2_Click;
            contextMenuStrip.Items.Add(But2);

            // Asociar el ContextMenuStrip al control (por ejemplo, un botón)
            button1.ContextMenuStrip = contextMenuStrip;
        }


        private void Item1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción 1 seleccionada");
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción 2 seleccionada");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
