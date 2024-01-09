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
    public partial class PlayFair : Form
    {
        char[,] playfairMatrix = new char[5, 5];
        string plain_text, keyword , cipher_text, new_cipher="";
        char first_char, sec_char;
        int first_index, sec_index;

        private const string CRLF = "\r\n";

        public static PlayFair frm_play_flair_Instance;
        public TextBox txt_Instance_Cipher;
        public TextBox txt_Instance_Key;

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtplaintext.Text = "";
            txtKeyWord.Text = "";
            txtCipher.Text = "";
        }

        public PlayFair()
        {
            InitializeComponent();
            btnSendMessage.Enabled = false;
            frm_play_flair_Instance = this;
            txt_Instance_Cipher = txtCipher;
            txt_Instance_Key = txtKeyWord;
        }

       

        
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (Client.frm_Instance_Server.client.Connected)
                {
                    StreamWriter writer = new StreamWriter(Client.frm_Instance_Server.client.GetStream());
                    writer.WriteLine("S1-"+txtCipher.Text+"-"+2+"-"+txtKeyWord.Text);
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

        private void btnEncrypt_Click(object sender, EventArgs e)
        {                      
            plain_text = txtplaintext.Text.ToString().ToLower();
            keyword = new string(txtKeyWord.Text.Distinct().ToArray()); // remove duplicate
            keyword = keyword.ToLower() + "abcdefghiklmnopqrstuvwxyz";
            keyword = new string(keyword.Distinct().ToArray());
            //MessageBox.Show(keyword);

            int index = 0;

            // Fill the Playfair matrix
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    playfairMatrix[i, j] = keyword[index];
                    index++;
                }
            }

            // MessageBox.Show(playfairMatrix.GetLength(0).ToString()); // print number of row
            //MessageBox.Show(playfairMatrix.GetLength(1).ToString()); // print number of col
            // MessageBox.Show(playfairMatrix[4, 4].ToString()); //print letter in index[4,4]
            

            while (plain_text.Length !=0)
            {
                //cipher_text = "";
                if(plain_text.Length == 1)
                {
                    first_char = plain_text[0];
                    if (first_char == 'j')
                    {
                        first_char = 'i';
                    }
                    sec_char = 'x';
                    plain_text = plain_text.Remove(0,1);
                    var first_index = index_char(first_char);
                    var sec_index = index_char(sec_char);


                    if (first_index.Item1 == sec_index.Item1) // to check if this in the same row 
                    {
                        cipher_text += playfairMatrix[first_index.Item1, mod((first_index.Item2 + 1) ,5)];
                        cipher_text += playfairMatrix[sec_index.Item1,mod( (sec_index.Item2 + 1) ,5)];
                        // MessageBox.Show(playfairMatrix[first_index.Item1, (first_index.Item2 + 1)].ToString());
                    }
                    else if (first_index.Item2 == sec_index.Item2) // to check if this the same col
                    {
                        cipher_text += playfairMatrix[mod((first_index.Item1 + 1) ,5), first_index.Item2];
                        cipher_text += playfairMatrix[mod((sec_index.Item1 + 1) ,5), sec_index.Item2];
                        //    MessageBox.Show(playfairMatrix[(first_index.Item1 + 1), first_index.Item2].ToString());
                    }
                    else
                    {
                        cipher_text += playfairMatrix[first_index.Item1, sec_index.Item2];
                        cipher_text += playfairMatrix[sec_index.Item1, first_index.Item2];
                    }

                }
                else
                {
                    if (plain_text[0] != plain_text[1])
                    {
                        first_char = plain_text[0];
                        sec_char = plain_text[1];
                        if (first_char == 'j')
                        {
                            first_char = 'i';
                        }
                        else if (sec_char == 'j')
                        {
                            sec_char = 'i';
                        }
                        plain_text = plain_text.Remove(0, 2);
                        var first_index = index_char(first_char);
                        var sec_index = index_char(sec_char);

                        //MessageBox.Show(first_index.ToString());
                        //MessageBox.Show(sec_index.ToString());

                        if (first_index.Item1 == sec_index.Item1) // to check if this in the same row 
                        {
                            cipher_text += playfairMatrix[first_index.Item1 ,mod((first_index.Item2+ 1) ,5)];
                            cipher_text += playfairMatrix[sec_index.Item1, mod((sec_index.Item2 + 1) ,5)];
                           // MessageBox.Show(playfairMatrix[first_index.Item1, (first_index.Item2 + 1)].ToString());
                        }
                        else if(first_index.Item2 == sec_index.Item2) // to check if this the same col
                        {
                            cipher_text += playfairMatrix[mod((first_index.Item1 + 1) ,5), first_index.Item2];
                            cipher_text += playfairMatrix[mod((sec_index.Item1 + 1) ,5), sec_index.Item2];
                            //    MessageBox.Show(playfairMatrix[(first_index.Item1 + 1), first_index.Item2].ToString());
                        }
                        else
                        {
                            cipher_text += playfairMatrix[first_index.Item1, sec_index.Item2];
                            cipher_text += playfairMatrix[sec_index.Item1, first_index.Item2];
                        }
                        

                        //MessageBox.Show(first_char.ToString());
                        //MessageBox.Show(sec_char.ToString());
                    }
                    else
                    {
                        first_char = plain_text[0];
                        if (first_char == 'j')
                        {
                            first_char = 'i';
                        }
                        sec_char = 'x';
                        plain_text = plain_text.Remove(0, 1);
                        var first_index = index_char(first_char);
                        var sec_index = index_char(sec_char);

                        if (first_index.Item1 == sec_index.Item1) // to check if this in the same row 
                        {
                            cipher_text += playfairMatrix[first_index.Item1,mod( (first_index.Item2 + 1) ,5)];
                            cipher_text += playfairMatrix[sec_index.Item1,mod( (sec_index.Item2 + 1) ,5)];
                            // MessageBox.Show(playfairMatrix[first_index.Item1, (first_index.Item2 + 1)].ToString());
                        }
                        else if (first_index.Item2 == sec_index.Item2) // to check if this the same col
                        {
                            cipher_text += playfairMatrix[mod((first_index.Item1 + 1) ,5), first_index.Item2];
                            cipher_text += playfairMatrix[mod((sec_index.Item1 + 1) ,5), sec_index.Item2];
                            //    MessageBox.Show(playfairMatrix[(first_index.Item1 + 1), first_index.Item2].ToString());
                        }
                        else
                        {
                            cipher_text += playfairMatrix[first_index.Item1, sec_index.Item2];
                            cipher_text += playfairMatrix[sec_index.Item1,first_index.Item2];
                        }
                    }
                }
            }
            // MessageBox.Show(cipher_text);            
            txtCipher.Text = cipher_text;

            // NOTE :
            // I do like this cuz if the user need to encrypt twice after each other , no interference occure betwwen the
            // prev word with new word .
            // and the [ new_cipher ] i creat this var cuz i need using the cipher text into decryption ,
            // but after encrption for each word i clean the var from word so i stored the value in other var if the user ,
            // need to decryption .

            new_cipher = cipher_text;
            cipher_text = ""; 
            btnSendMessage.Enabled = true;


        }
        public (int, int) index_char(char ch)
        {
            for(int i = 0; i < playfairMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < playfairMatrix.GetLength(1); j++)
                {
                    if (ch == playfairMatrix[i, j])
                    {
                        /*first_index = i;
                        sec_index = j;
                        break;*/
                        return (i,j);
                    }
                }
            }
            return (-1, -1); // hon fe laqq.
        }

        int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            new_cipher = txtCipher.Text; // lo sar moshkelah shofi hoon aol ashii .-.
            /*txtCipher.Text = "";
            txtKeyWord.Text = "";*/ // kaman ibrahem

            keyword = new string(txtKeyWord.Text.Distinct().ToArray()); // remove duplicate
            keyword = keyword.ToLower() + "abcdefghiklmnopqrstuvwxyz";
            keyword = new string(keyword.Distinct().ToArray());

            //MessageBox.Show(keyword);
            int index = 0;
            // Fill the Playfair matrix
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    playfairMatrix[i, j] = keyword[index];
                    index++;
                }
            }

            string plain_text_after_dec ="";
            if (txtplaintext.Text == "")
            {
                while (new_cipher.Length != 0)
                {
                    if (new_cipher[0] != new_cipher[1])
                    {
                        first_char = new_cipher[0];
                        sec_char = new_cipher[1];
                        new_cipher = new_cipher.Remove(0, 2);
                        var first_index = index_char(first_char);
                        var sec_index = index_char(sec_char);

                        //MessageBox.Show(first_index.ToString());
                        //MessageBox.Show(sec_index.ToString());

                        if (first_index.Item1 == sec_index.Item1) // to check if this in the same row 
                        {
                            plain_text_after_dec += playfairMatrix[first_index.Item1, mod((first_index.Item2 - 1) ,5)];
                            plain_text_after_dec += playfairMatrix[sec_index.Item1, mod((sec_index.Item2 - 1) , 5)];
                            // MessageBox.Show(playfairMatrix[first_index.Item1, (first_index.Item2 + 1)].ToString());
                        }
                        else if (first_index.Item2 == sec_index.Item2) // to check if this the same col
                        {
                            plain_text_after_dec += playfairMatrix[mod((first_index.Item1 - 1) , 5), first_index.Item2];
                            plain_text_after_dec += playfairMatrix[mod((sec_index.Item1 - 1) , 5), sec_index.Item2];
                            //    MessageBox.Show(playfairMatrix[(first_index.Item1 + 1), first_index.Item2].ToString());
                        }
                        else
                        {
                            plain_text_after_dec += playfairMatrix[first_index.Item1, sec_index.Item2];
                            plain_text_after_dec += playfairMatrix[sec_index.Item1, first_index.Item2];
                        }

                    }
                }
                //MessageBox.Show(plain_text_after_dec);
                
            }
            else
            {
                plain_text_after_dec = "";
                while (new_cipher.Length != 0)
                {
                    if (new_cipher[0] != new_cipher[1])
                    {
                        first_char = new_cipher[0];
                        sec_char = new_cipher[1];
                        new_cipher = new_cipher.Remove(0, 2);
                        var first_index = index_char(first_char);
                        var sec_index = index_char(sec_char);


                        MessageBox.Show(first_index.ToString());
                        MessageBox.Show(sec_index.ToString());

                        if (first_index.Item1 == sec_index.Item1) // to check if this in the same row 
                        {
                            plain_text_after_dec += playfairMatrix[first_index.Item1, (first_index.Item2 - 1) % 5];
                            plain_text_after_dec += playfairMatrix[sec_index.Item1, (sec_index.Item2 - 1) % 5];
                            // MessageBox.Show(playfairMatrix[first_index.Item1, (first_index.Item2 + 1)].ToString());
                        }
                        else if (first_index.Item2 == sec_index.Item2) // to check if this the same col
                        {
                            plain_text_after_dec += playfairMatrix[(first_index.Item1 - 1) % 5, first_index.Item2];
                            plain_text_after_dec += playfairMatrix[(sec_index.Item1 - 1) % 5, sec_index.Item2];
                            //    MessageBox.Show(playfairMatrix[(first_index.Item1 + 1), first_index.Item2].ToString());
                        }
                        else
                        {
                            plain_text_after_dec += playfairMatrix[first_index.Item1, sec_index.Item2];
                            plain_text_after_dec += playfairMatrix[sec_index.Item1, first_index.Item2];
                        }
                    }
                }
                //MessageBox.Show(plain_text_after_dec);
                
            }
            txtplaintext.Clear();
            txtKeyWord.Clear();
            txtCipher.Clear();
            txtplaintext.Text = plain_text_after_dec;
            plain_text_after_dec = "";
        }
    }
}
