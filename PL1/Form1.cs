
﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using BL;
using Models;
using DL;
using System.Collections.Generic;

namespace PL1
{
    public partial class Form1 : Form
    {


        RssHandler rssReader;
        FeedHandler feedHandler;
        CategoryHandler categoryHandler;




        public Form1()
        {
            InitializeComponent();
            rssReader = new RssHandler();
            feedHandler = new FeedHandler();
            categoryHandler = new CategoryHandler();
            UpdateContent();
        }





        public static void UppdateraLista(ComboBox box, string[] content)
        {
            box.Items.Clear();
            foreach (var item in content)
            {
                box.Items.Add(item);
            }
        }


        public static void UppdateraLista(TextBox box, string content)
        {
            box.Clear();
            box.Text = content;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cbxKategori.SelectedIndex = 0;
            string[] listOfFrequencies = FeedHandler.LoadFrekvens();
            UppdateraLista(cbxFrekvens, listOfFrequencies);
            UpdateContent();
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {

                //int episodeIndex = listBox1.SelectedIndex;
                //int feedIndex = listView1.SelectedItems[0].Index;
                //string description = feedHandler.HamtaAvsnittsBeskrivning(feedIndex, episodeIndex);
                //UppdateraLista(textBox3, description);

                int feedIndex = feedHandler.GetFeedIndex(listView1.SelectedItems[0].SubItems[1].Text);
                //Feed feed = feedHandler.GetAllFeeds()[feedIndex];

                int episodeIndex = listBox1.SelectedIndex;

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
            UpdateEpisodeContent();

            if (listView1.SelectedItems.Count == 1)
            {

                int feedIndex = feedHandler.GetFeedIndex(listView1.SelectedItems[0].SubItems[1].Text);
                Feed feed = feedHandler.GetAllFeeds()[feedIndex];
                Category category= categoryHandler.GetAllCategories()[feedIndex];
                txtBoxNewName.Text = feed.Title;
                txtUrl.Text = feed.Url;
                cbxFrekvens.Text = feed.UppdateringsFrekvens.ToString();
                cbxKategori.Text = category.Title.ToString();
            }
            else
            {
                textBox3.Clear();
            }

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
                  && cbxFrekvens.SelectedItem != null
                  && cbxKategori.SelectedItem != null)
            {

                if (Validering.CheckURL(txtUrl.Text) && !Validering.CheckIfFeedExistsByUrl(txtUrl.Text))

                {
                    listBox1.Items.Clear(); // Rensa listan innan den uppdateras med nytt innehåll

                    rssReader.GetRss(txtUrl.Text, categoryHandler.GetCategoryByName((string)cbxKategori.SelectedItem), (string)(cbxFrekvens.SelectedItem));

                    if (Validering.CheckTextInput(txtBoxNewName.Text) && !Validering.CheckIfFeedExistsByName(txtBoxNewName.Text)) //Potentiellt buggig
                    {
                        Feed feed = feedHandler.GetFeedByUrl(txtUrl.Text);
                        feedHandler.UpdateFeedName(feed.Title, txtBoxNewName.Text);
                    }
                    //else if (Validering.CheckIfFeedExistsByName(txtBoxNewName.Text))
                    //{
                    //    MessageBox.Show("En feed med detta namn existerar redan");
                    //}

                    UpdateContent();

                }
                else
                {
                    MessageBox.Show("Kontrollera om du skrev rätt URL!");
                }
            }
            else
            {
                MessageBox.Show("Kontrollera om du har fyllt i alla obligatoriska fält!");
            }
        }

        private void UpdateEpisodeContent()
        {
            textBox3.Clear();
            listBox1.Items.Clear();
           

            if (listView1.SelectedItems.Count == 1)
            {

                //int feedIndex = listView1.SelectedItems[0].Index;
                //Feed feed = feedHandler.GetFeedIndex(feedIndex);
                
                listBox1.Items.Clear();
                int feedIndex = feedHandler.GetFeedIndex(listView1.SelectedItems[0].SubItems[1].Text);
                Feed feed = feedHandler.GetAllFeeds()[feedIndex];

                foreach (Episode episode in feed.EpisodeList)
                {
                    listBox1.Items.Add(episode.Title);
                }
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

                    UpdateContent();
                }

            }

            else
            {
                MessageBox.Show("Kontrollera att du angett en kategori och att den inte redan existerar");
            }
        }

