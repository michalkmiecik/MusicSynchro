using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MusicSynchro
{
    public partial class MainApp : Form
    {
        UdpClient udpClient;
        IPEndPoint remoteEndPoint;

        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            udpClient = new UdpClient();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                remoteEndPoint = new IPEndPoint(IPAddress.Parse(tbIPAddress.Text), int.Parse(tbPort.Text));
                udpClient.Connect(remoteEndPoint);
               
                string message = "Example message";
                Byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                udpClient.Send(sendBytes, sendBytes.Length);
                rtbLog.AppendText("\nSent message: \n[" + message + "]");

            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.ToString());
            }
        }

        private void btnStartWaiting_Click(object sender, EventArgs e)
        {
            try
            {
                remoteEndPoint = new IPEndPoint(IPAddress.Parse(tbIPAddress.Text), int.Parse(tbPort.Text));
                udpClient.Connect(remoteEndPoint);

                Byte[] receiveBytes = udpClient.Receive(ref remoteEndPoint);

                string returnData = Encoding.ASCII.GetString(receiveBytes);
                rtbLog.AppendText("\n" + returnData);
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.ToString());
            }
        }

        private void rbSender_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSender.Checked)
            {
                rtbLog.AppendText("\nSet as Sender.");
                btnStartWaiting.Enabled = false;
                btnSend.Enabled = true;
            }
        }

        private void rbReciever_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReciever.Checked)
            {
                rtbLog.AppendText("\nSet as Reciever.");
                btnStartWaiting.Enabled = true;
                btnSend.Enabled = false;
            }
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            udpClient.Close();
        }
    }
}