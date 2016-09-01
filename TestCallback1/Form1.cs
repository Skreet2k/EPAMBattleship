using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCallback1.TestService;

namespace TestCallback1
{
    public partial class Form1 : Form,IGameServiceCallback
    {
        private GameServiceClient _client;
        public Form1()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(yourId.Text, out id))
            {
                _client.JoinById(id);
            }
        }

        public void CallBack(string message)
        {
            messagebox.Text += "\n" + message;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _client = new GameServiceClient(new InstanceContext(this));
        }

        private void send_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(hisId.Text, out id))
            {
                _client.SendById(id, sendMessage.Text);
            }

        }
    }
}
