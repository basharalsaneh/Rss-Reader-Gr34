﻿
namespace PL1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Avsnitt = new System.Windows.Forms.ColumnHeader();
            this.Namn = new System.Windows.Forms.ColumnHeader();
            this.Frekvens = new System.Windows.Forms.ColumnHeader();
            this.Kategori = new System.Windows.Forms.ColumnHeader();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(972, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lägga till";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1099, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Uppdatera";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1246, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ta bort";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 39);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(441, 427);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 40);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(721, 427);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 40);
            this.comboBox2.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Items.AddRange(new object[] {
            "Hi",
            "Hi",
            "Hi"});
            this.listBox1.Location = new System.Drawing.Point(721, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(637, 292);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Avsnitt,
            this.Namn,
            this.Frekvens,
            this.Kategori});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(674, 289);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            this.Avsnitt.Width = 100;
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 300;
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            this.Frekvens.Width = 120;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            this.Kategori.Width = 150;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 32;
            this.listBox2.Location = new System.Drawing.Point(15, 521);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(464, 228);
            this.listBox2.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 776);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(464, 39);
            this.textBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kategori:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 840);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 46);
            this.button4.TabIndex = 17;
            this.button4.Text = "Ta bort";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(173, 840);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 46);
            this.button5.TabIndex = 16;
            this.button5.Text = "Uppdatera";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 840);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 46);
            this.button6.TabIndex = 15;
            this.button6.Text = "Lägga till";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "URL:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Uppdatering frekvens:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.Location = new System.Drawing.Point(522, 521);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(836, 365);
            this.textBox3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Feed Rubrik:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Avsnittsbeskrivning:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 337);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 46);
            this.button7.TabIndex = 24;
            this.button7.Text = "Radera RSS feed";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 909);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
    }
}

