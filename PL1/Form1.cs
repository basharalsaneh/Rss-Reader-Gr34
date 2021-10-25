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
        
        public Form1()
        {
            InitializeComponent();
            rssReader = new RssHandler();
            feedHandler = new FeedHandler();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text != null) 
                //&& cbxFrekvens.SelectedItem != null 
                //&& cbxKategori.SelectedItem != null)
            {
                if (Validering.CheckURL(txtUrl.Text))
                {
                    rssReader.GetRss(txtUrl.Text);
                    
                    Feed feed = feedHandler.GetFeedByUrl(txtUrl.Text);

                    foreach (Episode episode in feed.EpisodeList)
                    {
                        //item1.SubItems.Add(episode.Title);
                        listBox1.Items.Add(episode.Title);
                    }
                    ListViewItem listViewItem = listView1.Items.Add(feed.NumberOfEpisodes.ToString());
                    listViewItem.SubItems.Add(feed.Title);



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

      


    }
}