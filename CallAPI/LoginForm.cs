using BLL;
using CallAPI;
using DTO;
using GUI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserControl2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void userControl11__TextChanged(object sender, EventArgs e)
        {
            //if (userControl11.textBox1_Text.Length >= 5)
            //{
            //    label1.Text = "";
            //    if (userControl11.textBox1_Text.Contains(" "))
            //    {
            //        userControl11.BorderColor = Color.Red;
            //        label1.Text = "Username không được có khoảng trắng";
            //    }
            //    else
            //    {
            //        userControl11.BorderColor = Color.Orange;
            //    }
            //}
            //else
            //{
            //    userControl11.BorderColor = Color.Red;
            //    label1.Text = "UserName Phải từ 5 kí tự";
            //}

        }

        private void userControl12__TextChanged(object sender, EventArgs e)
        {

            //if (userControl12.textBox1_Text.Length >= 8 && userControl12.textBox1_Text.Length <= 20)
            //{
            //    label4.Text = "";
            //    if (userControl12.textBox1_Text.Contains(" "))
            //    {
            //        label4.Text = "Password không được chứa khoảng trắng";
            //        userControl12.BorderColor = Color.Red;
            //    }
            //    else
            //    {
            //        label4.Text = "";
            //        userControl12.BorderColor = Color.Orange;
            //    }
            //}
            //else
            //{
            //    userControl12.BorderColor = Color.Red;
            //    label4.Text = "Password phải từ 8 - 20 kí tự";
            //}
            if (eyeHurt > 2)
            {
                //tính năng xàm xàm nghịch cho vui =))
                if (userControl12.textBox1_Text.Equals("sorry"))
                {
                    eyeHurt = 0;
                    btnLogin.Enabled = true;
                }
            }
        }
        public void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SplashScreen splForm = new SplashScreen();
            Thread t;
            //bool stopThread = false;
            t = new Thread(() =>
            {
                splForm.ShowDialog();
            });
            t.Start();
            //kết nối và lấy data user từ lớp BLL
            ApiBLL apiBLL = new ApiBLL();
            List<User> u = (List<User>)apiBLL.getJsonForGUI();
            bool access = false;
            //mã hóa password trước khi so sánh
            string encrypt = Program.EncryptSHA512Managed(userControl12.textBox1_Text);
            foreach (User user in u)
            {
                //bool pwMatch = BCrypt.Net.BCrypt.Verify(userControl12.textBox1_Text, user.Password);
                if (user.Username.Equals(userControl11.textBox1_Text) && user.Password.Equals(encrypt))
                {
                    access = true;
                    Program.userName = userControl11.textBox1_Text;
                }

            }
            Thread.Sleep(500);
            if (access)
            {
                if (t.IsAlive)
                {
                    splForm.Invoke(new MethodInvoker(splForm.Close));
                }
                //SplashScreen splForm = new SplashScreen();
                FormMain fm = new FormMain();
                fm.Show();
            }
            else
            {
                this.Show();
                if (t.IsAlive)
                {
                    // Close the SplashScreen form by invoking on the UI thread
                    splForm.Invoke(new MethodInvoker(splForm.Close));
                }
                MessageBox.Show("Sai UserName hoặc Password");
            }

        }
        //khúc này nghịch thôi =))
        private void pbEye_Click(object sender, EventArgs e)
        {
            eyeOpen();
        }
        Boolean EyeOpen = false;
        int eyeHurt = 0;
        private void eyeOpen()
        {
            if (EyeOpen == false)
            {
                EyeOpen = true;
                pbEye.Image = GUI.Properties.Resources.open_eye;
                userControl12.PasswordChar = false;
                eyeHurt += 1;

            }
            else
            {
                EyeOpen = false;
                pbEye.Image = GUI.Properties.Resources.close_eye;
                userControl12.PasswordChar = true;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.tomScream);
                player.Play();
            }
        }

        private void pbEye_MouseEnter(object sender, EventArgs e)
        {
            if (eyeHurt > 2)
            {
                pbEye.Location = new Point(550, 225);
                btnLogin.Enabled = false;
            }
        }

        private void pbEye_MouseLeave(object sender, EventArgs e)
        {
            pbEye.Location = new Point(601, 225);
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
