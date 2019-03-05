using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace MusicSynchro
{
    public partial class MainApp : Form
    {

        public MainApp()
        {
            InitializeComponent();
        }

        private void AddToLog(string message)
        {
            rtbLog.AppendText("\n" + message);
            rtbLog.ScrollToCaret();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(tbIPAddress.Text), int.Parse(tbPort.Text));
            using (var client = new UdpClient())
            {
                client.Connect(remoteEndPoint);
                Byte[] sendBytes = { 1 };
                Thread.Sleep(3000);
                client.Send(sendBytes, sendBytes.Length);
                AddToLog("Sent [SPACE].");
            }
        }

        private void BtnStartWaiting_Click(object sender, EventArgs e)
        {
            int listenPort = int.Parse(tbPort.Text);
            using (var client = new UdpClient(listenPort))
            {
                IPEndPoint listenEndPoint = new IPEndPoint(IPAddress.Any, listenPort);
                Byte[] receiveBytes = client.Receive(ref listenEndPoint);

                SendKeys.Send(" "); //presses SPACE bar
                AddToLog("Received [SPACE] press.");

            }
        }

        private void rbSender_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSender.Checked)
            {
                AddToLog("Set as Sender.");
                btnStartWaiting.Enabled = false;
                btnSend.Enabled = true;
                lblIPAddress.Enabled = tbIPAddress.Enabled = true;
                lblPort.Enabled = tbPort.Enabled = true;
            }
        }

        private void rbReceiver_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReciever.Checked)
            {
                AddToLog("Set as Receiver.");
                btnStartWaiting.Enabled = true;
                btnSend.Enabled = false;
                lblIPAddress.Enabled = tbIPAddress.Enabled = false;
                lblPort.Enabled = tbPort.Enabled = true;
            }
        }

    }
}