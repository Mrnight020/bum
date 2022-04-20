using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DalsiUkol_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string text = textBox1.Text;
            text = text.ToLower();

            while(text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            string[] slova = text.Split(' ');

            int pocetslov = 0, pocetcifer = 0, pocetpismen = 0;
            string nejdelsislovo = "";

            pocetslov = slova.Length;

            int i = 0;

            foreach(string neco in slova)
            {
                if(neco.Length > i)
                {
                    i = neco.Length;
                    nejdelsislovo = neco;
                }
            }

            i = 0;
            foreach(char pismeno in text)
            {
                if(pismeno >= '0' && pismeno <= '9')
                {
                    pocetcifer += 1;
                }
                if (pismeno >= 'a' && pismeno <= 'z')
                {
                    pocetpismen += 1;
                }

                if(text.Length / 2 == i)
                {
                    textBox2.Text += text[text.Length-1].ToString();
                }
                textBox2.Text += pismeno.ToString();
                i++;
            }

            label2.Text = pocetslov.ToString();
            label4.Text = pocetcifer.ToString();
            label6.Text = pocetpismen.ToString();
            label8.Text = nejdelsislovo.ToString();

        }
    }
}
