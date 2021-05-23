using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Calendar
{
    public partial class tarihteBugun : Form
    {
        public tarihteBugun()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form acildiginde belirlenen api uzerinden veri akisini saglamak icin ,web api den veriler cekiliyor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tarihteBugun_Load(object sender, EventArgs e)
        {
            string adres = "https://api.ubilisim.com/tarihtebugun/";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string bilgilerial = donenBilgiler.ReadToEnd();

            Root tarih_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(bilgilerial);

            foreach (var bilgi in tarih_.tarihtebugun)
            {
                ListViewItem okunan = new ListViewItem(
               new string[]{
               bilgi.Gun,bilgi.Ay,bilgi.Yil,bilgi.Durum,bilgi.Olay});
                listView1.Items.Add(okunan);
            }
        }
        /// <summary>
        /// Tarihte bugun yasanan olaylardan belirlenen olayin ayrintili gormek icin buton eklendi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGoster_Click(object sender, EventArgs e)
        {
            int secilenSayisi = listView1.CheckedItems.Count;
            if (secilenSayisi == 1)
            {
                foreach (ListViewItem seciliKayitBilgisi in listView1.CheckedItems)
                {
                    MessageBox.Show(seciliKayitBilgisi.SubItems[0].Text + "/" + seciliKayitBilgisi.SubItems[1].Text + "/" + seciliKayitBilgisi.SubItems[2].Text + "\nDurum :" + seciliKayitBilgisi.SubItems[3].Text+"\n Olay: "+seciliKayitBilgisi.SubItems[4].Text, "Hatirlatici", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Birden Fazla Isaretli Not Acilamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Formu kapatmak icin buton eklendi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    /// <summary>
    /// Web api den belirlenen verileri almak icin JSON kodlarini C# diline convert ederek gereken fieldlar tanimlandi
    /// </summary>
    public class Tarihtebugun
    {
        public string Gun { get; set; }
        public string Ay { get; set; }
        public string Yil { get; set; }
        public string Durum { get; set; }
        public string Olay { get; set; }
    }
    /// <summary>
    /// Web api den belirlenen verileri almak icin JSON kodlarini C# diline convert ederek gereken fieldlar tanimlandi
    /// </summary>
    public class Root
    {
        public bool success { get; set; }
        public string status { get; set; }
        public string pagecreatedate { get; set; }
        public List<Tarihtebugun> tarihtebugun { get; set; }
    }

}