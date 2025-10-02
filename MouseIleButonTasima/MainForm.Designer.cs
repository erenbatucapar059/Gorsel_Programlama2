namespace MouseIleButonTasima
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
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(275, 154);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(97, 43);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "Taşı";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMove_MouseDown);
            this.btnMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMove_MouseMove);
            this.btnMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMove_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMove);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hafta 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMove;
    }
}

