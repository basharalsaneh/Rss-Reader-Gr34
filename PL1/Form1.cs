using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using BL;

namespace PL1
{
    public partial class Form1 : Form
    {

        CancellationTokenSource cts = new CancellationTokenSource(); // tillåter timed out för vår async


        public Form1()
        {
            InitializeComponent();
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
            if (txtUrl.Text != null 
                && cbxFrekvens.SelectedItem != null 
                && cbxKategori.SelectedItem != null)
            {
                if (Validering.CheckURL(txtUrl.Text))
                {
                   
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