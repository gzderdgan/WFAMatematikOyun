namespace WFAMatematikOyun
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.Location = new System.Drawing.Point(60, 24);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(100, 23);
            this.lblSayi1.TabIndex = 1;
            this.lblSayi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi2
            // 
            this.lblSayi2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.Location = new System.Drawing.Point(253, 24);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(100, 23);
            this.lblSayi2.TabIndex = 2;
            this.lblSayi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(533, 24);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "button1";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblOperator
            // 
            this.lblOperator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOperator.Location = new System.Drawing.Point(184, 24);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(51, 23);
            this.lblOperator.TabIndex = 4;
            this.lblOperator.Text = "+";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(13, 139);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(108, 20);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Toplam Soru=";
            // 
            // lblToplam
            // 
            this.lblToplam.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToplam.Location = new System.Drawing.Point(127, 139);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(100, 23);
            this.lblToplam.TabIndex = 6;
            this.lblToplam.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doğru Soru=";
            // 
            // lblDogru
            // 
            this.lblDogru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDogru.Location = new System.Drawing.Point(126, 188);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(100, 23);
            this.lblDogru.TabIndex = 6;
            this.lblDogru.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(330, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yanlış Soru=";
            // 
            // lblYanlis
            // 
            this.lblYanlis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYanlis.Location = new System.Drawing.Point(444, 134);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(100, 23);
            this.lblYanlis.TabIndex = 6;
            this.lblYanlis.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(330, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seviye";
            // 
            // lblSeviye
            // 
            this.lblSeviye.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSeviye.Location = new System.Drawing.Point(444, 188);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(100, 23);
            this.lblSeviye.TabIndex = 6;
            this.lblSeviye.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(693, 266);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(105, 74);
            this.lblTime.TabIndex = 7;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(386, 24);
            this.tbSonuc.Multiline = true;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(108, 23);
            this.tbSonuc.TabIndex = 0;
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.tbSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox tbSonuc;
        private System.Windows.Forms.Timer tmrSure;
    }
}

