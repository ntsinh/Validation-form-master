using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl2;

namespace GUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            progressBar1.Increment(5);

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                FormMain fm = new FormMain();
                fm.Show();
                this.Hide();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
        }

    }
}

