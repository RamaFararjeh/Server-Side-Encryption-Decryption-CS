namespace client_server
{
    partial class HillCipher
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblplaintext = new System.Windows.Forms.Label();
            this.txtplaintext = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtKey4 = new System.Windows.Forms.TextBox();
            this.txtKey3 = new System.Windows.Forms.TextBox();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.btnClear.Location = new System.Drawing.Point(155, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 38);
            this.btnClear.TabIndex = 88;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.White;
            this.btnDecrypt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.btnDecrypt.Location = new System.Drawing.Point(272, 264);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(97, 36);
            this.btnDecrypt.TabIndex = 87;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.btnEncrypt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(155, 262);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(97, 38);
            this.btnEncrypt.TabIndex = 86;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.btnSendMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.Location = new System.Drawing.Point(272, 306);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(97, 38);
            this.btnSendMessage.TabIndex = 84;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblplaintext
            // 
            this.lblplaintext.AutoSize = true;
            this.lblplaintext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaintext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.lblplaintext.Location = new System.Drawing.Point(49, 16);
            this.lblplaintext.Name = "lblplaintext";
            this.lblplaintext.Size = new System.Drawing.Size(76, 17);
            this.lblplaintext.TabIndex = 35;
            this.lblplaintext.Text = "plain text :";
            // 
            // txtplaintext
            // 
            this.txtplaintext.BackColor = System.Drawing.SystemColors.Control;
            this.txtplaintext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtplaintext.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaintext.ForeColor = System.Drawing.Color.Black;
            this.txtplaintext.Location = new System.Drawing.Point(123, 16);
            this.txtplaintext.Multiline = true;
            this.txtplaintext.Name = "txtplaintext";
            this.txtplaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtplaintext.Size = new System.Drawing.Size(370, 23);
            this.txtplaintext.TabIndex = 42;
            this.txtplaintext.TextChanged += new System.EventHandler(this.txtplaintext_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txtplaintext);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblplaintext);
            this.panel3.Location = new System.Drawing.Point(2, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 49);
            this.panel3.TabIndex = 82;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::client_server.Properties.Resources.msg;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.lblKey.Location = new System.Drawing.Point(48, 36);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(98, 17);
            this.lblKey.TabIndex = 37;
            this.lblKey.Text = "Key as Matrix :";
            // 
            // txtKey1
            // 
            this.txtKey1.BackColor = System.Drawing.SystemColors.Control;
            this.txtKey1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey1.ForeColor = System.Drawing.Color.Black;
            this.txtKey1.Location = new System.Drawing.Point(152, 3);
            this.txtKey1.Multiline = true;
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(43, 37);
            this.txtKey1.TabIndex = 43;
            this.txtKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey1.TextChanged += new System.EventHandler(this.txtKey1_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.txtKey4);
            this.panel6.Controls.Add(this.txtKey3);
            this.panel6.Controls.Add(this.txtKey2);
            this.panel6.Controls.Add(this.txtKey1);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.lblKey);
            this.panel6.Location = new System.Drawing.Point(3, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(531, 88);
            this.panel6.TabIndex = 83;
            // 
            // txtKey4
            // 
            this.txtKey4.BackColor = System.Drawing.SystemColors.Control;
            this.txtKey4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey4.ForeColor = System.Drawing.Color.Black;
            this.txtKey4.Location = new System.Drawing.Point(201, 48);
            this.txtKey4.Multiline = true;
            this.txtKey4.Name = "txtKey4";
            this.txtKey4.Size = new System.Drawing.Size(43, 37);
            this.txtKey4.TabIndex = 46;
            this.txtKey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey4.TextChanged += new System.EventHandler(this.txtKey4_TextChanged);
            // 
            // txtKey3
            // 
            this.txtKey3.BackColor = System.Drawing.SystemColors.Control;
            this.txtKey3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey3.ForeColor = System.Drawing.Color.Black;
            this.txtKey3.Location = new System.Drawing.Point(152, 48);
            this.txtKey3.Multiline = true;
            this.txtKey3.Name = "txtKey3";
            this.txtKey3.Size = new System.Drawing.Size(43, 37);
            this.txtKey3.TabIndex = 45;
            this.txtKey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey3.TextChanged += new System.EventHandler(this.txtKey3_TextChanged);
            // 
            // txtKey2
            // 
            this.txtKey2.BackColor = System.Drawing.SystemColors.Control;
            this.txtKey2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey2.ForeColor = System.Drawing.Color.Black;
            this.txtKey2.Location = new System.Drawing.Point(201, 3);
            this.txtKey2.Multiline = true;
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(43, 37);
            this.txtKey2.TabIndex = 44;
            this.txtKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey2.TextChanged += new System.EventHandler(this.txtKey2_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::client_server.Properties.Resources.key3;
            this.pictureBox4.Location = new System.Drawing.Point(5, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(49, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cipher text :";
            // 
            // txtCipher
            // 
            this.txtCipher.BackColor = System.Drawing.SystemColors.Control;
            this.txtCipher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCipher.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCipher.ForeColor = System.Drawing.Color.Black;
            this.txtCipher.Location = new System.Drawing.Point(139, 16);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCipher.Size = new System.Drawing.Size(370, 23);
            this.txtCipher.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtCipher);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 49);
            this.panel1.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::client_server.Properties.Resources.new_msg;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // HillCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 349);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HillCipher";
            this.Text = "HillCipher";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblplaintext;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtplaintext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtKey4;
        private System.Windows.Forms.TextBox txtKey3;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Panel panel1;
    }
}