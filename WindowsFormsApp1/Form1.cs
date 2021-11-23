using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        HubConnection connection = new HubConnectionBuilder()
               .WithUrl("https://localhost:5001/Watch")
               .Build();
        public Form1()
        {
            InitializeComponent();
            connection.StartAsync();
            connection.InvokeCoreAsync("Get", args: new[] { "Dinesh" });
            connection.On("Get", (string username) =>
            {
                lblResoponse.Text = username;
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            connection.StartAsync();
            connection.InvokeCoreAsync("Start", args: new[] { "Dinesh" });
            connection.On("Start", (string username) =>
            {
                lblResoponse.Text = username;
            });

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            connection.StartAsync();
            connection.InvokeCoreAsync("Stop", args: new[] { "Dinesh" });
            connection.On("Stop", (string username) =>
            {
                lblResoponse.Text = username;
            });

        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            connection.StartAsync();
            connection.InvokeCoreAsync("Get", args: new[] { "Dinesh" });
            connection.On("Get", (string username) =>
            {
                lblResoponse.Text = username;
            });
        }
    }
}
