using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkToolLibrary;

namespace NetworkToolUI
{
    public partial class Dashboard : Form
    {
        List<Vlan> vlans = new List<Vlan>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void createNetworkBtn_Click(object sender, EventArgs e)
        {
            if (networkField.Text == "" || networkField.Text == null)
            {
                Console.WriteLine("Please Enter in a value");
                statusLabel.Text = "Error";
                return;
            }
            Console.WriteLine(networkField.Text);
            networkField.Text = "";
            statusLabel.Text = "Ready";

            return;
        }
   

        private void addVlanBtn_Click(object sender, EventArgs e)
        {
            if (Vlan.addToVlan(vlanField.Text,vlans)) {
                statusLabel.Text = "Vlan added";
                ResetStatusLabel();

                // Adds new Vlan to list
                UpdateVlansList();
                // Resets vlanfield
                vlanField.Text = "";
                return;
            };
            statusLabel.Text = "Vlan not added";
            ResetStatusLabel();
            vlanField.Text = "";
            return;
        }
    private async void ResetStatusLabel()
    {
            int delay = 1000; // 1 second
            await Task.Delay(delay);
            statusLabel.Text = "Ready";
            return;
    }
   
    private void UpdateVlansList()
        {
            int index = vlans.Count - 1;
            VlansList.AppendText(vlans[index].Id.ToString());
            VlansList.AppendText(Environment.NewLine);
        }


    }

  
}
