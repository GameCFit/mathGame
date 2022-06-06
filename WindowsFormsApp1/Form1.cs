using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int left, right, result;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            GenerateExpresion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == result.ToString())
            {
                progressBar1.Value += 10;
                GenerateExpresion();
                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = "";
                progressBar1.Value -= 20;
                GenerateExpresion();
            }
            switch (progressBar1.Value)
            {
                case (100):
                    label2.Text = "Ты молодец!";
                    break;
                case (20):
                    label2.Text = "Ты тупой!";
                    break;
                case(0):
                    Application.Exit();
                    break;
                default:
                    label2.Text = "";
                    break;
            }
        }
        public void GenerateExpresion()
        {
            left = random.Next(13, 200);
            right = random.Next(13, 200);
            result = left + right;
            operantleft.Text = left.ToString();
            operantright.Text = right.ToString();

        }
    }
}
