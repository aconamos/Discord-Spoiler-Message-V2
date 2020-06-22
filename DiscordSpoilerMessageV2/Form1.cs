using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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

        public void addToLogBox(string inMsg)
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
            while (inc < inputt.Length)
            {
                outputt += "||" + inputt[inc] + "||";
                inc++;
            }
            return outputt;

        }

        public void ClipboardTextCheckAndSet(string in1)
        {
            if (!string.IsNullOrEmpty(in1))
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //DONT REMOVE THIS, IT CAUSES BUILD ERRORS
            //THE TEXTBOX CANT BE CHANGED, IT'S READ ONLY, WHY I NEED THIS IS BEYOND ME
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {
            //DONT REMOVE THIS, IT CAUSES BUILD ERRORS
            //THE TEXTBOX CANT BE CHANGED, IT'S READ ONLY, WHY I NEED THIS IS BEYOND ME
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClipboardTextCheckAndSet(finalputt);
        }

        private void RemoveHistoryTileButton_Click(object sender, EventArgs e)
        {
            if(historyTileCount == 0)
            {
                addToLogBox("Error: Cannot have negative amount of history tiles");
            } else
            {
                historyTileCount--;
                Controls.Remove(historyTileList[historyTileCount].button1);
                Controls.Remove(historyTileList[historyTileCount].textBox);
                historyTileList.RemoveAt(historyTileCount);
                addToLogBox("History tile removed!");
            }
        }
        
        private void AddHistoryTileButton_Click(object sender, EventArgs e)
        {
            if(historyTileCount == 5)
            {
                addToLogBox("Error: Cannot have more than 5 history tiles");
            } else
            {
                historyTileList.Add(new HistoryTile());
                historyTileList[historyTileCount].button1.Location = new Point(12, 58 + (46 * historyTileCount));
                historyTileList[historyTileCount].textBox.Location = new Point(213, 13 + 58 + (46 * historyTileCount));
                Controls.Add(historyTileList[historyTileCount].textBox);
                Controls.Add(historyTileList[historyTileCount].button1);
                historyTileList[historyTileCount].button1.Click += new EventHandler(historyTileList[historyTileCount].button1_Click);
                historyTileCount++;
                addToLogBox("New history tile added!");
            }
            
        }
    }

    public class HistoryTile : Form1
    {
        public new Button button1 = new Button();
        public new TextBox textBox = new TextBox();
        public HistoryTile()
        {
            button1.Size = new Size(195, 46);
            button1.Text = "Copy Text to Clipboard";
            textBox.Size = new Size(575, 20);
            textBox.ReadOnly = true;
        }
        public string text;
        public void button1_Click(object sender, EventArgs e)
        {
            addToLogBox("this indicates success");
            ClipboardTextCheckAndSet(this.text);
        }

    }
    
}
