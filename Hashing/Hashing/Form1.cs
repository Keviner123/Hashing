using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace Hashing
{


    
    public partial class Form1 : Form
    {

        ConversionHandlers myConverter = new ConversionHandlers();

        public Form1()
        {
            InitializeComponent();
            algorithmSelectionBox.Items.Add("SHA1");
            algorithmSelectionBox.Items.Add("MD5");
            algorithmSelectionBox.Items.Add("RIPEMD");
            algorithmSelectionBox.Items.Add("SHA256");
            algorithmSelectionBox.Items.Add("SHA384");
            algorithmSelectionBox.Items.Add("SHA512");
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {

            MACHandler mh = new MACHandler(algorithmSelectionBox.Text);
            byte[] mac = mh.ComputeMAC(myConverter.StringToByteArray(PlainTextASCIIButton.Text), myConverter.StringToByteArray(KeyASCIIButton.Text));

            MACASCIIButton.Text = myConverter.ByteArrayToString(mac);
            MACHEXButton.Text = myConverter.ByteArrayToHexString(mac);

        }

        private void VerifyMacButtoon_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(algorithmSelectionBox.Text);
            if (mh.CheckAuthenticity(myConverter.StringToByteArray(PlainTextASCIIButton.Text), myConverter.HexStringToByteArray(MACHEXButton.Text), myConverter.StringToByteArray(KeyASCIIButton.Text)) == true)
            {
                System.Windows.Forms.MessageBox.Show("MAC er validt");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("MAC er ikke validt");
            }
        }
    }
}
