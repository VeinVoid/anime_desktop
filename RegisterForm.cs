using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPAS
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            SetPictureBoxRoundedCorners(pictureBox1, 5);

            label7.MouseEnter += label7_MouseEnter;
            label7.Click += label7_Click;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(textBox1.Text, textBox2.Text, textBox3.Text);
            login.Show();
            this.Hide();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.Cursor = Cursors.Hand;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetPictureBoxRoundedCorners(dynamic pictureBox, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = 2 * radius;
            Rectangle rect = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Sudut kiri atas
            path.AddArc(rect.Width - diameter, rect.Y, diameter, diameter, 270, 90); // Sudut kanan atas
            path.AddArc(rect.Width - diameter, rect.Height - diameter, diameter, diameter, 0, 90); // Sudut kanan bawah
            path.AddArc(rect.X, rect.Height - diameter, diameter, diameter, 90, 90); // Sudut kiri bawah
            path.CloseFigure();

            Region region = new Region(path);
            pictureBox.Region = region;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(textBox1.Text, textBox2.Text, textBox3.Text);
            login.Show();
            this.Hide();
        }
    }
}
