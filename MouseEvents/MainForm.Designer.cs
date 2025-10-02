namespace MouseEvents
{
    partial class MainForm
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
            this.btnArkaPlanKirmizi = new System.Windows.Forms.Button();
            this.btnYazininRenginiDegis = new System.Windows.Forms.Button();
            this.btnFontSizeIncrease = new System.Windows.Forms.Button();
            this.lblYazi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArkaPlanKirmizi
            // 
            this.btnArkaPlanKirmizi.Location = new System.Drawing.Point(365, 37);
            this.btnArkaPlanKirmizi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArkaPlanKirmizi.Name = "btnArkaPlanKirmizi";
            this.btnArkaPlanKirmizi.Size = new System.Drawing.Size(129, 43);
            this.btnArkaPlanKirmizi.TabIndex = 0;
            this.btnArkaPlanKirmizi.Text = "Arka Plan Kırmızı";
            this.btnArkaPlanKirmizi.UseVisualStyleBackColor = true;
            this.btnArkaPlanKirmizi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnArkaPlanKirmizi_MouseMove);
            // 
            // btnYazininRenginiDegis
            // 
            this.btnYazininRenginiDegis.Location = new System.Drawing.Point(365, 87);
            this.btnYazininRenginiDegis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYazininRenginiDegis.Name = "btnYazininRenginiDegis";
            this.btnYazininRenginiDegis.Size = new System.Drawing.Size(129, 43);
            this.btnYazininRenginiDegis.TabIndex = 0;
            this.btnYazininRenginiDegis.Text = "Yazının Rengini Değiş";
            this.btnYazininRenginiDegis.UseVisualStyleBackColor = true;
            this.btnYazininRenginiDegis.MouseHover += new System.EventHandler(this.btnYazininRenginiDegis_MouseHover);
            // 
            // btnFontSizeIncrease
            // 
            this.btnFontSizeIncrease.Location = new System.Drawing.Point(365, 138);
            this.btnFontSizeIncrease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFontSizeIncrease.Name = "btnFontSizeIncrease";
            this.btnFontSizeIncrease.Size = new System.Drawing.Size(129, 43);
            this.btnFontSizeIncrease.TabIndex = 0;
            this.btnFontSizeIncrease.Text = "Font Size +5";
            this.btnFontSizeIncrease.UseVisualStyleBackColor = true;
            this.btnFontSizeIncrease.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFontSizeIncrease_MouseDown);
            // 
            // lblYazi
            // 
            this.lblYazi.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazi.Location = new System.Drawing.Point(16, 11);
            this.lblYazi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(341, 187);
            this.lblYazi.TabIndex = 1;
            this.lblYazi.Text = "fenerbahce";
            this.lblYazi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYazi.Click += new System.EventHandler(this.lblYazi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 209);
            this.Controls.Add(this.lblYazi);
            this.Controls.Add(this.btnFontSizeIncrease);
            this.Controls.Add(this.btnYazininRenginiDegis);
            this.Controls.Add(this.btnArkaPlanKirmizi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hafta 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArkaPlanKirmizi;
        private System.Windows.Forms.Button btnYazininRenginiDegis;
        private System.Windows.Forms.Button btnFontSizeIncrease;
        private System.Windows.Forms.Label lblYazi;
    }
}

