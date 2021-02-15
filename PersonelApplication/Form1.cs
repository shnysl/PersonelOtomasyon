using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Personel> personeller = new List<Personel>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Departmanlar[] departmanalar = (Departmanlar[])Enum.GetValues(typeof(Departmanlar));
            foreach (Departmanlar item in departmanalar)
            {
                cbUnvan.Items.Add(item);
            }

            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg; *.png";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pbResim.ImageLocation = DosyaYolu;
        }

        public void ListeyiTemizle()
        {
            mtbTCKNo.Text = "";
            tbAd.Text = "";
            tbSoyad.Text = "";
            dtpDogumTarihi.Value = DateTime.Now;
            mtbTelefon.Text = "";
            tbEMail.Text = "";
            dtpİseGirisTarihi.Value = DateTime.Now;
            tbAdres.Text = "";
            cbUnvan.SelectedIndex = -1;
            pbResim.ImageLocation = "";
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        public void ListeyiGüncelle()
        {
            listView1.Items.Clear();
            foreach (Personel item in personeller)
            {
                string[] row = { item.TCKNo.ToString(), item.Ad.ToString(), item.Soyad.ToString(), item.IseGirisTarihi.ToShortDateString(), item.Telefon.ToString(), item.EMail.ToString() };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
            }
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool aramasonucu = false;
            int a = 0;
            foreach (Personel item in personeller)
            {
                if (item.TCKNo == mtbTCKNo.Text)
                {
                    aramasonucu = true;
                    a = personeller.IndexOf(item);
                }
            }
            if (aramasonucu == false)
            {
                if (cbUnvan.SelectedIndex > -1)
                {
                    try
                    {
                        Personel personel = new Personel();
                        personel.TCKNo = mtbTCKNo.Text;
                        personel.Ad = tbAd.Text;
                        personel.Soyad = tbSoyad.Text;
                        personel.DogumTarihi = dtpDogumTarihi.Value;
                        personel.Telefon = mtbTelefon.Text;
                        personel.EMail = tbEMail.Text;
                        personel.IseGirisTarihi = dtpİseGirisTarihi.Value;
                        personel.Adres = tbAdres.Text;
                        personel.departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), cbUnvan.Text);
                        personel.ResimDosyaYolu = pbResim.ImageLocation;
                        personeller.Add(personel);
                        ListeyiGüncelle();
                        ListeyiTemizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Ünvan Seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numrası Daha Önce Kaydedilmiş.");
                ListeyiTemizle();
                mtbTCKNo.Text = personeller[a].TCKNo;
                tbAd.Text = personeller[a].Ad;
                tbSoyad.Text = personeller[a].Soyad;
                dtpDogumTarihi.Value = personeller[a].DogumTarihi;
                mtbTelefon.Text = personeller[a].Telefon;
                tbEMail.Text = personeller[a].EMail;
                dtpİseGirisTarihi.Value = personeller[a].IseGirisTarihi;
                tbAdres.Text = personeller[a].Adres;
                cbUnvan.SelectedItem = personeller[a].departman;
                pbResim.ImageLocation = personeller[a].ResimDosyaYolu;

            }
            
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbTCKNo.Text != "")
                {
                    foreach (Personel item in personeller)
                    {
                        if (item.TCKNo.ToString() == listView1.FocusedItem.SubItems[0].Text)
                        {
                            item.TCKNo = mtbTCKNo.Text;
                            item.Ad = tbAd.Text;
                            item.Soyad = tbSoyad.Text;
                            item.DogumTarihi = dtpDogumTarihi.Value;
                            item.Telefon = mtbTelefon.Text;
                            item.EMail = tbEMail.Text;
                            item.IseGirisTarihi = dtpİseGirisTarihi.Value;
                            item.Adres = tbAdres.Text;
                            item.departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), cbUnvan.Text);
                            item.ResimDosyaYolu = pbResim.ImageLocation;
                            ListeyiGüncelle();
                            ListeyiTemizle();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (mtbTCKNo.Text != "")
            {
                foreach (Personel item in personeller)
                {
                    if (mtbTCKNo.Text == item.TCKNo.ToString())
                    {
                        a = personeller.IndexOf(item);
                    }

                }
            }
            personeller.RemoveAt(a);
            ListeyiGüncelle();
            ListeyiTemizle();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = listView1.HitTest(e.Location);
            if (hit.Item != null)
            {
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
                foreach (Personel item in personeller)
                {
                    if(item.TCKNo.ToString() == hit.Item.Text.ToString())
                    {
                        mtbTCKNo.Text = item.TCKNo.ToString();
                        tbAd.Text = item.Ad.ToString();
                        tbSoyad.Text = item.Soyad.ToString();
                        dtpDogumTarihi.Value = item.DogumTarihi;
                        mtbTelefon.Text = item.Telefon.ToString();
                        tbEMail.Text = item.EMail.ToString();
                        dtpİseGirisTarihi.Value = item.IseGirisTarihi;
                        tbAdres.Text = item.Adres.ToString();
                        cbUnvan.SelectedItem = item.departman;
                        pbResim.ImageLocation = item.ResimDosyaYolu;
                    }
                }
            }
        }

        private void tbAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void tbSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void tbEMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
