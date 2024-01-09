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
    public partial class SimpleKey : Form
    {
        public static SimpleKey frm_simple_Instance;
        public TextBox txt_Instance_Cipher;
        public TextBox txt_Instance_Key;
        public Button btn_Send_Instance;        
        List<char> alpha = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<char> new_alpha = new List<char>();
        string plain_text , keyword, cipher_text,plain_after_dec;
        char plain_letter,cipher_letter;
        int index_plain,index_cipher;


        private const string CRLF = "\r\n";
        
        public SimpleKey()
        {
            InitializeComponent();
            btnSendMessage.Enabled = false;
            frm_simple_Instance = this;
            btn_Send_Instance = btnSendMessage;
            txt_Instance_Cipher = txtCipher;
            txt_Instance_Key = txtKeyWord;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtplaintext.Text = "";
            txtKeyWord.Text = "";
            txtCipher.Text = "";
        }

        private void txtplaintext_TextChanged(object sender, EventArgs e)
        {
            // not needed ? 
            plain_text = txtplaintext.Text.ToString().ToLower();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (Client.frm_Instance_Server.client.Connected)
                {
                    StreamWriter writer = new StreamWriter(Client.frm_Instance_Server.client.GetStream());
                    writer.WriteLine("S1-"+ txtCipher.Text+"-"+1+"-"+txtKeyWord.Text);
                    writer.Flush();
                    Client.frm_Instance_Server.txt_Status_Instance.Text += CRLF + "Command Sent to Server: " + txtCipher.Text;
                    txtplaintext.Text = string.Empty;
                    txtCipher.Text = string.Empty;
                    txtKeyWord.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {
                Client.frm_Instance_Server.txt_Status_Instance.Text += CRLF + "Problem sending command to server...";
                Client.frm_Instance_Server.txt_Status_Instance.Text += CRLF + ex.ToString();
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            plain_text = "";
            txtplaintext.Text = "";
            plain_after_dec = "";
           // MessageBox.Show(txtCipher.Text);
            if (txtplaintext.Text == "") // laq laeen
            {
                for (int i = 0; i < keyword.Length; i++)
                {
                    new_alpha.Add(keyword[i]);
                }
                for (int i = 0; i < 26; i++)
                {
                    int count = 0;
                    for (int j = 0; j < keyword.Length; j++)
                    {
                        if (alpha[i] == keyword[j])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        new_alpha.Add(alpha[i]);
                    }
                }
                for (int i = 0; i < txtCipher.Text.Length; i++)
                {
                    cipher_letter = txtCipher.Text[i];
                    index_cipher = new_alpha.IndexOf(cipher_letter);
                    plain_after_dec += alpha[index_cipher];
                   // MessageBox.Show(cipher_letter.ToString());
                    //MessageBox.Show(index_cipher.ToString());
                }
                //txtplaintext.Text = plain_after_dec;


            }
            else
            {
                for (int i = 0; i < txtCipher.Text.Length; i++)
                {
                    cipher_letter = cipher_text[i];
                    index_cipher = new_alpha.IndexOf(cipher_letter);
                    plain_after_dec += alpha[index_cipher];
                    //MessageBox.Show(cipher_letter.ToString());
                    //MessageBox.Show(index_cipher.ToString());
                }
                //MessageBox.Show(plain_after_dec);
                
            }
            txtplaintext.Clear();
            txtKeyWord.Clear();
            txtCipher.Clear();
            plain_text = "";
            txtplaintext.Text = plain_after_dec;
        }


        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            keyword = txtKeyWord.Text.ToString().ToLower();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            cipher_text = null;      
            if(txtKeyWord.Text == "")
            {
                MessageBox.Show("Please Enter KeyWord");
            }
            else
            {
                for (int i = 0; i < keyword.Length; i++)
                {
                    new_alpha.Add(keyword[i]);
                }
                for (int i = 0; i < 26; i++)
                {
                    int count = 0;
                    for (int j = 0; j < keyword.Length; j++)
                    {
                        if (alpha[i] == keyword[j])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        new_alpha.Add(alpha[i]);
                    }
                }
                for (int i = 0; i < plain_text.Length; i++)
                {
                    plain_letter = plain_text[i];
                    index_plain = alpha.IndexOf(plain_letter);
                    cipher_text += new_alpha[index_plain];
                }
                txtCipher.Text = cipher_text;
                btnSendMessage.Enabled = true;
                // MessageBox.Show(new_alpha.Count.ToString());
            }
            
        }
    }
}
