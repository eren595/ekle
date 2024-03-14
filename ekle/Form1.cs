using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Ogrenciler
        {
            public int Numara { get; set; }
            public string AdSoyad { get; set; }
        }
        List<int> numaralarList = new List<int>();
        List<string> adsoyadList = new List<string>();
        List<Ogrenciler> ogrencilerList = new List<Ogrenciler>();
        private void btnEkleSayi_Click(object sender, EventArgs e)
        {
            numaralarList.Add(int.Parse(txtNumara.Text));
            lbSayi.Items.Clear();
            foreach (var item in numaralarList)
            {
                lbSayi.Items.Add(item);
            }

        }

        private void btnEkleNesne_Click(object sender, EventArgs e)
        {
            {
                Ogrenciler ogrenci = new Ogrenciler();
                ogrenci.Numara = int.Parse(txtNumaraN.Text);
                ogrenci.AdSoyad = txtAdSoyadN.Text;
                ogrencilerList.Add(ogrenci);
                lbNesne.Items.Clear();
                foreach (var item in ogrencilerList)
                {
                    lbNesne.Items.Add(item.Numara + " " + item.AdSoyad);
                }
            }
        }

        private void btnEkleMetin_Click(object sender, EventArgs e)
        {
            adsoyadList.Add(txtNumara.Text);
            lbMetin.Items.Clear();
            foreach (var item in numaralarList)
            {
                lbMetin.Items.Add(item);
            }
        }
    }
}
