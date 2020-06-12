using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DiscordSpoilerMessageV2
{
    public partial class Form1 : Form
    {

        public string inputt;
        private string finalputt;
        private string outputt;
        public byte historyTileCount = 0;
        // List<newHistoryTile> historyTileList = new newHistoryTile();

        private void addToLogBox(string inMsg)
        {
            logBox.AppendText(inMsg + "\r\n");
        }

        private bool areTheyEqual(string in1, string in2)
        {
            if (in1 == in2)
            {
                return true;
            } else
            {
                return false;
            }
        }

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
            if(!string.IsNullOrEmpty(finalputt))
            {
                Clipboard.SetText(finalputt);
            } else
            {
                addToLogBox(DateTime.Now + ": Error: Could not copy nothing to clipboard. Occurred: Copying initial text box input.");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    public class newHistoryTile,,,,
    {
        public newHistoryTile(byte historyTileCount)
        {
             
        }
    }
}
