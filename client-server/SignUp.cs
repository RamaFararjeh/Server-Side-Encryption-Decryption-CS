using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace client_server
{
    public partial class SignUp : Form
    {
        public SignUp()
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
        private List<User> userlist = new List<User>();
        private void btnSignup_Click(object sender, EventArgs e)
        {

           if (txtUser.Text == "")
           {
                MessageBox.Show("please fill all this fields.");
           }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("please fill all this fields.");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("please fill all this fields.");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("please fill all this fields.");
            }
            else
            {
                //if (! txtEmail.Text.Contains("@") && !(txtEmail.Text.Contains(".com")))
                //{
                  //  MessageBox.Show("Invalid Email");
                //}
                //else
                //{
                    id++;
                    user = new User(id, txtUser.Text, txtPass.Text, txtAddress.Text, txtEmail.Text);

                    userlist.Add(user);
                    txtUser.Clear();
                    txtPass.Clear();
                    txtAddress.Clear();
                    txtEmail.Clear();
                    // to close the main form form sign up btn.
                    loginForm loginForm = Application.OpenForms.OfType<loginForm>().Where(x => x.Name == "loginForm").FirstOrDefault();
                    loginForm.Hide();
                    Client client = new Client();
                    client.Closed += (s, args) => this.Close();
                    client.Show();
                //}
                
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "User Name")
            {
                txtUser.Text = "";
                //MessageBox.Show("Rama");
                txtUser.BackColor = Color.White;
                txtUser.ForeColor = Color.FromArgb(115, 79, 150);
                pnlUser.BackColor = Color.White;

                pnlPass.BackColor = SystemColors.Control;
                txtPass.BackColor = SystemColors.Control;

                pnlAddress.BackColor = SystemColors.Control;
                txtAddress.BackColor = SystemColors.Control;

                pnlEmail.BackColor = SystemColors.Control;
                txtEmail.BackColor = SystemColors.Control;
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

                pnlAddress.BackColor = SystemColors.Control;
                txtAddress.BackColor = SystemColors.Control;

                pnlEmail.BackColor = SystemColors.Control;
                txtEmail.BackColor = SystemColors.Control;
            }
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
                
                //MessageBox.Show("Rama");
                txtAddress.BackColor = Color.White;
                txtAddress.ForeColor = Color.FromArgb(115, 79, 150);
                pnlAddress.BackColor = Color.White;

                txtUser.BackColor = SystemColors.Control;
                pnlUser.BackColor = SystemColors.Control;

                pnlPass.BackColor = SystemColors.Control;
                txtPass.BackColor = SystemColors.Control;

                pnlEmail.BackColor = SystemColors.Control;
                txtEmail.BackColor = SystemColors.Control;
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                
                //MessageBox.Show("Rama");
                txtEmail.BackColor = Color.White;
                txtEmail.ForeColor = Color.FromArgb(115, 79, 150);
                pnlEmail.BackColor = Color.White;

                txtUser.BackColor = SystemColors.Control;
                pnlUser.BackColor = SystemColors.Control;

                pnlAddress.BackColor = SystemColors.Control;
                txtAddress.BackColor = SystemColors.Control;

                pnlPass.BackColor = SystemColors.Control;
                txtPass.BackColor = SystemColors.Control;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
           
            Regex passwordRegex;
            if (txtPass.Text.Trim() != string.Empty)
            {
                // Customize the regular expression for your password requirements
                passwordRegex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$");

                if (!passwordRegex.IsMatch(txtPass.Text.Trim()))
                {
                    MessageBox.Show("Password must contain at least 8 characters, including one uppercase letter, one lowercase letter, one digit, and one special character.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Focus();
                }
            }
        }

        private void pictureBox2_MouseHover_1(object sender, EventArgs e)
        {
            MessageBox.Show("must be between 8 and 15 characters long.\n must contain at least one number.\n must contain at least one uppercase letter.\n must contain at least one lowercase letter", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
