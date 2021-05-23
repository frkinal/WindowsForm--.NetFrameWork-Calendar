using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Calendar
{
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
        }
        /// <summary>
        /// timer kullanmak icin (Bildirim) iki degisken tanimlandi
        /// </summary>
        string zaman, tarih;
        /// <summary>
        /// Kayit edilen hatirlaticiyi bulmak icin tarih ve saat uzerine arama yapan buton olusturuldu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBul_Click(object sender, EventArgs e)
        {
            bool arananKayitKontroll = false;
            for (int i = 0; i < listViewNotlariniz.Items.Count; i++)
            {
                if (listViewNotlariniz.Items[i].SubItems[0].Text == dtpTarih.Text && listViewNotlariniz.Items[i].SubItems[1].Text == dtpSaat.Text)
                {
                    arananKayitKontroll = true;
                    dtpTarih.Text = listViewNotlariniz.Items[i].SubItems[0].Text;
                    dtpSaat.Text = listViewNotlariniz.Items[i].SubItems[1].Text;
                    txtKonu.Text = listViewNotlariniz.Items[i].SubItems[2].Text;
                    txtNot.Text = listViewNotlariniz.Items[i].SubItems[3].Text;

                    MessageBox.Show(dtpTarih.Text + " Tarihinde ve " + dtpSaat.Text + " Saatinde " + txtKonu.Text + " Konusu Altinda Kayit Ettiginiz Not: " + " \n\t\t" + txtNot.Text, "Hatirlatici", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Belirttiginiz tarih ve saatte not bulunmamaktadir. ", "Hatirlatici", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// timer kullanarak bildirim hatirlaticilar icin alarm olusturuldu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih = DateTime.Now.ToString();
            zaman = DateTime.Now.ToString();
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "Alarm.wav";

            for (int i = 0; i < listViewNotlariniz.Items.Count; i++)
            {
                if (listViewNotlariniz.Items[i].SubItems[0].Text == tarih && listViewNotlariniz.Items[i].SubItems[1].Text == zaman)
                {
                    timer1.Stop();
                    ses.Play();
                    MessageBox.Show(listViewNotlariniz.Items[i].SubItems[0].Text + " Tarihi ve " + listViewNotlariniz.Items[i].SubItems[1].Text + " saatinde "+ listViewNotlariniz.Items[i].SubItems[2]+" Konusu " +" icin ayarladiginiz hatirlatici calisti. Notunuz: " + "\n\t" + listViewNotlariniz.Items[i].SubItems[3].Text, "Hatirlatici", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    timer1.Start();
                }
            }
        }
        /// <summary>
        /// Hatilatici olusturmak icin belirlenen tarih ve saate, konu basligi altinda not eklmek icin buton tanimlandi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string date = "", hour = "", text = "", konu = "";
            date = dtpTarih.Text;
            hour = dtpSaat.Text;
            text = txtNot.Text;
            konu = txtKonu.Text;

            string[] bilgiler = { date, hour, konu, text };
            bool KayitKotnrol = false;
            for (int i = 0; i < listViewNotlariniz.Items.Count; i++)
            {
                if (listViewNotlariniz.Items[i].SubItems[0].Text == dtpTarih.Text && listViewNotlariniz.Items[i].SubItems[1].Text == dtpSaat.Text)
                {
                    KayitKotnrol = true;
                    MessageBox.Show(dtpTarih.Text + " Tarihinde ve " + dtpSaat.Text + " Saatinde Zaten Hatirlatici Kaydi Mevcuttur.");
                }
            }
            if (KayitKotnrol == false)
            {
                ListViewItem lst = new ListViewItem(bilgiler);
                if (txtNot.Text != "" && txtKonu.Text != "")
                {
                    listViewNotlariniz.Items.Add(lst);
                    DialogResult res = MessageBox.Show("Hatirlatici Ekleme Islemi Basarili, Yeni Hatirlatici Kaydi Eklemek Ister Misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        notifyIcon1 = new NotifyIcon();
                        notifyIcon1.BalloonTipText = "Toplam Hatirlatici Kayit Sayisi: " + listViewNotlariniz.Items.Count;
                        notifyIcon1.BalloonTipTitle = "Hatirlaticilar";
                        notifyIcon1.Visible = true;
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.ShowBalloonTip(2000);
                    }
                    else { }
                    ekranTemizle();
                }
                else
                {
                    MessageBox.Show("Not/Konu Kismi bos birakilamaz");
                }
            }


            tarih = dtpTarih.Text;
            zaman = dtpSaat.Text;
            timer1.Start();
        }
        /// <summary>
        /// Belirlenen hatirlaticinin silinmesi icin buton eklendi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilenSayisi = listViewNotlariniz.CheckedItems.Count;
            foreach (ListViewItem seciliKayitBilgisi in listViewNotlariniz.CheckedItems)
            {
                seciliKayitBilgisi.Remove();
            }
            MessageBox.Show(secilenSayisi.ToString() + " Adet Kayit Silindi.");
        }
        /// <summary>
        /// Kayit edilen hatirlaticiyi bulmak icin tarih uzerine arama yapan buton olusturuldu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBul2_Click(object sender, EventArgs e)
        {
            bool arananKayitKontroll = false;
            int sayac = 0;
            for (int i = 0; i < listViewNotlariniz.Items.Count; i++)
            {
                if (listViewNotlariniz.Items[i].SubItems[0].Text == dtpTarih.Text)
                {
                    arananKayitKontroll = true;
                    dtpTarih.Text = listViewNotlariniz.Items[i].SubItems[0].Text;
                    dtpSaat.Text = listViewNotlariniz.Items[i].SubItems[1].Text;
                    txtKonu.Text = listViewNotlariniz.Items[i].SubItems[2].Text;
                    txtNot.Text = listViewNotlariniz.Items[i].SubItems[3].Text;

                    sayac++;
                    MessageBox.Show(dtpTarih.Text + " Tarihinde ve " + dtpSaat.Text + " Saatinde " + txtKonu.Text + " Konusu Altinda Kayit Ettiginiz Not: " + " \n\t\t" + txtNot.Text, "Hatirlatici", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Belirttiginiz tarih ve saatte not bulunmamaktadir. ", "Hatirlatici", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            MessageBox.Show(dtpTarih.Text + " Tarhinde Kayitli " + sayac + " Tane Hatirlatici Bulunmaktadir.");
        }
        /// <summary>
        /// Formu kapatmak icin buton eklendi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            int secilenSayisi = listViewNotlariniz.CheckedItems.Count;
            if (secilenSayisi==1)
            {
                foreach (ListViewItem seciliKayitBilgisi in listViewNotlariniz.CheckedItems)
                {
                    MessageBox.Show(seciliKayitBilgisi.SubItems[0].Text + " Tarihinde ve " + seciliKayitBilgisi.SubItems[1].Text + " Saatinde " + seciliKayitBilgisi.SubItems[2].Text + " Konusu Altinda Kayit Ettiginiz Not : \n\t\t" + seciliKayitBilgisi.SubItems[3].Text, "Hatirlatici", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Birden Fazla Isaretli Not Acilamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Belirtilen hatirlaticinin bilgilerini degistirmek icin buton eklendi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int secilenSayisi = listViewNotlariniz.CheckedItems.Count;
            if (secilenSayisi == 1)
            {
                foreach (ListViewItem seciliKayitBilgisi in listViewNotlariniz.CheckedItems)
                {
                    seciliKayitBilgisi.SubItems[0].Text = dtpTarih.Text;
                    seciliKayitBilgisi.SubItems[1].Text = dtpSaat.Text;
                    seciliKayitBilgisi.SubItems[2].Text = txtKonu.Text;
                    seciliKayitBilgisi.SubItems[3].Text = txtNot.Text;
                }
            }
            else if (secilenSayisi > 1)
            {
                MessageBox.Show("Birden Fazla Not Isaretlenemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Degistirme Islemini Ypamka Icin Bir Tane Not Isaretlemelisiniz. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Hatırlatıcının calısabılmesı ıcın tımer start edıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        /// <summary>
        /// Kullanici yeni not eklemek istedigi zaman textBox larin temizlenmesi icin metot tanimlandi
        /// </summary>
        private void ekranTemizle() 
        {
            txtKonu.Text = string.Empty;
            txtNot.Text = string.Empty;
        }

    }
}