using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordSpoilerMessageV2
{
    public partial class Form1 : Form
    {

        public string inputt;
        private string finalputt;
        private string outputt;

        private string CalcFinal(string inputt)
        {
            outputt = "";
            var inc = 0;
            while(inc < inputt.Length)
            {
                outputt += "||" + inputt[inc] + "||";
                inc++;
            }
            return outputt;
                
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputt = textBox1.Text;
            finalputt = CalcFinal(inputt);
            textBox2.Text = finalputt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                textBox2.Text = "Error: cannot input nothing";
            } else
            {
                Clipboard.SetText(finalputt);

                if (textBox3.Text == finalputt)
                {
                }
                else
                {
                    textBox3.Text = finalputt;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "") 
            {
                textBox3.Text = "Error: no text in history";
            } else
            {
                Clipboard.SetText(textBox3.Text);
            }
        }
    }
}
