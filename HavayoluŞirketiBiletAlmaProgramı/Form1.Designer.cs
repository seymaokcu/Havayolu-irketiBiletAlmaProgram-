namespace HavayoluŞirketiBiletAlmaProgramı
{
    partial class Form1
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
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudYolcu = new System.Windows.Forms.NumericUpDown();
            this.mcTarih = new System.Windows.Forms.MonthCalendar();
            this.btnBiletAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudYolcu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNereye
            // 
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "Ankara",
            "İzmir",
            "İstanbul",
            "Diyarbakır",
            "Antalya"});
            this.cmbNereye.Location = new System.Drawing.Point(194, 153);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(159, 24);
            this.cmbNereye.TabIndex = 0;
            // 
            // cmbNereden
            // 
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Items.AddRange(new object[] {
            "Ankara",
            "İzmir",
            "İstanbul",
            "Diyarbakır",
            "Antalya"});
            this.cmbNereden.Location = new System.Drawing.Point(194, 100);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(159, 24);
            this.cmbNereden.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nereden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereye:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yolcu Sayısı";
            // 
            // nudYolcu
            // 
            this.nudYolcu.Location = new System.Drawing.Point(456, 155);
            this.nudYolcu.Name = "nudYolcu";
            this.nudYolcu.Size = new System.Drawing.Size(120, 22);
            this.nudYolcu.TabIndex = 5;
            this.nudYolcu.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // mcTarih
            // 
            this.mcTarih.Location = new System.Drawing.Point(127, 201);
            this.mcTarih.Name = "mcTarih";
            this.mcTarih.TabIndex = 6;
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(456, 201);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(120, 207);
            this.btnBiletAl.TabIndex = 7;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 510);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.mcTarih);
            this.Controls.Add(this.nudYolcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.cmbNereye);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYolcu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudYolcu;
        private System.Windows.Forms.MonthCalendar mcTarih;
        private System.Windows.Forms.Button btnBiletAl;
    }
}

