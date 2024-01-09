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
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using client_server.Utils;

namespace client_server
{
    public partial class Client : Form
    {
        List<char> alpha = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<char> new_alpha = new List<char>();
        char[,] playfairMatrix = new char[5, 5];
        int[,] Key_Matrix = new int[2, 2];
        int[,] Key_Matrix_invers = new int[2, 2];
        int[,] plain_Matrix = new int[2, 1];

        string msg_after_dec = "";
        string input = string.Empty;

        bool isButtonClicked = false;
        bool flag_connect = false;


        // Constants
        private const string CRLF = "\r\n";

        // Fields
        private List<TcpClient> _client_list;
        private TcpListener _listener;
        private int _client_count;
        private bool _keep_going;
        private int _port = 5000;

        public static Client frm_Instance_Server;
        public TextBox txt_Status_Instance;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public TcpClient client;
        public Client()
        {
            InitializeComponent();
            _client_list = new List<TcpClient>();
            _client_count = 0;
            txtConnectedClient.Text = "0";
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
            // btnSendCommand.Enabled = false;
            txtStatus.Text = string.Empty;

            frm_Instance_Server = this;
            txt_Status_Instance = txtStatus;
            
            // server_side = new Server();
        }
       

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSimpleKey_Click(object sender, EventArgs e)
        {
            
            isButtonClicked = true;
            if (isButtonClicked)
            {
                btnSimpleKey.BackColor = Color.White;
                btnSimpleKey.ForeColor = Color.FromArgb(0, 138, 69);

                btncaesear.BackColor = Color.FromArgb(0, 138, 69);
                btncaesear.ForeColor = Color.White;

                btnPlayFair.BackColor = Color.FromArgb(0, 138, 69);
                btnPlayFair.ForeColor = Color.White;

                btnHill.BackColor = Color.FromArgb(0, 138, 69);
                btnHill.ForeColor = Color.White;

                pnlClient.Controls.Clear();
                SimpleKey simple = new SimpleKey();
                simple.TopLevel = false;
                pnlClient.Controls.Add(simple);
                simple.Show();
            }
            else
            {
                btnSimpleKey.BackColor = Color.FromArgb(0, 138, 69);
                btnSimpleKey.ForeColor = Color.White;
            }
        }

        private void btnPlayFair_Click(object sender, EventArgs e)
        {
            
            isButtonClicked = true;
            if (isButtonClicked)
            {
                btnPlayFair.BackColor = Color.White;
                btnPlayFair.ForeColor = Color.FromArgb(0, 138, 69);

                btncaesear.BackColor = Color.FromArgb(0, 138, 69);
                btncaesear.ForeColor = Color.White;

                btnSimpleKey.BackColor = Color.FromArgb(0, 138, 69);
                btnSimpleKey.ForeColor = Color.White;

                btnHill.BackColor = Color.FromArgb(0, 138, 69);
                btnHill.ForeColor = Color.White;

                pnlClient.Controls.Clear();
                PlayFair playFair = new PlayFair();
                playFair.TopLevel = false;
                pnlClient.Controls.Add(playFair);
                playFair.Show();
            }
            else
            {
                btnPlayFair.BackColor = Color.FromArgb(0, 138, 69);
                btnPlayFair.ForeColor = Color.White;
            }
        }
        private void btnHill_Click(object sender, EventArgs e)
        {
            
            isButtonClicked = true;
            if (isButtonClicked)
            {
                btnHill.BackColor = Color.White;
                btnHill.ForeColor = Color.FromArgb(0, 138, 69);

                btncaesear.BackColor = Color.FromArgb(0, 138, 69);
                btncaesear.ForeColor = Color.White;

                btnSimpleKey.BackColor = Color.FromArgb(0, 138, 69);
                btnSimpleKey.ForeColor = Color.White;

                btnPlayFair.BackColor = Color.FromArgb(0, 138, 69);
                btnPlayFair.ForeColor = Color.White;

                pnlClient.Controls.Clear();
                HillCipher hill = new HillCipher();
                hill.TopLevel = false;
                pnlClient.Controls.Add(hill);
                hill.Show();
            }
            else
            {
                btnHill.BackColor = Color.FromArgb(0, 138, 69);
                btnHill.ForeColor = Color.White;
            }
        }



