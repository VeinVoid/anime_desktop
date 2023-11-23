using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPAS
{
    public partial class NewsPage : UserControl
    {

        private MockupData dataProvider;
        private Wishlist wishlist;

        public NewsPage()
        {
            wishlist = Wishlist.Instance;
            InitializeComponent();
            dataProvider = new MockupData();
            InitializeAnimeWinterData();
        }


        private void InitializeAnimeWinterData()
        {
            var animeWinterData = dataProvider.GetAnimeBySeason().Where(anime => anime.Season == "Winter").ToList();
            var animeSpringData = dataProvider.GetAnimeBySeason().Where(anime => anime.Season == "Spring").ToList();
            var animeSummerData = dataProvider.GetAnimeBySeason().Where(anime => anime.Season == "Summer").ToList();

            foreach (var anime in animeWinterData)
            {
                AddAnimeToFlowLayout(anime, flowLayoutPanel1);
            }

            foreach (var anime in animeSpringData)
            {
                AddAnimeToFlowLayout(anime, flowLayoutPanel2);
            }

            foreach (var anime in animeSummerData)
            {
                AddAnimeToFlowLayout(anime, flowLayoutPanel3);
            }
        }

        private void AddAnimeToFlowLayout(MockupData.AnimeData animeData, FlowLayoutPanel flowLayoutPanel)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(animeData.Image);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width = 160;
            pictureBox.Height = 209;
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Click += (sender, e) =>
            {
                Wishlist.Instance.AddSelectedAnime(animeData);
                MessageBox.Show($"Anime '{animeData.Title}' telah dipilih!");
            };

            Label genreLabel = new Label();
            genreLabel.Text = animeData.Genre;
            genreLabel.Font = new Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            genreLabel.Location = new Point(5, 221);
            genreLabel.Width = 150;
            genreLabel.Cursor = Cursors.Hand;
            genreLabel.Click += (sender, e) =>
            {
                Wishlist.Instance.AddSelectedAnime(animeData);
                MessageBox.Show($"Anime '{animeData.Title}' telah dipilih!");
            };

            Label titleTextBox = new Label();
            titleTextBox.Text = animeData.Title;
            titleTextBox.Font = new Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            titleTextBox.Location = new Point(5, 240);
            titleTextBox.Height = 50;
            titleTextBox.Width = 150;
            titleTextBox.Cursor = Cursors.Hand;
            titleTextBox.Click += (sender, e) =>
            {
                string selectedAnimeTitles = string.Join(", ", wishlist.SelectedAnimeData.Select(anime => anime.Title));
                Wishlist.Instance.AddSelectedAnime(animeData);
                MessageBox.Show($"Anime '{selectedAnimeTitles}' telah dipilih!");
            };

            GroupBox groupBox = new GroupBox();
            groupBox.Width = 160;
            groupBox.Height = 300;
            groupBox.Controls.Add(pictureBox);
            groupBox.Controls.Add(genreLabel);
            groupBox.Controls.Add(titleTextBox);

            groupBox.Click += (sender, e) =>
            {
                Wishlist.Instance.AddSelectedAnime(animeData);
                MessageBox.Show($"Anime '{animeData.Title}' telah dipilih!");
            };

            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.Controls.Add(groupBox);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
