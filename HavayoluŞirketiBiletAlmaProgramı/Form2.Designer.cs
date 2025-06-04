namespace HavayoluŞirketiBiletAlmaProgramı
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEkstraHizmetler = new System.Windows.Forms.GroupBox();
            this.chkYemekSeçimi = new System.Windows.Forms.CheckBox();
            this.chkEkstraBagaj = new System.Windows.Forms.CheckBox();
            this.chkKoltukSeçimi = new System.Windows.Forms.CheckBox();
            this.grpYolcuSınıfı = new System.Windows.Forms.GroupBox();
            this.rdbEkonomi = new System.Windows.Forms.RadioButton();
            this.rdbBusiness = new System.Windows.Forms.RadioButton();
            this.grpBiletDeğişimİade = new System.Windows.Forms.GroupBox();
            this.chkEsnekBilet = new System.Windows.Forms.CheckBox();
            this.chkEsnekİptal = new System.Windows.Forms.CheckBox();
            this.cmbKoltuk1 = new System.Windows.Forms.ComboBox();
            this.cmbKoltuk2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBiletOnayla = new System.Windows.Forms.Button();
            this.grpEkstraHizmetler.SuspendLayout();
            this.grpYolcuSınıfı.SuspendLayout();
            this.grpBiletDeğişimİade.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(367, 154);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.ReadOnly = true;
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiyat";
            // 
            // grpEkstraHizmetler
            // 
            this.grpEkstraHizmetler.Controls.Add(this.chkYemekSeçimi);
            this.grpEkstraHizmetler.Controls.Add(this.chkEkstraBagaj);
            this.grpEkstraHizmetler.Controls.Add(this.chkKoltukSeçimi);
            this.grpEkstraHizmetler.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraHizmetler.Name = "grpEkstraHizmetler";
            this.grpEkstraHizmetler.Size = new System.Drawing.Size(200, 129);
            this.grpEkstraHizmetler.TabIndex = 2;
            this.grpEkstraHizmetler.TabStop = false;
            this.grpEkstraHizmetler.Text = "Ekstra Hizmetler";
            // 
            // chkYemekSeçimi
            // 
            this.chkYemekSeçimi.AutoSize = true;
            this.chkYemekSeçimi.Location = new System.Drawing.Point(11, 103);
            this.chkYemekSeçimi.Name = "chkYemekSeçimi";
            this.chkYemekSeçimi.Size = new System.Drawing.Size(116, 20);
            this.chkYemekSeçimi.TabIndex = 2;
            this.chkYemekSeçimi.Text = "Yemek Seçimi";
            this.chkYemekSeçimi.UseVisualStyleBackColor = true;
            this.chkYemekSeçimi.CheckedChanged += new System.EventHandler(this.chkYemekSeçimi_CheckedChanged);
            // 
            // chkEkstraBagaj
            // 
            this.chkEkstraBagaj.AutoSize = true;
            this.chkEkstraBagaj.Location = new System.Drawing.Point(11, 65);
            this.chkEkstraBagaj.Name = "chkEkstraBagaj";
            this.chkEkstraBagaj.Size = new System.Drawing.Size(106, 20);
            this.chkEkstraBagaj.TabIndex = 1;
            this.chkEkstraBagaj.Text = "Ekstra Bagaj";
            this.chkEkstraBagaj.UseVisualStyleBackColor = true;
            this.chkEkstraBagaj.CheckedChanged += new System.EventHandler(this.chkEkstraBagaj_CheckedChanged);
            // 
            // chkKoltukSeçimi
            // 
            this.chkKoltukSeçimi.AutoSize = true;
            this.chkKoltukSeçimi.Location = new System.Drawing.Point(11, 30);
            this.chkKoltukSeçimi.Name = "chkKoltukSeçimi";
            this.chkKoltukSeçimi.Size = new System.Drawing.Size(109, 20);
            this.chkKoltukSeçimi.TabIndex = 0;
            this.chkKoltukSeçimi.Text = "Koltuk Seçimi";
            this.chkKoltukSeçimi.UseVisualStyleBackColor = true;
            this.chkKoltukSeçimi.CheckedChanged += new System.EventHandler(this.chkKoltukSeçimi_CheckedChanged);
            // 
            // grpYolcuSınıfı
            // 
            this.grpYolcuSınıfı.Controls.Add(this.rdbEkonomi);
            this.grpYolcuSınıfı.Controls.Add(this.rdbBusiness);
            this.grpYolcuSınıfı.Location = new System.Drawing.Point(12, 160);
            this.grpYolcuSınıfı.Name = "grpYolcuSınıfı";
            this.grpYolcuSınıfı.Size = new System.Drawing.Size(200, 100);
            this.grpYolcuSınıfı.TabIndex = 0;
            this.grpYolcuSınıfı.TabStop = false;
            this.grpYolcuSınıfı.Text = "Yolcu Sınıfı";
            // 
            // rdbEkonomi
            // 
            this.rdbEkonomi.AutoSize = true;
            this.rdbEkonomi.Location = new System.Drawing.Point(11, 58);
            this.rdbEkonomi.Name = "rdbEkonomi";
            this.rdbEkonomi.Size = new System.Drawing.Size(81, 20);
            this.rdbEkonomi.TabIndex = 1;
            this.rdbEkonomi.TabStop = true;
            this.rdbEkonomi.Text = "Ekonomi";
            this.rdbEkonomi.UseVisualStyleBackColor = true;
            this.rdbEkonomi.CheckedChanged += new System.EventHandler(this.rdbEkonomi_CheckedChanged);
            // 
            // rdbBusiness
            // 
            this.rdbBusiness.AutoSize = true;
            this.rdbBusiness.Location = new System.Drawing.Point(11, 32);
            this.rdbBusiness.Name = "rdbBusiness";
            this.rdbBusiness.Size = new System.Drawing.Size(83, 20);
            this.rdbBusiness.TabIndex = 0;
            this.rdbBusiness.TabStop = true;
            this.rdbBusiness.Text = "Business";
            this.rdbBusiness.UseVisualStyleBackColor = true;
            this.rdbBusiness.CheckedChanged += new System.EventHandler(this.rdbBusiness_CheckedChanged);
            // 
            // grpBiletDeğişimİade
            // 
            this.grpBiletDeğişimİade.Controls.Add(this.chkEsnekBilet);
            this.grpBiletDeğişimİade.Controls.Add(this.chkEsnekİptal);
            this.grpBiletDeğişimİade.Location = new System.Drawing.Point(12, 292);
            this.grpBiletDeğişimİade.Name = "grpBiletDeğişimİade";
            this.grpBiletDeğişimİade.Size = new System.Drawing.Size(200, 118);
            this.grpBiletDeğişimİade.TabIndex = 0;
            this.grpBiletDeğişimİade.TabStop = false;
            this.grpBiletDeğişimİade.Text = "Bilet Değişimi ve İade Hakkı";
            // 
            // chkEsnekBilet
            // 
            this.chkEsnekBilet.AutoSize = true;
            this.chkEsnekBilet.Location = new System.Drawing.Point(11, 39);
            this.chkEsnekBilet.Name = "chkEsnekBilet";
            this.chkEsnekBilet.Size = new System.Drawing.Size(152, 20);
            this.chkEsnekBilet.TabIndex = 3;
            this.chkEsnekBilet.Text = "Esnek Bilet Değişimi";
            this.chkEsnekBilet.UseVisualStyleBackColor = true;
            this.chkEsnekBilet.CheckedChanged += new System.EventHandler(this.chkEsnekBilet_CheckedChanged);
            // 
            // chkEsnekİptal
            // 
            this.chkEsnekİptal.AutoSize = true;
            this.chkEsnekİptal.Location = new System.Drawing.Point(11, 76);
            this.chkEsnekİptal.Name = "chkEsnekİptal";
            this.chkEsnekİptal.Size = new System.Drawing.Size(127, 20);
            this.chkEsnekİptal.TabIndex = 4;
            this.chkEsnekİptal.Text = "Esnek Bilet İptali";
            this.chkEsnekİptal.UseVisualStyleBackColor = true;
            this.chkEsnekİptal.CheckedChanged += new System.EventHandler(this.chkEsnekİptal_CheckedChanged);
            // 
            // cmbKoltuk1
            // 
            this.cmbKoltuk1.FormattingEnabled = true;
            this.cmbKoltuk1.Location = new System.Drawing.Point(244, 73);
            this.cmbKoltuk1.Name = "cmbKoltuk1";
            this.cmbKoltuk1.Size = new System.Drawing.Size(121, 24);
            this.cmbKoltuk1.TabIndex = 3;
            this.cmbKoltuk1.Visible = false;
            this.cmbKoltuk1.SelectedIndexChanged += new System.EventHandler(this.cmbKoltuk1_SelectedIndexChanged);
            // 
            // cmbKoltuk2
            // 
            this.cmbKoltuk2.FormattingEnabled = true;
            this.cmbKoltuk2.Location = new System.Drawing.Point(456, 73);
            this.cmbKoltuk2.Name = "cmbKoltuk2";
            this.cmbKoltuk2.Size = new System.Drawing.Size(121, 24);
            this.cmbKoltuk2.TabIndex = 4;
            this.cmbKoltuk2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "1. Koltuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "2. Koltuk";
            // 
            // btnBiletOnayla
            // 
            this.btnBiletOnayla.Location = new System.Drawing.Point(244, 237);
            this.btnBiletOnayla.Name = "btnBiletOnayla";
            this.btnBiletOnayla.Size = new System.Drawing.Size(333, 92);
            this.btnBiletOnayla.TabIndex = 7;
            this.btnBiletOnayla.Text = "Bilet Onayla";
            this.btnBiletOnayla.UseVisualStyleBackColor = true;
            this.btnBiletOnayla.Click += new System.EventHandler(this.btnBiletOnayla_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBiletOnayla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKoltuk2);
            this.Controls.Add(this.cmbKoltuk1);
            this.Controls.Add(this.grpBiletDeğişimİade);
            this.Controls.Add(this.grpYolcuSınıfı);
            this.Controls.Add(this.grpEkstraHizmetler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiyat);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpEkstraHizmetler.ResumeLayout(false);
            this.grpEkstraHizmetler.PerformLayout();
            this.grpYolcuSınıfı.ResumeLayout(false);
            this.grpYolcuSınıfı.PerformLayout();
            this.grpBiletDeğişimİade.ResumeLayout(false);
            this.grpBiletDeğişimİade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEkstraHizmetler;
        private System.Windows.Forms.CheckBox chkYemekSeçimi;
        private System.Windows.Forms.CheckBox chkEkstraBagaj;
        private System.Windows.Forms.CheckBox chkKoltukSeçimi;
        private System.Windows.Forms.GroupBox grpYolcuSınıfı;
        private System.Windows.Forms.GroupBox grpBiletDeğişimİade;
        private System.Windows.Forms.RadioButton rdbEkonomi;
        private System.Windows.Forms.RadioButton rdbBusiness;
        private System.Windows.Forms.CheckBox chkEsnekBilet;
        private System.Windows.Forms.CheckBox chkEsnekİptal;
        private System.Windows.Forms.ComboBox cmbKoltuk1;
        private System.Windows.Forms.ComboBox cmbKoltuk2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBiletOnayla;
    }
}