        /*private void btnSend_Click(object sender, EventArgs e)
        {
            server_side.frm1TOfrm2(cipher_text, Algo, txtkey1.Text);
            server_side.Show();
        }*/

        private void btncaesear_Click(object sender, EventArgs e)
        {
            
            isButtonClicked = true;
            if (isButtonClicked)
            {
                btncaesear.BackColor = Color.White;
                btncaesear.ForeColor = Color.FromArgb(0, 138, 69);

                btnSimpleKey.BackColor = Color.FromArgb(0, 138, 69);
                btnSimpleKey.ForeColor = Color.White;

                btnPlayFair.BackColor = Color.FromArgb(0, 138, 69);
                btnPlayFair.ForeColor = Color.White;

                btnHill.BackColor = Color.FromArgb(0, 138, 69);
                btnHill.ForeColor = Color.White;

                
                //btn.BackColor = SystemColors.Control;
                pnlClient.Controls.Clear();
                CaesearChiper caesear = new CaesearChiper();
                caesear.TopLevel = false;
                pnlClient.Controls.Add(caesear);
                caesear.Show();
            }
            else
            {
                btncaesear.BackColor = Color.FromArgb(0, 138, 69);
                btncaesear.ForeColor = Color.White;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
       
       
        
        private void btn_back_connect_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Client client = new Client();
            client.Closed += (s, args) => this.Close();
            client.Show();
        }

        private void btnStartServer_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                txtConnectedClient.Text = "0";
                _client_count = 0;
                _client_list.Clear();

                if (!Int32.TryParse(txtPort.Text, out _port))
                {
                    _port = 5000;
                    txtStatus.Text = "You entered an invalid port value. Using port: " + _port;
                }

                Thread t = new Thread(ListenForIncomingConnections);
                t.Name = "Server Listener Thread";
                t.IsBackground = true;
                t.Start();
                btnStartServer.Enabled = false;
                btnStopServer.Enabled = true;
                // btnSendCommand.Enabled = true;
            }
            catch (Exception ex)
            {
                txtStatus.Text += CRLF + "Problem starting server.";
                txtStatus.Text += CRLF + ex.ToString();
            }
            btnStartServer.BackColor = Color.FromArgb(12, 193, 51);
            btnStartServer.ForeColor = Color.Black;

            btnStopServer.BackColor = Color.Black;
            btnStopServer.ForeColor = Color.White;

            Image myImage = global::client_server.Properties.Resources.status;
            pbxConnect.Image = myImage;
        }

        private void ListenForIncomingConnections()
        {
            try
            {
                _keep_going = true;
                _listener = new TcpListener(IPAddress.Any, _port);
                _listener.Start();
                txtStatus.InvokeEx(stb => stb.Text += CRLF + "Server started. Listening on port: " + _port);

                while (_keep_going)
                {
                    txtStatus.InvokeEx(stb => stb.Text += CRLF + "Waiting for incoming client connection...");
                    TcpClient client = _listener.AcceptTcpClient();   // blocks here until client connects
                    txtStatus.InvokeEx(stb => stb.Text += CRLF + "Incoming client connection accepted...");
                    Thread t = new Thread(ProcessClientRequests);
                    t.IsBackground = true;
                    t.Start(client);
                }
            }
            catch (SocketException se)
            {

                txtStatus.InvokeEx(stb => stb.Text += CRLF + "Problem starting the server.");
                txtStatus.InvokeEx(stb => stb.Text += CRLF + se.ToString());
            }
            catch (Exception ex)
            {
                txtStatus.InvokeEx(stb => stb.Text += CRLF + "Problem starting the server.");
                txtStatus.InvokeEx(stb => stb.Text += CRLF + ex.ToString());
            }

            txtStatus.InvokeEx(stb => stb.Text += CRLF + "Exiting listener thread...");
            txtStatus.InvokeEx(stb => stb.Text = String.Empty);


        }

