using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavayoluŞirketiBiletAlmaProgramı
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, decimal>> ucusFiyatlari = new Dictionary<string, Dictionary<string, decimal>>();
        public Form1()
        {
            InitializeComponent();

            nudYolcu.Minimum = 0;
            nudYolcu.Maximum = 10;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFlightData("Uçuş Programı.txt");
        }
        private void LoadFlightData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Uçuş verileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string nereden = parts[0].Trim();
                        string nereye = parts[1].Trim();
                        decimal fiyat = Convert.ToDecimal(parts[2].Trim());
                        if (!cmbNereden.Items.Contains(nereden))
                        {
                            cmbNereden.Items.Add(nereden);
                        }
                        if (!cmbNereye.Items.Contains(nereye))
                        {
                            cmbNereye.Items.Add(nereye);
                        }
                        if (!ucusFiyatlari.ContainsKey(nereden))
                        {
                            ucusFiyatlari.Add(nereden, new Dictionary<string, decimal>());
                        }

                        ucusFiyatlari[nereden][nereye] = fiyat;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Uçuş verileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if(nudYolcu.Value == 0)
            {
                MessageBox.Show("Lütfen yolcu saysısı seçin","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cmbNereden.SelectedItem == null || cmbNereye.SelectedItem == null)
            {
                MessageBox.Show("Lütfen nereden ve nereye seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            } 
            string nereden = cmbNereden.SelectedItem.ToString();
            string nereye = cmbNereye.SelectedItem.ToString();
            int yolcuSayisi = (int)nudYolcu.Value;
            DateTime ucusTarihi = mcTarih.SelectionStart;

            decimal temelBiletFiyati = 0;

            if(ucusFiyatlari.ContainsKey(nereden) && ucusFiyatlari[nereden].ContainsKey(nereye))
            {
                temelBiletFiyati = ucusFiyatlari[nereden][nereye];
            }
            else
            {
                MessageBox.Show("Seçilen güzergah için bilet fiyatı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form2 form2 = new Form2(temelBiletFiyati, yolcuSayisi, ucusTarihi, nereden, nereye);
            form2.ShowDialog();
        }
    }
}
