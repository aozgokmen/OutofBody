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
    public partial class Form1 : Form
    {

        Plant_DBEntities dBEntities = new Plant_DBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //veritabanında kullanıcı kontrollerini yaptığı sorgular
            var kullaniciBilgisi = dBEntities.customers.Where(x => x.email == txtusername.Text && x.c_password == txtpassword.Text).ToList();

            if(kullaniciBilgisi.Count>0)
            {
                //kullanıcı var ise form değiştirip ana menü nün olduğu ekrana geçiş işlemi yapıyor.
                MessageBox.Show("Fidan Ekleme ve Bağış Yapma Portalına Hoşgeldiniz");
                SecimForm secimForm = new SecimForm();
                secimForm.Show();
                foreach (var item in kullaniciBilgisi)
                {
                    secimForm.usId = item.id;
                }
                
                this.Hide();
            }
            else
                MessageBox.Show("Yanlış bilgiler girdiniz, lütfen tekrar deneyiniz."); //bilgiler dbdeki bilgiler ile uyuşmaz ise ekranda uyarı veriyor
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
