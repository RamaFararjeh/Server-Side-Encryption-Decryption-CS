using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace client_server
{
    public partial class loginForm : Form
    {


        bool flage = false;
        public loginForm()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private User user;
        private int id = 0;
        private List<User> userlist = new List<User>(); // amanehhhhh say wallahhh

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtUser.Text);
            if(txtUser.Text == "User Name")
            {
                txtUser.Text = "";
                //MessageBox.Show("Rama");
                txtUser.BackColor = Color.White;
                txtUser.ForeColor = Color.FromArgb(115, 79, 150);
                pnlUser.BackColor = Color.White;
                pnlPass.BackColor = SystemColors.Control;
                txtPass.BackColor = SystemColors.Control;
                txtCaptcha.BackColor = SystemColors.Control;
                pnlCaptcha.BackColor = SystemColors.Control;
            }

        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                //MessageBox.Show("Rama");
                txtPass.BackColor = Color.White;
                txtPass.ForeColor = Color.FromArgb(115, 79, 150);
                pnlPass.BackColor = Color.White;
                txtUser.BackColor = SystemColors.Control;
                pnlUser.BackColor = SystemColors.Control;
                txtCaptcha.BackColor = SystemColors.Control;
                pnlCaptcha.BackColor = SystemColors.Control;
            }
        }


        private void txtCaptcha_Click(object sender, EventArgs e)
        {
            if (txtCaptcha.Text == "Captcha")
            {
                txtCaptcha.Text = "";
                //MessageBox.Show("Rama");
                txtCaptcha.BackColor = Color.White;
                txtCaptcha.ForeColor = Color.FromArgb(115,79,150);
                pnlCaptcha.BackColor = Color.White;
                txtUser.BackColor = SystemColors.Control;
                pnlUser.BackColor = SystemColors.Control;
                txtPass.BackColor = SystemColors.Control;
                pnlPass.BackColor = SystemColors.Control;
            }
        }

        // To Show the pass when press the btn
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            pnlrightlogin.Controls.Clear();
            SignUp caesear = new SignUp();
            caesear.TopLevel = false;
            // hoon 
            pnlrightlogin.Controls.Add(caesear);
            caesear.Closed += (s, args) => this.Close();
            caesear.Show();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Rama Fararjeh" && txtPass.Text == "8888" && txtCaptcha.Text == lblCaptcha.Text)
            {
                this.Hide();
                Client client = new Client();
                client.Closed += (s, args) => this.Close();
                client.Show();
            }
            else
            {
                if (txtUser.Text == null || txtPass.Text == "")
                {
                    MessageBox.Show("please fill this textbox");

                }
                else if (txtCaptcha.Text != lblCaptcha.Text)
                {
                    MessageBox.Show("Captcha miss match","Captcha",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                }
            }
            
        }

        private void rbtnSignUp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSignUp.Checked)
            {
                btnLogin.Enabled = false;

            }
        }


        //اههههه يلي عملتهم مع ابراهيم 
        // to keep the page moving.
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // test
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client client = new Client();
            client.Closed += (s, args) => this.Close();
            client.Show();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

            lblCaptcha.Text = captcha();
            /*if(flage == true)
            {
                this.Invalidate();
                this.Update();
            }*/
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            lblCaptcha.Text = captcha();
            
        }

        public static string captcha()
        {
            Random rand = new Random();
            rand.Next(48, 123);
            string captcha = "";

            int len = 6;
            while (len != 0)
            {

                int ch = rand.Next(48, 123);
                if ((ch >= 48 && ch <= 57) || (ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122))
                {
                    // MessageBox.Show(ch.ToString()+(char)ch);
                    captcha = captcha + (char)ch;
                    len--;
                }
            }
            //lblCaptcha.Text = captcha;
            return captcha;
        }

        // Show Info About Crypt
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            info.Closed += (s, args) => this.Close();
            info.Show();
        }
    }
    
}
