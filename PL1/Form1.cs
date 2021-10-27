﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using BL;
using Models;
using DL;

namespace PL1
{
    public partial class Form1 : Form
    {

        CancellationTokenSource cts = new CancellationTokenSource(); // tillåter timed out för vår async
        RssHandler rssReader;
        FeedHandler feedHandler;
        CategoryHandler categoryHandler;
        
        public Form1()
        {
            InitializeComponent();
            rssReader = new RssHandler();
            feedHandler = new FeedHandler();
            categoryHandler = new CategoryHandler();
        }




        private void Form1_Load(object sender, EventArgs e)
        {


        }
        public static void UppdateraLista(TextBox box, string innehall)
        {
            box.Clear();
            box.Text = innehall;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {

                int episodeIndex = listBox1.SelectedIndex;
                int feedIndex = listView1.SelectedItems[0].Index;
                string description = feedHandler.HamtaAvsnittsBeskrivning(feedIndex, episodeIndex);
                UppdateraLista(textBox3, description);
            }
            else
            {
                textBox3.Clear();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Skapa ny feed
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text != null 
                //&& cbxFrekvens.SelectedItem != null 
                && cbxKategori.SelectedItem != null)
            {

                if (Validering.CheckURL(txtUrl.Text) && !Validering.FeedExists(txtUrl.Text))

                {
                    listBox1.Items.Clear(); // Rensa listan innan den uppdateras med nytt innehåll

                    //rssReader.GetRss(txtUrl.Text, (string)cbxKategori.SelectedItem);

                    rssReader.GetRss(txtUrl.Text, categoryHandler.GetCategoryByName((string)cbxKategori.SelectedItem));
                    
                    Feed feed = feedHandler.GetFeedByUrl(txtUrl.Text);

                    foreach (Episode episode in feed.EpisodeList)
                    {
                        //item1.SubItems.Add(episode.Title);
                        listBox1.Items.Add(episode.Title);
                    }
                    ListViewItem listViewItem = listView1.Items.Add(feed.NumberOfEpisodes.ToString()); // Avsnitt
                    listViewItem.SubItems.Add(feed.Title); // Titel
                    //listViewItem.SubItems.Add(feedHandler.GetAllFeeds().Count.ToString()); // Frekvens //Inmatning nuvarande endast for kontroll, ändras innan inlämning
                    listViewItem.SubItems.Add(feedHandler.GetFeedIndex(txtUrl.Text).ToString());
                    listViewItem.SubItems.Add(feed.Category.Title); // Kategori
                    


                }
                else
                {
                    MessageBox.Show("Kontrollera om du skrev rätt URL!");
                }
            }
            else
            {
                MessageBox.Show("Kontrollera om du har fyllt alla fält!");
            }
        }


        //Skapa ny kategori
        private void button6_Click(object sender, EventArgs e) 
        {
            if (Validering.CheckTextInput(textBox2.Text) && !Validering.CategoryExists(textBox2.Text))
                {
                    {
                        listBox2.Items.Clear(); // Rensa listan innan den uppdateras med nytt innehåll

                        categoryHandler.CreateCategory(textBox2.Text);

                        UpdateCategoryContent();
                    }

                }
            
            else
            {
                MessageBox.Show("Kontrollera att du angett en kategori");
            }
        }

        private void UpdateContent()
        {
            UpdateCategoryContent();
        }

        private void UpdateCategoryContent()
        {
            cbxKategori.Items.Clear();
            listBox2.Items.Clear();

            foreach (Category category in categoryHandler.GetAllCategories())
            {
                cbxKategori.Items.Add(category.Title);
                listBox2.Items.Add(category.Title);
            }
        }

        private void UpdateFeedContent()
        {
            listView1.Items.Clear();
            

            foreach (Feed feed in feedHandler.GetAllFeeds())
            {
                ListViewItem listViewItem = listView1.Items.Add(feed.NumberOfEpisodes.ToString()); // Avsnitt
                listViewItem.SubItems.Add(feed.Title); // Titel
                                                       //listViewItem.SubItems.Add(feedHandler.GetAllFeeds().Count.ToString()); // Frekvens //Inmatning nuvarande endast for kontroll, ändras innan inlämning
                listViewItem.SubItems.Add(feedHandler.GetFeedIndex(txtUrl.Text).ToString());
                listViewItem.SubItems.Add(feed.Category.Title); // Kategori
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                feedHandler.RemoveFeed(listView1.SelectedItems[0].Index);
                MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text);
                UpdateFeedContent();

            }
            else
            {
                MessageBox.Show("Du har inte valt någonting, eller så har du valt fler än en sak!");
            }
        }

        // Ta bort kategori
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            { 
                DialogResult dialogResult = MessageBox.Show("Radera alla feeds som tillhör denna kategori?", "Varning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                {
                    Category category = categoryHandler.GetCategoryByName(listBox2.SelectedItems[0].ToString());
                    feedHandler.RemoveFeed(category);
                    categoryHandler.RemoveCategory(listBox2.SelectedIndex);
                    UpdateCategoryContent();
                    UpdateFeedContent();
                    MessageBox.Show(categoryHandler.GetAllCategories().Count.ToString());
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Inga feeds har raderats");
                }
            }
            else
            {
                MessageBox.Show("Du måste markera en kategori för att kunna radera den ");
            }
        }

        //Uppdatera kategori
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            {
                MessageBox.Show((listBox2.SelectedItems[0].ToString()));
                if (!Validering.CategoryExists(textBox2.Text))
                {
                    Category category = categoryHandler.GetCategoryByName(listBox2.SelectedItems[0].ToString());
                    category.Title = textBox2.Text;
                    UpdateCategoryContent();
                    UpdateFeedContent();
                    //categoryHandler.GetCategoryByName
                }
                else
                {
                    MessageBox.Show("Kategorin existerar redan");
                }




            }
        }
    }
}