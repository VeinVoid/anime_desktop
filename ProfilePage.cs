using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesktopPAS.MockupData;

namespace DesktopPAS
{
    public partial class ProfilePage : UserControl
    {
        Wishlist wishlist;
        private string username;
        private string email;

        public ProfilePage()
        {
            InitializeComponent();
            wishlist = Wishlist.Instance;
        }

        private void InitializeAnimeWinterData()
        {
            foreach (var anime in wishlist.SelectedAnimeData)
            {
                AddAnimeToFlowLayout(anime, flowLayoutPanel1);
            }
            wishlist.SelectedAnimeData.Clear();
        }


        private void AddAnimeToFlowLayout(AnimeData animeData, FlowLayoutPanel flowLayoutPanel)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(animeData.Image);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width = 160;
            pictureBox.Height = 209;
            pictureBox.Cursor = Cursors.Hand;

            Label genreLabel = new Label();
            genreLabel.Text = animeData.Genre;
            genreLabel.Font = new Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            genreLabel.Location = new Point(5, 221);
            genreLabel.Width = 150;
            genreLabel.Cursor = Cursors.Hand;

            Label titleTextBox = new Label();
            titleTextBox.Text = animeData.Title;
            titleTextBox.Font = new Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            titleTextBox.Location = new Point(5, 240);
            titleTextBox.Height = 50;
            titleTextBox.Width = 150;
            titleTextBox.Cursor = Cursors.Hand;

            GroupBox groupBox = new GroupBox();
            groupBox.Width = 160;
            groupBox.Height = 300;
            groupBox.Controls.Add(pictureBox);
            groupBox.Controls.Add(genreLabel);
            groupBox.Controls.Add(titleTextBox);

            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.Controls.Add(groupBox);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public string Username
        {
            set
            {
                username = value;
                email = value;
            }
        }

        public void UpdateAnimeList()
        {
            InitializeAnimeWinterData();
            label1.Text = username;
            label2.Text = email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
