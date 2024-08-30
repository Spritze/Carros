using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if (comboBox1.Text == "Ferrari")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("SF90");
                comboBox2.Items.Add("SP-8");
            }
            else if (comboBox1.Text == "Bentley")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bentley Continental GT");
                comboBox2.Items.Add("Bentley flying spur");
            }
            else if (comboBox1.Text == "Audi")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bentley Continental GT");
                comboBox2.Items.Add("Bentley flying spur");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] carro = Directory.GetFiles(@"C:\Users\Alexsandre Spritzer\OneDrive\Área de Trabalho\Linguagem de Programação\carros");
            foreach (string imagens in carro)
            {
                string[] separador = imagens.Split('\\');
                string[] fotos = separador[7].Split('.');

                if (comboBox2.Text == fotos[0])
                {
                    pictureBox5.ImageLocation = @"C:\Users\Alexsandre Spritzer\OneDrive\Área de Trabalho\Linguagem de Programação\carros\" + comboBox2.Text + ".jpg";
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
