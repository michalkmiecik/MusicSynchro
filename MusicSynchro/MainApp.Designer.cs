namespace MusicSynchro
{
    partial class MainApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStartWaiting = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.rbReciever = new System.Windows.Forms.RadioButton();
            this.rbSender = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSend.Location = new System.Drawing.Point(10, 223);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(297, 38);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // btnStartWaiting
            // 
            this.btnStartWaiting.Enabled = false;
            this.btnStartWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartWaiting.Location = new System.Drawing.Point(10, 178);
            this.btnStartWaiting.Name = "btnStartWaiting";
            this.btnStartWaiting.Size = new System.Drawing.Size(297, 38);
            this.btnStartWaiting.TabIndex = 14;
            this.btnStartWaiting.Text = "Start waiting";
            this.btnStartWaiting.UseVisualStyleBackColor = true;
            this.btnStartWaiting.Click += new System.EventHandler(this.BtnStartWaiting_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.Info;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbLog.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.rtbLog.Location = new System.Drawing.Point(10, 271);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(297, 86);
            this.rtbLog.TabIndex = 18;
            this.rtbLog.Text = "Start logging...";
            // 
            // rbReciever
            // 
            this.rbReciever.AutoSize = true;
            this.rbReciever.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbReciever.Location = new System.Drawing.Point(33, 22);
            this.rbReciever.Name = "rbReciever";
            this.rbReciever.Size = new System.Drawing.Size(82, 21);
            this.rbReciever.TabIndex = 1;
            this.rbReciever.Text = "Reciever";
            this.rbReciever.UseVisualStyleBackColor = true;
            this.rbReciever.CheckedChanged += new System.EventHandler(this.rbReceiver_CheckedChanged);
            // 
            // rbSender
            // 
            this.rbSender.AutoSize = true;
            this.rbSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbSender.Location = new System.Drawing.Point(33, 49);
            this.rbSender.Name = "rbSender";
            this.rbSender.Size = new System.Drawing.Size(72, 21);
            this.rbSender.TabIndex = 0;
            this.rbSender.Text = "Sender";
            this.rbSender.UseVisualStyleBackColor = true;
            this.rbSender.CheckedChanged += new System.EventHandler(this.rbSender_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSender);
            this.groupBox1.Controls.Add(this.rbReciever);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 78);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select your role";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Enabled = false;
            this.lblIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIPAddress.Location = new System.Drawing.Point(13, 108);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(74, 16);
            this.lblIPAddress.TabIndex = 27;
            this.lblIPAddress.Text = "IP Address";
            this.lblIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Enabled = false;
            this.tbIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIPAddress.Location = new System.Drawing.Point(93, 105);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(214, 22);
            this.tbIPAddress.TabIndex = 28;
            this.tbIPAddress.Text = "192.168.1.";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Enabled = false;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPort.Location = new System.Drawing.Point(55, 142);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 16);
            this.lblPort.TabIndex = 30;
            this.lblPort.Text = "Port";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPort
            // 
            this.tbPort.Enabled = false;
            this.tbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPort.Location = new System.Drawing.Point(93, 139);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(214, 22);
            this.tbPort.TabIndex = 29;
            this.tbPort.Text = "55600";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 370);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStartWaiting);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainApp";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Synchro Player";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStartWaiting;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.RadioButton rbReciever;
        private System.Windows.Forms.RadioButton rbSender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbPort;
    }
}