        private void UpdateContent()
        {
            UpdateCategoryContent();
            UpdateFeedContent();
            UpdateEpisodeContent();
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
                //listViewItem.SubItems.Add(feedHandler.GetAllFeeds().Count.ToString());
                listViewItem.SubItems.Add(feed.UppdateringsFrekvens);// Frekvens //Inmatning nuvarande endast for kontroll, ändras innan inlämning
                //listViewItem.SubItems.Add(feedHandler.GetFeedIndex(txtUrl.Text).ToString());
                listViewItem.SubItems.Add(feed.Category.Title); // Kategori
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        // Ta bort feed
        private void button7_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                
                feedHandler.RemoveFeed(listView1.SelectedItems[0].SubItems[1].Text);
                MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text);
                //UpdateFeedContent();
                UpdateContent();

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
                DialogResult dialogResult = MessageBox.Show("Radera kategorin och alla feeds som tillhör den?", "Varning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(listBox2.SelectedItems[0].ToString());
                    Category category = categoryHandler.GetCategoryByName(listBox2.SelectedItems[0].ToString());
                    feedHandler.RemoveFeed(category);
                    categoryHandler.RemoveCategory(listBox2.SelectedItems[0].ToString());
                    //UpdateFeedContent();
                    //UpdateCategoryContent();
                    UpdateContent();
                    MessageBox.Show(categoryHandler.GetAllCategories().Count.ToString());
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Inga feeds eller kategorier har raderats");
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
                    //Category category = categoryHandler.GetCategoryByName(listBox2.SelectedItems[0].ToString());
                    //category.Title = textBox2.Text;
                    categoryHandler.EditCategory(listBox2.SelectedItems[0].ToString(), textBox2.Text);
                    //feedHandler.GetAllFeedsByCategory(category)
                    feedHandler.UpdateFeedCategory(listBox2.SelectedItems[0].ToString(), textBox2.Text);
                    //UpdateCategoryContent();
                    //UpdateFeedContent();
                    UpdateContent();
                    //categoryHandler.GetCategoryByName
                }
                else
                {
                    MessageBox.Show("Kategorin existerar redan");
                }
            }
        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnSaveFeeds_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGetFeeds_Click(object sender, EventArgs e)
        {
           
        }

        // Uppdatera feed
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1 && cbxFrekvens.SelectedItem != null && cbxKategori.SelectedItem != null)
            {
                int feedIndex = feedHandler.GetFeedIndex(listView1.SelectedItems[0].SubItems[1].Text);
                Feed feed = feedHandler.GetAllFeeds()[feedIndex];
                feedHandler.UpdateFeedCategory(feed.Category.Title, (string)cbxKategori.SelectedItem, feed.Title);
                feed.UppdateringsFrekvens = cbxFrekvens.SelectedItem.ToString();

                if (Validering.CheckTextInput(txtBoxNewName.Text) && !Validering.CheckIfFeedExistsByName(txtBoxNewName.Text))
                {
                    feedHandler.UpdateFeedName(feed.Title, txtBoxNewName.Text);
                }

                UpdateContent();

            }
            else
            {
                MessageBox.Show("Du måste välja en feed att uppdatera");
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            //var valdKat = cbxKategori.SelectedItem.ToString();
            //listView1.Items.Clear();


            //if (valdKat.Equals("-")) {

            //    foreach (Feed feed in feedHandler.GetAllFeeds())
            //    {
                    
            //            ListViewItem listViewItem = listView1.Items.Add(feed.NumberOfEpisodes.ToString()); // Avsnitt
            //            listViewItem.SubItems.Add(feed.Title); // Titel
            //                                                   //listViewItem.SubItems.Add(feedHandler.GetAllFeeds().Count.ToString());
            //            listViewItem.SubItems.Add(feed.UppdateringsFrekvens);// Frekvens //Inmatning nuvarande endast for kontroll, ändras innan inlämning
            //                                                                 //listViewItem.SubItems.Add(feedHandler.GetFeedIndex(txtUrl.Text).ToString());
            //            listViewItem.SubItems.Add(feed.Category.Title); // Kategori

            //    }
            //}

            //else { 
            //    foreach (Feed feed in feedHandler.GetAllFeeds())
            //    {
            //        if (feed.Category.Title.ToString().Equals (valdKat)){
            //            ListViewItem listViewItem = listView1.Items.Add(feed.NumberOfEpisodes.ToString()); // Avsnitt
            //            listViewItem.SubItems.Add(feed.Title); // Titel
            //                                                   //listViewItem.SubItems.Add(feedHandler.GetAllFeeds().Count.ToString());
            //            listViewItem.SubItems.Add(feed.UppdateringsFrekvens);// Frekvens //Inmatning nuvarande endast for kontroll, ändras innan inlämning
            //                                                                 //listViewItem.SubItems.Add(feedHandler.GetFeedIndex(txtUrl.Text).ToString());
            //            listViewItem.SubItems.Add(feed.Category.Title); // Kategori
            //        }
                
            //    }
            //}
        }

        // Sortera efter vald kategori
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            {
                MessageBox.Show((listBox2.SelectedItems[0].ToString()));
                {
                    listView1.Items.Clear();

                    Category category = categoryHandler.GetCategoryByName(listBox2.SelectedItems[0].ToString());

                    foreach (Feed feed in feedHandler.GetAllFeedsByCategory(category))
                    {
                        ListViewItem listViewItem = listView1.Items.Add(feed.NumberOfEpisodes.ToString());
                        listViewItem.SubItems.Add(feed.Title);
                        listViewItem.SubItems.Add(feed.UppdateringsFrekvens);
                        listViewItem.SubItems.Add(feed.Category.Title);
                    }

                }
            }
            else
            {
                MessageBox.Show("Markera kategorin du vill sortera efter i listan nedanför");
            }
        }
    }

}