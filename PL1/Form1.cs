using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using BL;
using Models;

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
            FillComboBoxes();
        }




        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (txtUrl.Text != null) 
                //&& cbxFrekvens.SelectedItem != null 
                //&& cbxKategori.SelectedItem != null)
            {
                if (Validering.CheckURL(txtUrl.Text) && !Validering.FeedExists(txtUrl.Text))
                {
                    listBox1.Items.Clear(); // Rensa listan innan den uppdateras med nytt innehåll

                    rssReader.GetRss(txtUrl.Text, (string)cbxKategori.SelectedItem);
                    
                    Feed feed = feedHandler.GetFeedByUrl(txtUrl.Text);

                    foreach (Episode episode in feed.EpisodeList)
                    {
                        //item1.SubItems.Add(episode.Title);
                        listBox1.Items.Add(episode.Title);
                    }
                    ListViewItem listViewItem = listView1.Items.Add(feed.NumberOfEpisodes.ToString()); // Avsnitt
                    listViewItem.SubItems.Add(feed.Title); // Titel
                    listViewItem.SubItems.Add(feedHandler.GetAllFeeds().Count.ToString()); // Frekvens //Inmatning nuvarande endast for kontroll, ändras innan inlämning
                    //listViewItem.SubItems.Add(feedHandler.GetFeedIndex(txtUrl.Text).ToString());
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
            if (Validering.CheckTextInput(textBox2.Text))
            {
                listBox2.Items.Clear(); // Rensa listan innan den uppdateras med nytt innehåll
               
                categoryHandler.CreateCategory(textBox2.Text);

                foreach(Category category in categoryHandler.GetAllCategories())
                {
                    listBox2.Items.Add(category.Title);
                }
                FillCategoryBox();
            }
            else
            {
                MessageBox.Show("Kontrollera om du har fyllt alla fält!");
            }
        }

        private void FillComboBoxes()
        {
            FillCategoryBox();
        }

        private void FillCategoryBox()
        {
            cbxKategori.Items.Clear();

            foreach (Category category in categoryHandler.GetAllCategories())
            {
                cbxKategori.Items.Add(category.Title);
            }
        }

    }
}