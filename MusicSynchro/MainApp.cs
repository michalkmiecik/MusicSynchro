using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MusicSynchro
{
    public partial class MainApp : Form
    {

        public MainApp()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(tbIPAddress.Text), int.Parse(tbPort.Text));
            using (var client = new UdpClient())
            {
                client.Connect(remoteEndPoint);
                string message = "Test Message";
                Byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                client.Send(sendBytes, sendBytes.Length);
                rtbLog.AppendText("\nSent message: \n[" + message + "]");
            }
        }

        private void BtnStartWaiting_Click(object sender, EventArgs e)
        {
            int listenPort = int.Parse(tbPort.Text);
            using (var client = new UdpClient(listenPort))
            {
                //IPEndPoint listenEndPoint = new IPEndPoint(IPAddress.Parse(tbIPAddress.Text), int.Parse(tbPort.Text));
                IPEndPoint listenEndPoint = new IPEndPoint(IPAddress.Any, listenPort);
                Byte[] receiveBytes = client.Receive(ref listenEndPoint);

                string message = Encoding.ASCII.GetString(receiveBytes);
                rtbLog.AppendText("\nReceived message: \n[" + message + "]");
                rtbLog.ScrollToCaret();
            }
        }

        private void rbSender_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSender.Checked)
            {
                rtbLog.AppendText("\nSet as Sender.");
                rtbLog.ScrollToCaret();
                btnStartWaiting.Enabled = false;
                btnSend.Enabled = true;
                panel.Enabled = true;
            }
        }

        private void rbReceiver_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReciever.Checked)
            {
                rtbLog.AppendText("\nSet as Receiver.");
                rtbLog.ScrollToCaret();
                btnStartWaiting.Enabled = true;
                btnSend.Enabled = false;
                panel.Enabled = false;

            }
        }

    }
}