namespace DiscordSpoilerMessageV2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.AddHistoryTileButton = new System.Windows.Forms.Button();
            this.RemoveHistoryTileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy Text to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(575, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(575, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 339);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(776, 99);
            this.logBox.TabIndex = 5;
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // AddHistoryTileButton
            // 
            this.AddHistoryTileButton.Location = new System.Drawing.Point(678, 309);
            this.AddHistoryTileButton.Name = "AddHistoryTileButton";
            this.AddHistoryTileButton.Size = new System.Drawing.Size(110, 24);
            this.AddHistoryTileButton.TabIndex = 6;
            this.AddHistoryTileButton.Text = "Add History Tile";
            this.AddHistoryTileButton.UseVisualStyleBackColor = true;
            this.AddHistoryTileButton.Click += new System.EventHandler(this.AddHistoryTileButton_Click);
            // 
            // RemoveHistoryTileButton
            // 
            this.RemoveHistoryTileButton.Location = new System.Drawing.Point(562, 309);
            this.RemoveHistoryTileButton.Name = "RemoveHistoryTileButton";
            this.RemoveHistoryTileButton.Size = new System.Drawing.Size(110, 24);
            this.RemoveHistoryTileButton.TabIndex = 7;
            this.RemoveHistoryTileButton.Text = "Remove History Tile";
            this.RemoveHistoryTileButton.UseVisualStyleBackColor = true;
            this.RemoveHistoryTileButton.Click += new System.EventHandler(this.RemoveHistoryTileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveHistoryTileButton);
            this.Controls.Add(this.AddHistoryTileButton);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Discord Spoiler Message V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button AddHistoryTileButton;
        private System.Windows.Forms.Button RemoveHistoryTileButton;
    }
}