        private void ProcessClientRequests(object o)
        {
            client = (TcpClient)o;
            _client_list.Add(client);
            _client_count += 1;
            txtConnectedClient.InvokeEx(cctb => cctb.Text = _client_count.ToString());


            //string input = string.Empty;


            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                while (client.Connected)
                {
                    input = reader.ReadLine(); // blocks here until something is received from client
                    switch (input)
                    {
                        //TODO: Add appropriate cases for commands


                        default:  // default case acts as echo server
                            {
                                txtStatus.InvokeEx(stb => stb.Text += CRLF + "From client " + client.GetHashCode() + ": " + input);
                                writer.WriteLine("Server received: " + input);
                                writer.Flush();

                                break;
                            }
                    }
                }

            }
            catch (SocketException se)
            {
                // Swallow this exception
                // _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Problem processing client requests.");
                // _statusTextBox.InvokeEx(stb => stb.Text =se.ToString());

            }
            catch (Exception ex)
            {
                txtStatus.InvokeEx(stb => stb.Text += CRLF + "Problem processing client requests. ");
                //_statusTextBox.InvokeEx(stb => stb.Text =ex.ToString());
            }

            _client_list.Remove(client);
            _client_count -= 1;
            txtConnectedClient.InvokeEx(cctb => cctb.Text = _client_count.ToString());
            txtStatus.InvokeEx(stb => stb.Text += CRLF + "Finished processing client requests for client: " + client.GetHashCode());

            if (_client_count == 0)
            {
                txtStatus.InvokeEx(stb => stb.Text = string.Empty);
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            input = "";
            _keep_going = false;
            txtStatus.Text = string.Empty;
            txtStatus.Text = "Shutting down server, disconnecting all clients.";

            try
            {



                foreach (TcpClient client in _client_list)
                {
                    client.Close();

                }
                _client_list.Clear();
                _listener.Stop();

            }
            catch (Exception ex)
            {

                txtStatus.InvokeEx(stb => stb.Text += CRLF + "Problem stopping the server, or client connections forcibly closed...");
                //_statusTextBox.InvokeEx(stb => stb.Text += CRLF + ex.ToString());
            }

            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
            //btnSendCommand.Enabled = false;
            txtStatus.Text = string.Empty;

            btnStopServer.BackColor = Color.FromArgb(242, 12, 12);
            btnStopServer.ForeColor = Color.White;

            btnStartServer.BackColor = Color.Black;
            btnStartServer.ForeColor = Color.White;
        }

        public (int, int) index_char(char ch)
        {
            for (int i = 0; i < playfairMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < playfairMatrix.GetLength(1); j++)
                {
                    if (ch == playfairMatrix[i, j])
                    {
                        /*first_index = i;
                        sec_index = j;
                        break;*/
                        return (i, j);
                    }
                }
            }
            return (-1, -1); // hon fe laqq.
        }

        
        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            string[] words;
            if (input.Contains("-"))
            {
                words = input.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

            }
            else
            {
                words = null;
            }

            if (words != null && words[0] == "C1" )
            {
                input = "";
                if (words[2] == "0")
                {
                    btncaesear_Click(sender, e);
                    CaesearChiper.frm_Instance_caesear.txt_Instance_Cipher.Text = words[1];
                    CaesearChiper.frm_Instance_caesear.txt_Instance_Key.Text = words[3];
                }
                else if (words[2] == "1")
                {
                    btnSimpleKey_Click(sender, e);
                    SimpleKey.frm_simple_Instance.txt_Instance_Cipher.Text = words[1];
                    SimpleKey.frm_simple_Instance.txt_Instance_Key.Text = words[3];
                }
                else if (words[2] == "2")
                {
                    btnPlayFair_Click(sender, e);
                    PlayFair.frm_play_flair_Instance.txt_Instance_Cipher.Text = words[1];
                    PlayFair.frm_play_flair_Instance.txt_Instance_Key.Text = words[3];
                }
                else if (words[2] == "3")
                {
                    btnHill_Click(sender, e);
                    HillCipher.frm_Hill_Instance.txt_Instance_Cipher.Text = words[1];
                    HillCipher.frm_Hill_Instance.txt_Instance_Key_1.Text = words[3];
                    HillCipher.frm_Hill_Instance.txt_Instance_Key_2.Text = words[4];
                    HillCipher.frm_Hill_Instance.txt_Instance_Key_3.Text = words[5];
                    HillCipher.frm_Hill_Instance.txt_Instance_Key_4.Text = words[6];
                }
                //MessageBox.Show(input);
            }
        }

    }
}
