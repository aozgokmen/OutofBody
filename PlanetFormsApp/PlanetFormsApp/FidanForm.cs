using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetFormsApp
{
    public partial class FidanForm : Form
    {
        Plant_DBEntities dBEntities = new Plant_DBEntities();
        public FidanForm()
        {
            InitializeComponent();
        }

        private void FidanForm_Load(object sender, EventArgs e)
        {
            //var bagislananIslerTumListe = dBEntities.sales.ToList();
            //dataGridView1.DataSource = bagislananIslerTumListe;

            griddoldur();
            isiAl.Enabled = false;

        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void griddoldur()
        {
            //baglantı kur
            con = new SqlConnection("data source=DESKTOP-DBL30NK\\SQLEXPRESS;initial catalog=Plant_System;integrated security=True;MultipleActiveResultSets=True");
            da = new SqlDataAdapter("select sl.id,pl.name, pl.price,cs.first_name + ' ' + cs.last_name custumers, lk.country, fr.first_name + ' ' + fr.last_name farmes from sales sl\r\nleft join plants pl on sl.plant_id = pl.id\r\nleft join customers cs on sl.customer_id = cs.id\r\nleft join locations lk on sl.location_id =lk.id\r\nleft join farmers fr on sl.farmer_id = fr.id", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "plants");
            dataGridView1.DataSource = ds.Tables["plants"];
            con.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //data grid kısmında tıkladığımız satırı alıyoruz.
            int satirId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
            

            var isBuyCheck = dBEntities.sales.Where(s => s.id == satirId);

            foreach (var item in isBuyCheck)
            {
                if (item.isBuy != null)
                {
                    if ((bool)item.isBuy)
                    {
                        txtis.Text = "";
                        txtis.Text = "Bu İş Alınmış";
                        isiAl.Enabled = false; //işi alma butonunu pasif yapıyoruz.
                    }
                    else
                    {
                        txtis.Text = "";
                        txtis.Text = "Bu İş Alınabilir";
                        isiAl.Enabled = true; // iş alma butonu aktif.
                    }
                }
            }




        }

        private void isiAl_Click(object sender, EventArgs e)
        {
            //iş alma butonun çalıştığı kısım.
            int id = Convert.ToInt32(txtid.Text);
            var isiAlItem = dBEntities.sales.Where(x => x.id == id).ToList(); // db den tıklanılan kayıt getiriliyor
            foreach (var item in isiAlItem)
            {
                item.isBuy = true;
            }
            dBEntities.SaveChanges();
            MessageBox.Show("İş başarı ile alınmıştır.");
        }


    }
}
