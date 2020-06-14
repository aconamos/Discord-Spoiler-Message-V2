using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public int historyTileCount = 0;
        public List<HistoryTile> historyTileList = new List<HistoryTile>();
        public HistoryTile test1 = new HistoryTile();

        private void addToLogBox(string inMsg)
        {
            logBox.AppendText(DateTime.Now + " " + inMsg + "\r\n");
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

        private void ClipboardTextCheckAndSet(string in1)
        {
            if(!string.IsNullOrEmpty(in1))
            {
                Clipboard.SetText(in1);
            } else
            {
                addToLogBox("Error: Cannot copy null or empty to clipboard.");
            }
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
            ClipboardTextCheckAndSet(finalputt);
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

        private void setBounds(byte count)
        {
           // historyTileList[count].button1.Location.X = 12;

        }

        private void RemoveHistoryTileButton_Click(object sender, EventArgs e)
        {
            if(historyTileCount == 0)
            {
                addToLogBox("Error: Cannot have negative amount of history tiles");
            } else
            {
                historyTileCount--;
            }
        }

        private void AddHistoryTileButton_Click(object sender, EventArgs e)
        {
            if(historyTileCount == 5)
            {
                addToLogBox("Error: Cannot have more than 5 history tiles");
            } else
            {
                historyTileCount++;
            }
            
            
        }
    }

    public class HistoryTile : Form
    {
        new Button button1 = new Button();
        new TextBox textBox = new TextBox();
        public HistoryTile()
        {
            button1.Location = new Point(12, 60);
            button1.Size = new Size(195, 46);
            button1.Text = "Copy Text to Clipboard";
            textBox.ReadOnly = true;
            Controls.Add(this.button1);
            Controls.Add(this.textBox);
        }
        private string text;
        private void button1_click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.text);
        }

        private void HistoryTile_load(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

    }
    
}
