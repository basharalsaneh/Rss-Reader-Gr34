
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
            this.btnCreateFeed = new System.Windows.Forms.Button();
            this.btnUpdateFeed = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cbxFrekvens = new System.Windows.Forms.ComboBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.listBoxEpisodes = new System.Windows.Forms.ListBox();
            this.listViewFeeds = new System.Windows.Forms.ListView();
            this.Avsnitt = new System.Windows.Forms.ColumnHeader();
            this.Namn = new System.Windows.Forms.ColumnHeader();
            this.Frekvens = new System.Windows.Forms.ColumnHeader();
            this.Kategori = new System.Windows.Forms.ColumnHeader();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEpisodeDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveFeed = new System.Windows.Forms.Button();
            this.txtBoxNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFeedUpdate = new System.Windows.Forms.Label();
            this.btnShowAllFeeds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateFeed
            // 
            this.btnCreateFeed.Location = new System.Drawing.Point(588, 196);
            this.btnCreateFeed.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreateFeed.Name = "btnCreateFeed";
            this.btnCreateFeed.Size = new System.Drawing.Size(65, 22);
            this.btnCreateFeed.TabIndex = 0;
            this.btnCreateFeed.Text = "Lägga till";
            this.btnCreateFeed.UseVisualStyleBackColor = true;
            this.btnCreateFeed.Click += new System.EventHandler(this.btnCreateFeed_Click);
            // 
            // btnUpdateFeed
            // 
            this.btnUpdateFeed.Location = new System.Drawing.Point(657, 196);
            this.btnUpdateFeed.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUpdateFeed.Name = "btnUpdateFeed";
            this.btnUpdateFeed.Size = new System.Drawing.Size(76, 22);
            this.btnUpdateFeed.TabIndex = 1;
            this.btnUpdateFeed.Text = "Uppdatera";
            this.btnUpdateFeed.UseVisualStyleBackColor = true;
            this.btnUpdateFeed.Click += new System.EventHandler(this.btnUpdateFeed_Click);
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
            // listBoxEpisodes
            // 
            this.listBoxEpisodes.FormattingEnabled = true;
            this.listBoxEpisodes.ItemHeight = 15;
            this.listBoxEpisodes.Location = new System.Drawing.Point(388, 18);
            this.listBoxEpisodes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBoxEpisodes.Name = "listBoxEpisodes";
            this.listBoxEpisodes.Size = new System.Drawing.Size(345, 139);
            this.listBoxEpisodes.TabIndex = 7;
            this.listBoxEpisodes.SelectedIndexChanged += new System.EventHandler(this.listBoxEpisodes_SelectedIndexChanged);
            // 
            // listViewFeeds
            // 
            this.listViewFeeds.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewFeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Avsnitt,
            this.Namn,
            this.Frekvens,
            this.Kategori});
            this.listViewFeeds.FullRowSelect = true;
            this.listViewFeeds.GridLines = true;
            this.listViewFeeds.HideSelection = false;
            this.listViewFeeds.Location = new System.Drawing.Point(9, 20);
            this.listViewFeeds.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listViewFeeds.Name = "listViewFeeds";
            this.listViewFeeds.Size = new System.Drawing.Size(365, 138);
            this.listViewFeeds.TabIndex = 8;
            this.listViewFeeds.UseCompatibleStateImageBehavior = false;
            this.listViewFeeds.View = System.Windows.Forms.View.Details;
            this.listViewFeeds.SelectedIndexChanged += new System.EventHandler(this.listViewFeeds_SelectedIndexChanged);
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
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 15;
            this.listBoxCategory.Location = new System.Drawing.Point(8, 244);
            this.listBoxCategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(252, 109);
            this.listBoxCategory.TabIndex = 9;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(8, 364);
            this.textBoxCategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(252, 23);
            this.textBoxCategory.TabIndex = 13;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(9, 222);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 15);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Kategori:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(177, 394);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(81, 22);
            this.btnRemoveCategory.TabIndex = 17;
            this.btnRemoveCategory.Text = "Ta bort";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(93, 394);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(81, 22);
            this.btnUpdateCategory.TabIndex = 16;
            this.btnUpdateCategory.Text = "Uppdatera";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Location = new System.Drawing.Point(9, 394);
            this.btnCreateCategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(81, 22);
            this.btnCreateCategory.TabIndex = 15;
            this.btnCreateCategory.Text = "Lägga till";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
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
            // textBoxEpisodeDescription
            // 
            this.textBoxEpisodeDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxEpisodeDescription.Location = new System.Drawing.Point(281, 244);
            this.textBoxEpisodeDescription.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxEpisodeDescription.Multiline = true;
            this.textBoxEpisodeDescription.Name = "textBoxEpisodeDescription";
            this.textBoxEpisodeDescription.ReadOnly = true;
            this.textBoxEpisodeDescription.Size = new System.Drawing.Size(452, 173);
            this.textBoxEpisodeDescription.TabIndex = 21;
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
            // btnRemoveFeed
            // 
            this.btnRemoveFeed.Location = new System.Drawing.Point(8, 158);
            this.btnRemoveFeed.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRemoveFeed.Name = "btnRemoveFeed";
            this.btnRemoveFeed.Size = new System.Drawing.Size(81, 22);
            this.btnRemoveFeed.TabIndex = 24;
            this.btnRemoveFeed.Text = "Radera RSS feed";
            this.btnRemoveFeed.UseVisualStyleBackColor = true;
            this.btnRemoveFeed.Click += new System.EventHandler(this.btnRemoveFeed_Click);
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
            // btnShowAllFeeds
            // 
            this.btnShowAllFeeds.Location = new System.Drawing.Point(185, 158);
            this.btnShowAllFeeds.Name = "btnShowAllFeeds";
            this.btnShowAllFeeds.Size = new System.Drawing.Size(75, 23);
            this.btnShowAllFeeds.TabIndex = 30;
            this.btnShowAllFeeds.Text = "Visa alla feeds";
            this.btnShowAllFeeds.UseVisualStyleBackColor = true;
            this.btnShowAllFeeds.Click += new System.EventHandler(this.btnShowAllFeeds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 426);
            this.Controls.Add(this.btnShowAllFeeds);
            this.Controls.Add(this.lblFeedUpdate);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtBoxNewName);
            this.Controls.Add(this.btnRemoveFeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEpisodeDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnCreateCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.listViewFeeds);
            this.Controls.Add(this.listBoxEpisodes);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.cbxFrekvens);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnUpdateFeed);
            this.Controls.Add(this.btnCreateFeed);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFeed;
        private System.Windows.Forms.Button btnUpdateFeed;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox cbxFrekvens;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.ListBox listBoxEpisodes;
        private System.Windows.Forms.ListView listViewFeeds;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEpisodeDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveFeed;

        private System.Windows.Forms.TextBox txtBoxNewName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFeedUpdate;
        private System.Windows.Forms.Button btnShowAllFeeds;
    }
}

