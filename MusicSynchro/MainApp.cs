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
                IPAddress myIP = IPAddress.Parse(tbIPAddress.Text);
                IPEndPoint myEndPoint = new IPEndPoint(myIP, Int32.Parse(tbPort.Text));
                udpClient.Connect(myEndPoint);

                Byte[] sendBytes = Encoding.ASCII.GetBytes("Press space");

                udpClient.Send(sendBytes, sendBytes.Length);
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.ToString());
            }
        }

        private void btnStartWaiting_Click(object sender, EventArgs e)
        {
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

            string returnData = Encoding.ASCII.GetString(receiveBytes);
        }

        private void rbSender_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSender.Checked)
            {
                rtbLog.AppendText("\nSet as Sender.");
                panel2.Enabled = true;
                btnStartWaiting.Enabled = false;
            }
        }

        private void rbReciever_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReciever.Checked)
            {
                rtbLog.AppendText("\nSet as Reciever.");
                btnStartWaiting.Enabled = true;
                panel2.Enabled = false;
            }
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            udpClient.Close();
        }
    }
}