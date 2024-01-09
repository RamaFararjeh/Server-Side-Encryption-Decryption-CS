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
    public partial class HillCipher : Form
    {
        private const string CRLF = "\r\n";
        string plain_text, cipher_text = "" , plain_af_dec = "", first_key, sec_key, third_key, fourth_key;
        char first_char, sec_char;
        int first_index , sec_index, mult_1 , mult_2 , result;


        List<char> alpha = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        int[,] Key_Matrix = new int[2,2]; // Encryption

        int[,] Key_Matrix_invers = new int[2, 2]; // Decryption

        int[,] plain_Matrix = new int[2, 1];

        public static HillCipher frm_Hill_Instance;
        public TextBox txt_Instance_Cipher;
        public TextBox txt_Instance_Key_1;
        public TextBox txt_Instance_Key_2;
        public TextBox txt_Instance_Key_3;
        public TextBox txt_Instance_Key_4;

        public HillCipher()
        {
            InitializeComponent();
            btnSendMessage.Enabled = false;
            frm_Hill_Instance = this;
            txt_Instance_Cipher = txtCipher;
            txt_Instance_Key_1 = txtKey1;
            txt_Instance_Key_2 = txtKey2;
            txt_Instance_Key_3 = txtKey3;
            txt_Instance_Key_4 = txtKey4;
        }


        private void txtplaintext_TextChanged(object sender, EventArgs e)
        {
            plain_text = txtplaintext.Text.ToLower();
        }

        private void txtKey1_TextChanged(object sender, EventArgs e)
        {
            // first_key = int.Parse(txtKey1.Text);
            first_key = txtKey1.Text;
            
        }


        private void txtKey2_TextChanged(object sender, EventArgs e)
        {
            //sec_key = int.Parse(txtKey2.Text);
            sec_key = txtKey2.Text;
        }


        private void txtKey3_TextChanged(object sender, EventArgs e)
        {
            //third_key = int.Parse(txtKey3.Text);
            third_key = txtKey3.Text;
        }

        private void txtKey4_TextChanged(object sender, EventArgs e)
        {
            //fourth_key = int.Parse(txtKey4.Text);
            fourth_key = txtKey4.Text;
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtCipher.Text = "";
            cipher_text = "";
            Key_Matrix[0, 0] = Int32.Parse(first_key);
            Key_Matrix[0, 1] = Int32.Parse(sec_key);
            Key_Matrix[1, 0] = Int32.Parse(third_key);
            Key_Matrix[1, 1] = Int32.Parse(fourth_key);

            //MessageBox.Show(Key_Matrix[0, 1].ToString());
            while (plain_text.Length != 0)
            {
                if (plain_text.Length == 1)
                {
                    first_char = plain_text[0];
                    sec_char = 'a';

                    first_index = alpha.IndexOf(first_char);
                    sec_index = 0;

                    plain_Matrix[0, 0] = first_index;
                    plain_Matrix[1, 0] = sec_index;

                    // NOTE : 
                    // the original word has the one char only [ in this condition ] that's why  ,
                    // i put the parameter in remove fun from ( 0-1 ) that's mean remove the last char in the original word.

                    plain_text = plain_text.Remove(0, 1); // ahaaaa hasa fhmt 

                    mult_1 = Key_Matrix[0, 0] * plain_Matrix[0, 0];
                    //MessageBox.Show(mult_1.ToString());
                    mult_2 = Key_Matrix[0, 1] * plain_Matrix[1, 0];
                    //MessageBox.Show(mult_2.ToString());
                    result = mult_1 + mult_2;
                    result = result % 26;
                    cipher_text += alpha[result];

                    mult_1 = Key_Matrix[1, 0] * plain_Matrix[0, 0];
                    mult_2 = Key_Matrix[1, 1] * plain_Matrix[1, 0];
                    result = mult_1 + mult_2;
                    result = result % 26;
                    cipher_text += alpha[result];


                    txtCipher.Text = cipher_text;
                    
                }
                else
                {
                    // letter

                    first_char = plain_text[0];
                    sec_char = plain_text[1];

                    // index letter

                    first_index = alpha.IndexOf(first_char);
                    sec_index = alpha.IndexOf(sec_char);

                    plain_Matrix[0, 0] = first_index;
                    plain_Matrix[1, 0] = sec_index;

                    plain_text = plain_text.Remove(0, 2);

                    //MessageBox.Show(plain_Matrix[1,0].ToString());
                    // Multiply matrix

                    mult_1 = Key_Matrix[0, 0] * plain_Matrix[0, 0];
                    //MessageBox.Show(mult_1.ToString());
                    mult_2 = Key_Matrix[0, 1] * plain_Matrix[1, 0];
                    //MessageBox.Show(mult_2.ToString());
                    result = mult_1 + mult_2;
                    result = result % 26;
                    cipher_text += alpha[result];

                    mult_1 = Key_Matrix[1, 0] * plain_Matrix[0, 0];
                    mult_2 = Key_Matrix[1, 1] * plain_Matrix[1, 0];
                    result = mult_1 + mult_2;
                    result = result % 26;
                    cipher_text += alpha[result];


                     txtCipher.Text = cipher_text;

                }
            }
            txtCipher.Text = cipher_text;
            btnSendMessage.Enabled = true;
            //MessageBox.Show(alpha[12].ToString());
            //MessageBox.Show(alpha[17].ToString());
            //MessageBox.Show(plain_Matrix[0, 0].ToString());
            //MessageBox.Show(plain_Matrix[1, 0].ToString());


        }


        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            cipher_text = txtCipher.Text;
            //MessageBox.Show(cipher_text);
            plain_af_dec = "";
            //txtplaintext.Text = ""; //nop 

            // key invers = 1 / determinate * adj k 

            Key_Matrix[0, 0] = Int32.Parse(first_key);
            Key_Matrix[0, 1] = Int32.Parse(sec_key);
            Key_Matrix[1, 0] = Int32.Parse(third_key);
            Key_Matrix[1, 1] = Int32.Parse(fourth_key);

            // find determinate
            int determinate;
            determinate = (Key_Matrix[0, 0] * Key_Matrix[1, 1]) - (Key_Matrix[0, 1] * Key_Matrix[1, 0]);

            // find adjoint to key

            // int temp = Key_Matrix_invers 
            Key_Matrix_invers[0, 0] = Key_Matrix[1, 1];
            Key_Matrix_invers[1, 1] = Key_Matrix[0, 0];
            Key_Matrix_invers[0, 1] = 26 - Key_Matrix[0, 1];
            Key_Matrix_invers[1, 0] = 26 - Key_Matrix[1, 0];

            int number = 1;
            while ((determinate * number) % 26 != 1)
            {
                number++;
            }

            determinate = number;

            // find key invers to decryption using hill cipher.

            Key_Matrix_invers[0, 0] = Key_Matrix_invers[0, 0] * determinate;
            Key_Matrix_invers[1, 1] = Key_Matrix_invers[1, 1] * determinate;
            Key_Matrix_invers[0, 1] = Key_Matrix_invers[0, 1] * determinate;
            Key_Matrix_invers[1, 0] = Key_Matrix_invers[1, 0] * determinate;

            Key_Matrix_invers[0, 0] = Key_Matrix_invers[0, 0] % 26;
            Key_Matrix_invers[1, 1] = Key_Matrix_invers[1, 1] % 26;
            Key_Matrix_invers[0, 1] = Key_Matrix_invers[0, 1] % 26;
            Key_Matrix_invers[1, 0] = Key_Matrix_invers[1, 0] % 26;

            /*MessageBox.Show(Key_Matrix_invers[0, 0].ToString());
            MessageBox.Show(Key_Matrix_invers[1, 1].ToString());
            MessageBox.Show(Key_Matrix_invers[0, 1].ToString());
            MessageBox.Show(Key_Matrix_invers[1, 0].ToString());*/



            while (cipher_text.Length != 0)
            {
                // letter

                first_char = cipher_text[0];
                sec_char = cipher_text[1];

                /*MessageBox.Show(first_char.ToString());
                MessageBox.Show(sec_char.ToString());*/

                // index letter

                first_index = alpha.IndexOf(first_char);
                sec_index = alpha.IndexOf(sec_char);

                plain_Matrix[0, 0] = first_index;
                plain_Matrix[1, 0] = sec_index;

                cipher_text = cipher_text.Remove(0, 2);

                // Multiply matrix

                mult_1 = Key_Matrix_invers[0, 0] * plain_Matrix[0, 0];
                //MessageBox.Show(mult_1.ToString());
                mult_2 = Key_Matrix_invers[0, 1] * plain_Matrix[1, 0];
                //MessageBox.Show(mult_2.ToString());
                result = mult_1 + mult_2;
                result = result % 26;
                plain_af_dec += alpha[result];

                mult_1 = Key_Matrix_invers[1, 0] * plain_Matrix[0, 0];
                mult_2 = Key_Matrix_invers[1, 1] * plain_Matrix[1, 0];
                result = mult_1 + mult_2;
                result = result % 26;
                plain_af_dec += alpha[result];


                txtplaintext.Text = "";
                txtCipher.Text = "";
                txtKey1.Text = "";
                txtKey2.Text = "";
                txtKey3.Text = "";
                txtKey4.Text = "";
                txtplaintext.Text = plain_af_dec;


            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtplaintext.Text = "";
            txtKey1.Text = "";
            txtKey2.Text = "";
            txtKey3.Text = "";
            txtKey4.Text = "";
            txtCipher.Text = "";
            /*int det = 9;
            int number = 1;
            while ((number * det) % 26 != 1)
            {
                number++;
            }
            MessageBox.Show(number.ToString());*/

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            //

            try
            {
                if (Client.frm_Instance_Server.client.Connected)
                {
                    StreamWriter writer = new StreamWriter(Client.frm_Instance_Server.client.GetStream());
                    writer.WriteLine("S1-"+ txtCipher.Text+"-"+3+"-"+txtKey1.Text+"-"+txtKey2.Text+"-"+txtKey3.Text+"-"+txtKey4.Text);
                    writer.Flush();
                    Client.frm_Instance_Server.txt_Status_Instance.Text += CRLF + "Command Sent to Server: " + txtCipher.Text;
                    txtplaintext.Text = string.Empty;
                    txtCipher.Text = string.Empty;
                    txtKey1.Text = string.Empty;
                    txtKey2.Text = string.Empty;
                    txtKey3.Text = string.Empty;
                    txtKey4.Text = string.Empty;

                }

            }
            catch (Exception ex)
            {
                Client.frm_Instance_Server.txt_Status_Instance.Text += CRLF + "Problem sending command to server...";
                Client.frm_Instance_Server.txt_Status_Instance.Text += CRLF + ex.ToString();
            }
        }
    }
}
