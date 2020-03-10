using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value=0;
        String operatie = "";
        bool ok = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            if((rezultat.Text=="0"||(ok)))
                rezultat.Clear();
            ok = false;
            Button B = new Button();
            B = sender as Button;
            rezultat.Text = rezultat.Text + B.Text;
        }
        private void operatii_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            operatie = B.Text;
            value = Double.Parse(rezultat.Text);
            ok = true;
            ecuatie.Text = value + " " + operatie;
        }
        private void CE_Click(object sender, EventArgs e)
        {
            rezultat.Text = "0";
        }

        private void egal_Click(object sender, EventArgs e)
        {
            ecuatie.Text = "";
            switch (operatie)
            {
                case "+":
                    rezultat.Text = (value + Double.Parse(rezultat.Text)).ToString();
                    break;
                case "-":
                    rezultat.Text = (value - Double.Parse(rezultat.Text)).ToString();
                    break;
                case "*":
                    rezultat.Text = (value * Double.Parse(rezultat.Text)).ToString();
                    break;
                case "/":
                    rezultat.Text = (value / Double.Parse(rezultat.Text)).ToString();
                    break;
                case "%":
                    rezultat.Text = (value % Double.Parse(rezultat.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }
        private void C_Click(object sender, EventArgs e)
        {
            rezultat.Text = "0";
            value = 0;
        }
        private void sqrt_click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(rezultat.Text);
            double y = Math.Sqrt(x);
            rezultat.Text = x.ToString();
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            rezultat.Text = rezultat.Text + ".";
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(rezultat.Text);
	        double y = -x;
            rezultat.Text = y.ToString();
        }

        private void radical_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(rezultat.Text);
            double y = Math.Sqrt(x);
            rezultat.Text = y.ToString();
        }

        private void invers_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(rezultat.Text);
            double y = 1 / x;
            rezultat.Text = y.ToString();
        }
    }

}
