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
            this.rbSender = new System.Windows.Forms.RadioButton();
            this.rbReciever = new System.Windows.Forms.RadioButton();
            this.btnStartWaiting = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
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
            this.rbReciever.CheckedChanged += new System.EventHandler(this.rbReciever_CheckedChanged);
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
            this.btnStartWaiting.Click += new System.EventHandler(this.btnStartWaiting_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "IP Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIPAddress.Location = new System.Drawing.Point(93, 104);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(214, 22);
            this.tbIPAddress.TabIndex = 20;
            this.tbIPAddress.Text = "192.168.1.122";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(55, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPort.Location = new System.Drawing.Point(93, 138);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(214, 22);
            this.tbPort.TabIndex = 21;
            this.tbPort.Text = "10101";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.label2);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApp_FormClosed);
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton rbReciever;
        private System.Windows.Forms.RadioButton rbSender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartWaiting;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
    }
}

