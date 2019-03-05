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

                string returnData = Encoding.ASCII.GetString(receiveBytes);
                rtbLog.AppendText("\n" + returnData);
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

    }
}