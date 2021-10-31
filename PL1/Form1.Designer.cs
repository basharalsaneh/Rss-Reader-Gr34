
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cbxFrekvens = new System.Windows.Forms.ComboBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
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
            this.txtBoxNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFeedUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lägga till";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Uppdatera";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(9, 201);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(251, 23);
            this.txtUrl.TabIndex = 3;
            // 
            // cbxFrekvens
            // 
            this.cbxFrekvens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFrekvens.FormattingEnabled = true;
            this.cbxFrekvens.Location = new System.Drawing.Point(281, 195);
            this.cbxFrekvens.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbxFrekvens.Name = "cbxFrekvens";
            this.cbxFrekvens.Size = new System.Drawing.Size(103, 23);
            this.cbxFrekvens.TabIndex = 4;
            // 
            // cbxKategori
            // 
            this.cbxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(388, 195);
            this.cbxKategori.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(83, 23);
            this.cbxKategori.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(388, 18);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 139);
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
            this.listView1.Location = new System.Drawing.Point(9, 20);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(365, 138);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 100;
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
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(8, 244);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(252, 109);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 364);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 23);
            this.textBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kategori:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 394);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 22);
            this.button4.TabIndex = 17;
            this.button4.Text = "Ta bort";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 394);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 22);
            this.button5.TabIndex = 16;
            this.button5.Text = "Uppdatera";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 394);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 22);
            this.button6.TabIndex = 15;
            this.button6.Text = "Lägga till";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "URL:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Uppdatering frekvens:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.Location = new System.Drawing.Point(281, 244);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(452, 173);
            this.textBox3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Avsnitt";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Avsnittsbeskrivning:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 158);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 22);
            this.button7.TabIndex = 24;
            this.button7.Text = "Radera RSS feed";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtBoxNewName
            // 
            this.txtBoxNewName.Location = new System.Drawing.Point(474, 195);
            this.txtBoxNewName.Name = "txtBoxNewName";
            this.txtBoxNewName.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNewName.TabIndex = 26;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(474, 177);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(115, 15);
            this.lblNewName.TabIndex = 27;
            this.lblNewName.Text = "Nytt namn (frivilligt)";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(98, 158);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 28;
            this.btnSort.Text = "Sortera";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblFeedUpdate
            // 
            this.lblFeedUpdate.AutoSize = true;
            this.lblFeedUpdate.Location = new System.Drawing.Point(40, 2);
            this.lblFeedUpdate.Name = "lblFeedUpdate";
            this.lblFeedUpdate.Size = new System.Drawing.Size(0, 15);
            this.lblFeedUpdate.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 426);
            this.Controls.Add(this.lblFeedUpdate);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtBoxNewName);
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
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.cbxFrekvens);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox cbxFrekvens;
        private System.Windows.Forms.ComboBox cbxKategori;
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

        private System.Windows.Forms.TextBox txtBoxNewName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFeedUpdate;
    }
}

