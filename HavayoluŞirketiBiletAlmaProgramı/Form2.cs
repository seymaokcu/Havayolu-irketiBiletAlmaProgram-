using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavayoluŞirketiBiletAlmaProgramı
{
    public partial class Form2 : Form
    {
        private decimal _temelBiletFiyati;
        private decimal _guncelFiyat;
        private int _yolcuSayisi;
        private DateTime _ucusTarihi;
        private string _nereden;
        private string _nereye;
        public Form2(decimal temelFiyat, int yolcuSayisi, DateTime ucusTarihi, string nereden, string nereye)
        {
            InitializeComponent();
            _temelBiletFiyati = temelFiyat;
            _guncelFiyat = temelFiyat;
            _yolcuSayisi = yolcuSayisi;
            _ucusTarihi = ucusTarihi;
            _nereden = nereden;
            _nereye = nereye;

            FillSeatComboBox();
        }

        private void cmbKoltuk1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtFiyat.Text = _guncelFiyat.ToString("C");
            if(_yolcuSayisi == 1)
            {
                cmbKoltuk1.Visible = false;
                cmbKoltuk2.Visible = false;
                chkKoltukSeçimi.Checked = false;
            }
            else
            {
                cmbKoltuk1.Visible = false;
                cmbKoltuk2.Visible = false;
                chkKoltukSeçimi.Checked = false;
            }
            CalculateTotalPrice();
        }
        private void FillSeatComboBox()
        {
            string[] koltuklar = { "1A", "1B", "2A", "2B", "3A", "3B", "4A", "4B" };
            cmbKoltuk1.Items.AddRange(koltuklar);
            cmbKoltuk2.Items.AddRange(koltuklar);
        }
        private void CalculateTotalPrice()
        {
            _guncelFiyat = _temelBiletFiyati;

            if (rdbBusiness.Checked)
                _guncelFiyat *= 2;
            if (chkKoltukSeçimi.Checked)
                _guncelFiyat += 50 * _yolcuSayisi;
            if (chkEkstraBagaj.Checked)
                _guncelFiyat += 50;
            if (chkYemekSeçimi.Checked)
                _guncelFiyat += 80;
            if(chkEsnekBilet.Checked)
                _guncelFiyat += 200;
            if(chkEsnekİptal.Checked)
                _guncelFiyat += 100;
            txtFiyat.Text = _guncelFiyat.ToString("C");

        }

        private void chkKoltukSeçimi_CheckedChanged(object sender, EventArgs e)
        {
            if(chkKoltukSeçimi.Checked)
            {
                if(_yolcuSayisi >= 1)
                    cmbKoltuk1.Visible = true;
                if(_yolcuSayisi==2)
                    cmbKoltuk2.Visible = true;

            }
            else
            {
                cmbKoltuk1.Visible = false;
                cmbKoltuk2.Visible = false;
            }
            CalculateTotalPrice();
        }

        private void chkEkstraBagaj_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void chkYemekSeçimi_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void rdbBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbBusiness.Checked)
                CalculateTotalPrice();


        }

        private void rdbEkonomi_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbEkonomi.Checked)
                CalculateTotalPrice();
        }

        private void chkEsnekBilet_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void chkEsnekİptal_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void btnBiletOnayla_Click(object sender, EventArgs e)
        {
            if(_yolcuSayisi >= 1 && cmbKoltuk1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen 1. koltuk için numara seçin.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(_yolcuSayisi == 2 && cmbKoltuk2.SelectedItem == null)
            {
                MessageBox.Show("Lütfen 2. koltuk için numara seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string yolculukLokasyonlari = $"{_nereden} -> {_nereye}";
            string yolculukTarihi = _ucusTarihi.ToShortDateString();
            string yolcuSayisi = _yolcuSayisi.ToString();

            List<string> ekstraHizmetler = new List<string>();
            if(chkEkstraBagaj.Checked)
                ekstraHizmetler.Add("Ekstra Bagaj");
            if (chkYemekSeçimi.Checked)
                ekstraHizmetler.Add("Yemek Seçimi");
            if(chkKoltukSeçimi.Checked)
                ekstraHizmetler.Add("Koltuk Seçimi");
            string alinanEkstraHizmetler = ekstraHizmetler.Count > 0 ? string.Join(", ", ekstraHizmetler) : "Yok";
            string yolcuSinifi = rdbBusiness.Checked ? "Business" : "Ekonomi";

            List<string> biletHaklari = new List<string>();
            if (chkEsnekBilet.Checked)
                biletHaklari.Add("Esnek Bilet Değişimi");
            if (chkEsnekİptal.Checked)
                biletHaklari.Add("Esnek Bilet İptali");
            string alinanBiletHaklari = biletHaklari.Count > 0 ? string.Join(", ", biletHaklari) : "Yok";
            
            List<string> koltukNumaralari = new List<string>();
            if (chkKoltukSeçimi.Checked)
            {
                if(cmbKoltuk1.SelectedItem!= null)
                    koltukNumaralari.Add(cmbKoltuk1.SelectedItem.ToString());
                if(_yolcuSayisi == 2 && cmbKoltuk2.SelectedItem != null)
                    koltukNumaralari.Add(cmbKoltuk2.SelectedItem.ToString());
            }
            string secilenKoltuklar = koltukNumaralari.Count > 0 ? string.Join(", ", koltukNumaralari) : "Yok";

            string mesaj = $"Yolculuk Lokasyonları: {yolculukLokasyonlari}\n" +
                           $"Yolculuk Tarihi: {yolculukTarihi}\n" +
                           $"Yolcu Sayısı: {yolcuSayisi}\n" +
                           $"Yolcu Sınıfı: {yolcuSinifi}\n" +
                           $"Alınan Ekstra Hizmetler: {alinanEkstraHizmetler}\n" +
                           $"Alınan Bilet Hakları: {alinanBiletHaklari}\n" +
                           $"Seçilen Koltuklar: {secilenKoltuklar}\n" +
                           $"Toplam Fiyat: {txtFiyat.Text}";

            MessageBox.Show(mesaj, "Bilet Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        

        
        
    }
}
