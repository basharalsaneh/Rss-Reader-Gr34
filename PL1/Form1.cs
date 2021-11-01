
﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using BL;
using Models;
using System.Collections.Generic;

namespace PL1
{
    public partial class Form1 : Form
    {


        RssHandler rssReader;
        FeedHandler feedHandler;
        CategoryHandler categoryHandler;
        MessageHandler messageHandler;

        public Form1()
        {
            InitializeComponent();
            rssReader = new RssHandler();
            feedHandler = new FeedHandler();
            categoryHandler = new CategoryHandler();
            messageHandler = new MessageHandler();
            UpdateContent();

            timer1.Interval = 1000;

            timer1.Start();
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

        //När programmet laddas in för första gången
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] listOfFrequencies = FeedHandler.LoadFrekvens();
            UppdateraLista(cbxFrekvens, listOfFrequencies);
            UpdateContent();
            ProgramMessage message = messageHandler.CreateMessage(1);
            MessageBox.Show(message.DisplayMessage());
            
        }

        //När användaren kryssar ner programmet
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgramMessage message = messageHandler.CreateMessage(0);
            DialogResult dialogResult = MessageBox.Show(message.DisplayMessage(), "Avsluta programmet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               //Stäng programmet
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }






        //Visa lista av en feeds avsnitt
        private void listBoxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFeeds.SelectedItems.Count == 1)
            {

                int feedIndex = feedHandler.GetFeedIndex(listViewFeeds.SelectedItems[0].SubItems[1].Text);
                int episodeIndex = listBoxEpisodes.SelectedIndex;
                string description = feedHandler.HamtaAvsnittsBeskrivning(feedIndex, episodeIndex);

                UppdateraLista(textBoxEpisodeDescription, description);

            }
            else
            {
                textBoxEpisodeDescription.Clear();
            }
        }


        // Timer för uppdatering av feeds
        private void Timer1_Tick(object sender, EventArgs e)
        {       

            foreach(Feed feed in feedHandler.GetAllFeeds())
            {
                if (feed.NeedsUpdate)
                {

                    lblFeedUpdate.Text = feed.Update();
                    listBoxEpisodes.Items.Clear();

                    string url = feed.Url;
                    string title = feed.Title;
                    Category category = feed.Category;
                    string frekvens = feed.UpdateInterval;

                    feedHandler.RemoveFeed(feed.Title);

                    rssReader.UpdateRss(url, title, category, frekvens);

                    //UpdateContent();
                    UpdateEpisodeContent();

                }
            }
            
        }

        //Markerar feed
        private void listViewFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEpisodeContent();

            if (listViewFeeds.SelectedItems.Count == 1)
            {

                int feedIndex = feedHandler.GetFeedIndex(listViewFeeds.SelectedItems[0].SubItems[1].Text);
                Feed feed = feedHandler.GetAllFeeds()[feedIndex];
                txtBoxNewName.Clear();
                //txtUrl.Text = feed.Url;
                cbxKategori.Text = feed.Category.Title;

                switch (feed.UpdateInterval)
                {
                    case "60000":
                        cbxFrekvens.Text = cbxFrekvens.Items[0].ToString();
                        break;

                    case "300000":
                        cbxFrekvens.Text = cbxFrekvens.Items[1].ToString();
                        break;

                    case "600000":
                        cbxFrekvens.Text = cbxFrekvens.Items[2].ToString();
                        break;

                    case "1800000":
                        cbxFrekvens.Text = cbxFrekvens.Items[3].ToString();
                        break;
                    default :
                        cbxFrekvens.Text = cbxFrekvens.Items[0].ToString();
                        break;
                }
            }
            else
            {
                textBoxEpisodeDescription.Clear();
            }
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Skapa ny feed
        private async void btnCreateFeed_Click(object sender, EventArgs e)
        {
            if(txtUrl.Text == "" && cbxFrekvens.SelectedItem == null && cbxKategori.SelectedItem == null)
            {
                MessageBox.Show("Du måste ange URl, frekvens och kategori för att kunna skapa en feed");
            }

            try
            {
                if ( cbxFrekvens.SelectedItem != null
                  && cbxKategori.SelectedItem != null)
                  
                {

                    if (Validering.CheckTextInput(txtUrl.Text) && !Validering.CheckIfFeedExistsByUrl(txtUrl.Text) && Validering.CheckURL(txtUrl.Text))

                    {
                        
                       listBoxEpisodes.Items.Clear(); // Rensa listan innan den uppdateras med nytt innehåll

                       string frekvens = cbxFrekvens.SelectedItem.ToString();
                       Task getRssFeed = rssReader.CreateRssAsync(txtUrl.Text, categoryHandler.GetCategoryByName((string)cbxKategori.SelectedItem), frekvens.Substring(0, frekvens.IndexOf(' ')));
                       await getRssFeed;
                                       

                        UpdateContent();
                        try
                        {
                            if (txtBoxNewName.Text != "" && !Validering.CheckIfFeedExistsByName(txtBoxNewName.Text))  //Potentiellt buggig
                            {
                                Feed feed = feedHandler.GetFeedByUrl(txtUrl.Text);
                                feedHandler.UpdateFeedName(feed.Title, txtBoxNewName.Text);
                                UpdateContent();
                            }
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Kunde inte läsa feeden");
                        }
                       

                    }
                    
                }
               
            }
            catch (TextEmptyException exception)
            {
                MessageBox.Show(exception.Message + "Textfält för URL");
            }
            catch (EntityExistsException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (InvalidUrlException exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void UpdateEpisodeContent()
        {
            textBoxEpisodeDescription.Clear();
            listBoxEpisodes.Items.Clear();
           

            if (listViewFeeds.SelectedItems.Count == 1)
            {
                
                listBoxEpisodes.Items.Clear();
                int feedIndex = feedHandler.GetFeedIndex(listViewFeeds.SelectedItems[0].SubItems[1].Text);
                Feed feed = feedHandler.GetAllFeeds()[feedIndex];

                foreach (Episode episode in feed.EpisodeList)
                {
                    listBoxEpisodes.Items.Add(episode.Title);
                }
            }
        

        }


    //Skapa ny kategori
    private void btnCreateCategory_Click(object sender, EventArgs e) 
        {
            try
            {
                if (Validering.CheckTextInput(textBoxCategory.Text) && !Validering.CategoryExists(textBoxCategory.Text))
                {
                    {
                        listBoxCategory.Items.Clear(); // Rensa listan innan den uppdateras med nytt innehåll

                        categoryHandler.CreateCategory(textBoxCategory.Text);

                        UpdateContent();
                        textBoxCategory.Clear();
                    }

                }

            }
            catch(TextEmptyException exception)
            {
               MessageBox.Show(exception.Message + "Textfält för kategori");
            }
            catch(EntityExistsException exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void UpdateContent()
        {
            UpdateCategoryContent();
            UpdateFeedContent();
            UpdateEpisodeContent();
            listBoxCategory.Items.Add("Alla kategorier");

        }

        private void UpdateCategoryContent()
        {
            cbxKategori.Items.Clear();
            listBoxCategory.Items.Clear();

            foreach (Category category in categoryHandler.GetAllCategories())
            {
                cbxKategori.Items.Add(category.Title);
                listBoxCategory.Items.Add(category.Title);
            }

        }

        private void UpdateFeedContent()
        {
            listViewFeeds.Items.Clear();

            foreach (Feed feed in feedHandler.GetAllFeeds())
            { 
                    ListViewItem listViewItem = listViewFeeds.Items.Add(feed.NumberOfEpisodes.ToString()); // Avsnitt
                    listViewItem.SubItems.Add(feed.Title); // Titel
                    
                switch (feed.UpdateInterval) //Frekvens
                {
                    case "60000":
                        listViewItem.SubItems.Add("Varje minut");
                        break;

                    case "300000":
                        listViewItem.SubItems.Add("Var 5:e minut");
                        break;

                    case "600000":
                        listViewItem.SubItems.Add("Var 10:e minut");
                        break;

                    case "1800000":
                        listViewItem.SubItems.Add("Var 30:e minut");
                        break;
                    default:
                        listViewItem.SubItems.Add("Varje minut");
                        break;
                }
                listViewItem.SubItems.Add(feed.Category.Title); // Kategori  

            }
        }

        // Ta bort feed
        private void btnRemoveFeed_Click(object sender, EventArgs e)
        {
            if (listViewFeeds.SelectedItems.Count == 1)
            {
                
                feedHandler.RemoveFeed(listViewFeeds.SelectedItems[0].SubItems[1].Text);
                UpdateContent();
            }
            else
            {
                MessageBox.Show("Du har inte valt någonting, eller så har du valt fler än en sak!");
            }
        }

        // Ta bort kategori
        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategory.SelectedItems.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Radera kategorin och alla feeds som tillhör den?", "Varning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Category category = categoryHandler.GetCategoryByName(listBoxCategory.SelectedItems[0].ToString());
                    feedHandler.RemoveFeed(category);
                    categoryHandler.RemoveCategory(listBoxCategory.SelectedItems[0].ToString());

                    UpdateContent();
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
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {

            if (listBoxCategory.SelectedItems.Count == 1)
            {
                try
                {
                    if (!Validering.CategoryExists(textBoxCategory.Text) && Validering.CheckTextInput(textBoxCategory.Text))
                    {
                        categoryHandler.EditCategory(listBoxCategory.SelectedItems[0].ToString(), textBoxCategory.Text);
                        feedHandler.UpdateFeedCategory(listBoxCategory.SelectedItems[0].ToString(), textBoxCategory.Text);

                        UpdateContent();
                        
                    }
                    
                }
                catch(EntityExistsException exception)
                {
                    MessageBox.Show(exception.Message);
                }
                catch(TextEmptyException exception)
                {
                    MessageBox.Show(exception.Message + "Textfält för kategori");
                }
                
            }
            else
            {
                MessageBox.Show("Du måste markera kategorin du vill uppdatera");
            }
        }



        //Sortera efter kategori
        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBoxCategory.SelectedItems.Count == 1)
            {
                var valdKat = listBoxCategory.SelectedItem.ToString();
                listViewFeeds.Items.Clear();
                if (valdKat.Equals("Alla kategorier"))
                {
                    UpdateContent();
                    btnCreateCategory.Enabled = true;
                    btnUpdateCategory.Enabled = false;
                    btnRemoveCategory.Enabled = false;
                    textBoxCategory.Clear();
                }

                else
                {
                    foreach (Feed feed in feedHandler.GetAllFeeds())
                    {
                        if (feed.Category.Title.ToString().Equals(valdKat))
                        {
                            ListViewItem listViewItem = listViewFeeds.Items.Add(feed.NumberOfEpisodes.ToString()); // Avsnitt
                            listViewItem.SubItems.Add(feed.Title); // Titel

                            switch (feed.UpdateInterval)
                            {
                                case "60000":
                                    listViewItem.SubItems.Add("Varje minut");
                                    break;

                                case "300000":
                                    listViewItem.SubItems.Add("Var 5:e minut");
                                    break;

                                case "600000":
                                    listViewItem.SubItems.Add("Var 10:e minut");
                                    break;

                                case "1800000":
                                    listViewItem.SubItems.Add("Var 30:e minut");
                                    break;
                                default:
                                    listViewItem.SubItems.Add("Varje minut");
                                    break;
                            }
                            listViewItem.SubItems.Add(feed.Category.Title); 

                            btnCreateCategory.Enabled = true;
                            btnUpdateCategory.Enabled = true;
                            btnRemoveCategory.Enabled = true;
                        }
                        textBoxCategory.Text = listBoxCategory.SelectedItem.ToString();
                    }


                }
            }
            else
            {
                
            }
                

               
        }
       


       

        // Uppdatera feed
        private void btnUpdateFeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFeeds.SelectedItems.Count == 1 && cbxFrekvens.SelectedItem != null && cbxKategori.SelectedItem != null)
                {
                    int feedIndex = feedHandler.GetFeedIndex(listViewFeeds.SelectedItems[0].SubItems[1].Text);
                    Feed feed = feedHandler.GetAllFeeds()[feedIndex];
                    feedHandler.UpdateFeedCategory(feed.Category.Title, (string)cbxKategori.SelectedItem, feed.Title);
                    string frekvens = cbxFrekvens.SelectedItem.ToString();

                    feedHandler.UpdateFeedUpdateInterval(feed.Title, frekvens.Substring(0, frekvens.IndexOf(" ")));

                    if (txtBoxNewName.Text != "" && Validering.CheckTextInput(txtBoxNewName.Text) && !Validering.CheckIfFeedExistsByName(txtBoxNewName.Text))
                    {
                        feedHandler.UpdateFeedName(feed.Title, txtBoxNewName.Text);
                    }

                    MessageBox.Show("Feedens nya uppdateringsintervall kommer börja gälla efter nästa uppdatering");
                    UpdateContent();

                }
                else
                {
                    MessageBox.Show("Du måste välja en feed att uppdatera");
                }
            }
            catch(TextEmptyException exception)
            {
                MessageBox.Show(exception.Message + "Textfält för nytt namn");
            }
            catch(EntityExistsException exception)
            {
                MessageBox.Show(exception.Message);
            }
            

        }

       
        


       
    }

}