using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using client_server.Utils;

namespace client_server
{
    public partial class CaesearChiper : Form
    {
        
        string plain_text;
        string cipher_text,plain_af_dec="";        
        int c, p, k;



        List<char> alpha = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<char> new_alpha = new List<char>();
        private const string CRLF = "\r\n";

        /*public static Client frm_Instace_client;
        public TextBox txt_IPAddress_Instance;
        public TextBox txt_Port_Instance;
        public TextBox txt_Status_Instance;
        public Button btn_Connected_Instance;
        public Button btn_dis_Connected_Instance;*/
        public static CaesearChiper frm_Instance_caesear;
        public TextBox txt_Instance_plain;
        public TextBox txt_Instance_Key;
        public TextBox txt_Instance_Cipher;


        public CaesearChiper()
        {
            InitializeComponent();            
            btnSendMessage.Enabled = false;
            frm_Instance_caesear = this;
            txt_Instance_plain = txtplaintext;
            txt_Instance_Cipher = txtCipher;
            txt_Instance_Key = txtkey1;  
        }  

        private void txtplaintext_TextChanged(object sender, EventArgs e)
        {
            plain_text = txtplaintext.Text.ToString().ToLower();
        }

        private void txtkey1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            plain_af_dec = "";
            plain_text = "";
            txtplaintext.Text = "";
            txtkey1.Text = "";
            txtCipher.Text = "";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            plain_af_dec = "";
            plain_text = null;
            txtplaintext.Text = null;
            int k = int.Parse(txtkey1.Text);
            char c_dec;
            int c, m_dec;

            for (int i = k; i < alpha.Count; i++)
            {
                new_alpha.Add(alpha[i]);
            }
            for (int i = 0; i < k; i++)
            {
                new_alpha.Add(alpha[i]);
            }

            for (int i = 0; i < txtCipher.Text.Length; i++)
            {
                c_dec = txtCipher.Text[i];
                c = alpha.IndexOf(c_dec);
                m_dec = (c - k) % 26;
                plain_af_dec += alpha[m_dec];

            }      
            plain_text = plain_af_dec;
            //MessageBox.Show(plain_af_dec);
            txtkey1.Clear();
            txtCipher.Clear();
            txtplaintext.Text = plain_af_dec;

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
           try
            {
                MessageBox.Show(Client.frm_Instance_Server.client.GetStream().ToString());
                StreamWriter writer = new StreamWriter(Client.frm_Instance_Server.client.GetStream());
                writer.WriteLine("S1-"+txtCipher.Text+"-"+0+"-"+txtkey1.Text);
                writer.Flush();
                Client.frm_Instance_Server.txt_Status_Instance.Text += CRLF + "Command Sent to Server: " + txtCipher.Text;
                txtplaintext.Text = string.Empty;
                txtCipher.Text = string.Empty;
                txtkey1.Text = string.Empty;
                

            }
            catch (Exception ex)
            {
                Client.frm_Instance_Server.txt_Status_Instance.Text += CRLF + "Problem sending command to server...";
                Client.frm_Instance_Server.txt_Status_Instance.Text += CRLF + ex.ToString();
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            cipher_text = null;
            int n_plain_txt = plain_text.Length;

            char p_txt;

            k = int.Parse(txtkey1.Text);

            // for loop => Encryption 

            for (int i = 0; i < n_plain_txt; i++)
            {
                p_txt = plain_text[i];
                p = alpha.IndexOf(p_txt);
                c = (p + k) % 26;
                cipher_text += alpha[c];

                // MessageBox.Show(alpha.IndexOf().ToString());
            }

           // MessageBox.Show("Plain Text :" + plain_text);
            //MessageBox.Show("Cipher Text :" + cipher_text);
            //MessageBox.Show("algo " + Algo); // اذن هيها شغاله 
            txtCipher.Text = cipher_text;
            //frm_Server.frm1TOfrm2 (cipher_text);
            btnSendMessage.Enabled = true;
        }
    }

}
