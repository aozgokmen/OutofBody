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
    public partial class BagisForm : Form
    {
        Plant_DBEntities dBEntities = new Plant_DBEntities();
        
        public BagisForm()
        {
            InitializeComponent();
        }
        public int usId;
        private void BagisForm_Load(object sender, EventArgs e)
        {
            var lokasyonlar = dBEntities.locations.ToList();
            cmbLokasyon.DataSource = lokasyonlar;
            cmbLokasyon.DisplayMember = "country";
            cmbLokasyon.ValueMember = "id";

            var kategoriler = dBEntities.categories.ToList();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "category_name";
            cmbKategori.ValueMember = "id";

            var bitkiler = dBEntities.plants.ToList();
            cmbBitki.DataSource = bitkiler;
            cmbBitki.DisplayMember = "name";
            cmbBitki.ValueMember = "id";

            var ciftciler = dBEntities.farmers.ToList();
            cmbciftci.DataSource = ciftciler;
            cmbciftci.DisplayMember = "first_name";
            cmbciftci.ValueMember = "id";

        }

        private void cmbBagis_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbBitki_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secimDegeri = cmbBitki.SelectedIndex+1;
            var bagisDegeri = dBEntities.plants.Where(x => x.id == secimDegeri).ToList();
            foreach (var item in bagisDegeri)
            {
                txtbagis.Text = "";
                txtbagis.Text = item.price.ToString();
            }
            
            
        }

        private void btnBagisOnayla_Click(object sender, EventArgs e)
        {
            sales sl = new sales();
            sl.sales_price = Convert.ToInt32(txtbagis.Text);
            sl.plant_id = (int)cmbBitki.SelectedValue;
            sl.customer_id= usId;
            sl.farmer_id= (int)cmbciftci.SelectedValue;
            sl.location_id = (int)cmbLokasyon.SelectedValue;
            sl.isBuy = false;

            dBEntities.sales.Add(sl);
            dBEntities.SaveChanges();
            MessageBox.Show("Bağış talebiniz alınmıştır. Teşekkürler...");

        }
    }
}
