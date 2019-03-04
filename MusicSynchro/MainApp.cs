using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MusicSynchro {
    public partial class MainApp : Form {
        UdpClient udpClient;

        public MainApp() {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e) {
            udpClient = new UdpClient();
        }

        private void btnSend_Click(object sender, EventArgs e) {
            try {
                IPAddress myIP = IPAddress.Parse(tbIPAddress.Text);
                IPEndPoint myEndPoint = new IPEndPoint(myIP, Int32.Parse(tbPort.Text));
                udpClient.Connect(myEndPoint);

                Byte[] sendBytes = Encoding.ASCII.GetBytes("Press space");

                udpClient.Send(sendBytes, sendBytes.Length);

                //IPEndPoint object will allow us to read datagrams sent from any source.
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                // Blocks until a message returns on this socket from a remote host.

                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);


                udpClient.Close();
            }
            catch (Exception exc) {
                Console.WriteLine(exc.ToString());
            }
        }

        private void btnStartWaiting_Click(object sender, EventArgs e) {

        }

        private void SenderOrReciever(object sender, EventArgs e) {
            if (rbReciever.Checked) {
                btnStartWaiting.Enabled = true;
                panel2.Enabled = false;
            }
            else {
                panel2.Enabled = true;
                btnStartWaiting.Enabled = false;
            }
        }

    }
}