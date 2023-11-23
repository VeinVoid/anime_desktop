using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopPAS
{
    public partial class Dashboard : Form
    {
        NewsPage newsPage = new NewsPage { Dock = DockStyle.Fill };
        AnimePage animePage = new AnimePage { Dock = DockStyle.Fill };
        ProfilePage profilePage = new ProfilePage { Dock = DockStyle.Fill };
        
        String usernamea;
        String emaila;
        String passworda;
        String panelActive;

        public Dashboard(String username, String email, String password)
        {
            InitializeComponent();
            configComponent();
            configValue();
            usernamea = username;
            emaila = email;
            passworda = password;
        }

        private void search()
        {
            AnimeSearch animeSearch = new AnimeSearch(textBox1.Text) { Dock = DockStyle.Fill };

            if (textBox1.Text != "")
            {
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(animeSearch);
            }
            else
            {
                this.panel3.Controls.Clear();
                if(panelActive == "newsPage")
                    this.panel3.Controls.Add(newsPage);
                else if(panelActive == "animePage")
                    this.panel3.Controls.Add(animePage);
                else if (panelActive == "profilePage")
                    this.panel3.Controls.Add(profilePage);
            }
        }

        private void configComponent()
        {
            this.panel3.Controls.Add(newsPage);
            this.panel4.Dock = DockStyle.Bottom;

            pictureBox1.ImageLocation = "../../../Assets/Icon_Image/Navbar_Alterial.png";
        }

        private void configValue()
        {
            panelActive = "newsPage";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gr_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
            
        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            label2.Font = new Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            label3.ForeColor = Color.Black;
            label3.Font = new Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            label1.ForeColor = Color.Black;
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(newsPage);
            panelActive = "newsPage";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            label2.Font = new Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            label3.ForeColor = Color.Black;
            label3.Font = new Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            label1.ForeColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(animePage);

            panelActive = "animePage";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            label2.Font = new Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            label1.ForeColor = Color.Black;
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            label3.ForeColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            label3.Font = new Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(profilePage);
           
            profilePage.Username = usernamea;
            panelActive = "profilePage";

            profilePage.UpdateAnimeList();
        }

        private void panel3_Paint_4(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(usernamea, passworda, emaila);
            login.Show();
            this.Hide();
        }

        private void panel3_Paint_5(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               search();
        }
    }

}
