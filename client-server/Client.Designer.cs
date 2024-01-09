namespace client_server
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back_connect = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHill = new System.Windows.Forms.Button();
            this.btnPlayFair = new System.Windows.Forms.Button();
            this.btnSimpleKey = new System.Windows.Forms.Button();
            this.btncaesear = new System.Windows.Forms.Button();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtConnectedClient = new System.Windows.Forms.TextBox();
            this.lblConnectedClient = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pbxConnect = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.pbxConnect);
            this.panel1.Controls.Add(this.btn_back_connect);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHill);
            this.panel1.Controls.Add(this.btnPlayFair);
            this.panel1.Controls.Add(this.btnSimpleKey);
            this.panel1.Controls.Add(this.btncaesear);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 491);
            this.panel1.TabIndex = 0;
            // 
            // btn_back_connect
            // 
            this.btn_back_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.btn_back_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_connect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_connect.ForeColor = System.Drawing.Color.White;
            this.btn_back_connect.Location = new System.Drawing.Point(-2, 398);
            this.btn_back_connect.Name = "btn_back_connect";
            this.btn_back_connect.Size = new System.Drawing.Size(202, 50);
            this.btn_back_connect.TabIndex = 43;
            this.btn_back_connect.Text = "Status";
            this.btn_back_connect.UseVisualStyleBackColor = false;
            this.btn_back_connect.Click += new System.EventHandler(this.btn_back_connect_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 40);
            this.panel7.TabIndex = 42;
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Algorithm";
            // 
            // btnHill
            // 
            this.btnHill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHill.ForeColor = System.Drawing.Color.White;
            this.btnHill.Location = new System.Drawing.Point(-2, 358);
            this.btnHill.Name = "btnHill";
            this.btnHill.Size = new System.Drawing.Size(202, 43);
            this.btnHill.TabIndex = 23;
            this.btnHill.Text = "Hill Cipher";
            this.btnHill.UseVisualStyleBackColor = true;
            this.btnHill.Click += new System.EventHandler(this.btnHill_Click);
            // 
            // btnPlayFair
            // 
            this.btnPlayFair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayFair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFair.ForeColor = System.Drawing.Color.White;
            this.btnPlayFair.Location = new System.Drawing.Point(-2, 315);
            this.btnPlayFair.Name = "btnPlayFair";
            this.btnPlayFair.Size = new System.Drawing.Size(202, 45);
            this.btnPlayFair.TabIndex = 22;
            this.btnPlayFair.Text = "Play Fair ";
            this.btnPlayFair.UseVisualStyleBackColor = true;
            this.btnPlayFair.Click += new System.EventHandler(this.btnPlayFair_Click);
            // 
            // btnSimpleKey
            // 
            this.btnSimpleKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpleKey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpleKey.ForeColor = System.Drawing.Color.White;
            this.btnSimpleKey.Location = new System.Drawing.Point(-2, 270);
            this.btnSimpleKey.Name = "btnSimpleKey";
            this.btnSimpleKey.Size = new System.Drawing.Size(202, 49);
            this.btnSimpleKey.TabIndex = 21;
            this.btnSimpleKey.Text = "Simple KeyWord";
            this.btnSimpleKey.UseVisualStyleBackColor = true;
            this.btnSimpleKey.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btncaesear
            // 
            this.btncaesear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncaesear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaesear.ForeColor = System.Drawing.Color.White;
            this.btncaesear.Location = new System.Drawing.Point(-2, 223);
            this.btncaesear.Name = "btncaesear";
            this.btncaesear.Size = new System.Drawing.Size(202, 50);
            this.btncaesear.TabIndex = 20;
            this.btncaesear.Text = "Caesear Cipher";
            this.btncaesear.UseVisualStyleBackColor = true;
            this.btncaesear.Click += new System.EventHandler(this.btncaesear_Click);
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.btnStopServer);
            this.pnlClient.Controls.Add(this.btnStartServer);
            this.pnlClient.Controls.Add(this.txtPort);
            this.pnlClient.Controls.Add(this.lblPort);
            this.pnlClient.Controls.Add(this.txtConnectedClient);
            this.pnlClient.Controls.Add(this.lblConnectedClient);
            this.pnlClient.Location = new System.Drawing.Point(200, 151);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(534, 340);
            this.pnlClient.TabIndex = 1;
            // 
            // btnStopServer
            // 
            this.btnStopServer.BackColor = System.Drawing.Color.White;
            this.btnStopServer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.btnStopServer.Location = new System.Drawing.Point(322, 90);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(97, 32);
            this.btnStopServer.TabIndex = 87;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = false;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.btnStartServer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.ForeColor = System.Drawing.Color.White;
            this.btnStartServer.Location = new System.Drawing.Point(207, 90);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(97, 32);
            this.btnStartServer.TabIndex = 86;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click_1);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(192, 50);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(245, 20);
            this.txtPort.TabIndex = 85;
            this.txtPort.Text = "5000";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            this.lblPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPort.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(61, 53);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(95, 17);
            this.lblPort.TabIndex = 84;
            this.lblPort.Text = "Listen on port";
            // 
            // txtConnectedClient
            // 
            this.txtConnectedClient.Location = new System.Drawing.Point(192, 23);
            this.txtConnectedClient.Name = "txtConnectedClient";
            this.txtConnectedClient.Size = new System.Drawing.Size(245, 20);
            this.txtConnectedClient.TabIndex = 83;
            this.txtConnectedClient.Text = "0";
            this.txtConnectedClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConnectedClient
            // 
            this.lblConnectedClient.AutoSize = true;
            this.lblConnectedClient.BackColor = System.Drawing.Color.Transparent;
            this.lblConnectedClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConnectedClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectedClient.Location = new System.Drawing.Point(61, 23);
            this.lblConnectedClient.Name = "lblConnectedClient";
            this.lblConnectedClient.Size = new System.Drawing.Size(124, 17);
            this.lblConnectedClient.TabIndex = 82;
            this.lblConnectedClient.Text = "Connected Client";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.btnClose.Location = new System.Drawing.Point(494, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 50);
            this.panel2.TabIndex = 47;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(199, 46);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(535, 109);
            this.txtStatus.TabIndex = 57;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // pbxConnect
            // 
            this.pbxConnect.Image = global::client_server.Properties.Resources.download;
            this.pbxConnect.Location = new System.Drawing.Point(12, 407);
            this.pbxConnect.Name = "pbxConnect";
            this.pbxConnect.Size = new System.Drawing.Size(40, 34);
            this.pbxConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConnect.TabIndex = 76;
            this.pbxConnect.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::client_server.Properties.Resources.icons8_client_server_66;
            this.pictureBox1.Location = new System.Drawing.Point(40, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 491);
            this.ControlBox = false;
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.Text = "Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Button btnHill;
        private System.Windows.Forms.Button btnPlayFair;
        private System.Windows.Forms.Button btnSimpleKey;
        private System.Windows.Forms.Button btncaesear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btn_back_connect;
        private System.Windows.Forms.PictureBox pbxConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtConnectedClient;
        private System.Windows.Forms.Label lblConnectedClient;
    }
}