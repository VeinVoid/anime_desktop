using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DesktopPAS
{
    public partial class LoginForm : Form
    {

        String usernameReg;
        String passwordReg;
        String emailReg;

        public LoginForm(String username, String password, String email)
        {
            InitializeComponent();

            SetPictureBoxRoundedCorners(pictureBox1, 5);

            label4.MouseEnter += label4_MouseEnter;
            label4.Click += label4_Click;

            usernameReg = username;
            passwordReg = password;
            emailReg = email;
        }


        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Cursor = Cursors.Hand;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Height = textBox2.PreferredHeight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == usernameReg && textBox2.Text == passwordReg)
            {
                Dashboard dashboard = new Dashboard(usernameReg, emailReg, passwordReg);
                dashboard.Show();
                this.Hide();
            }
            else if(textBox1.Text == "" && textBox2.Text == "")
            {
                DialogResult dialogResult = MessageBox.Show("Masukkan akun anda", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Akun anda salah", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}