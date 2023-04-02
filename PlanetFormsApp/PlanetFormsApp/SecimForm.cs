using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetFormsApp
{
    public partial class SecimForm : Form
    {
        public SecimForm()
        {
            InitializeComponent();
        }

        private void btnbagis_Click(object sender, EventArgs e)
        {
            BagisForm bagis = new BagisForm();
            bagis.usId = usId;
            bagis.Show();
        }
        public int usId;
        private void btnfidan_Click(object sender, EventArgs e)
        {
            FidanForm fidanForm = new FidanForm();
            fidanForm.Show();
        }
    }
}
