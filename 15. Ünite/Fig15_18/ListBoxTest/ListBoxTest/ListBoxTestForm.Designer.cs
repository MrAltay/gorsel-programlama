namespace ListeKutusuTesti
{
   partial class ListeKutusuTestFormu
   {
      private System.ComponentModel.IContainer bilesenler = null;

      protected override void Dispose(bool imhaEdiliyorMu)
      {
         if (imhaEdiliyorMu && (bilesenler != null))
         {
            bilesenler.Dispose();
         }
         base.Dispose(imhaEdiliyorMu);
      }

      #region Windows Form Designer generated code

      private void InitializeComponent()
      {
         this.cikisButonu = new System.Windows.Forms.Button();
         this.temizleButonu = new System.Windows.Forms.Button();
         this.silButonu = new System.Windows.Forms.Button();
         this.ekleButonu = new System.Windows.Forms.Button();
         this.girisMetinKutusu = new System.Windows.Forms.TextBox();
         this.goruntuListeKutusu = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         
         this.cikisButonu.Location = new System.Drawing.Point(171, 237);
         this.cikisButonu.Name = "cikisButonu";
         this.cikisButonu.Size = new System.Drawing.Size(100, 36);
         this.cikisButonu.TabIndex = 23;
         this.cikisButonu.Text = "Çıkış";
         this.cikisButonu.Click += new System.EventHandler(this.cikisButonu_Tikla);
         
         this.temizleButonu.Location = new System.Drawing.Point(171, 184);
         this.temizleButonu.Name = "temizleButonu";
         this.temizleButonu.Size = new System.Drawing.Size(100, 36);
         this.temizleButonu.TabIndex = 22;
         this.temizleButonu.Text = "Temizle";
         this.temizleButonu.Click += new System.EventHandler(this.temizleButonu_Tikla);
         
         this.silButonu.Location = new System.Drawing.Point(171, 129);
         this.silButonu.Name = "silButonu";
         this.silButonu.Size = new System.Drawing.Size(100, 36);
         this.silButonu.TabIndex = 21;
         this.silButonu.Text = "Sil";
         this.silButonu.Click += new System.EventHandler(this.silButonu_Tikla);
         
         this.ekleButonu.Location = new System.Drawing.Point(171, 74);
         this.ekleButonu.Name = "ekleButonu";
         this.ekleButonu.Size = new System.Drawing.Size(100, 36);
         this.ekleButonu.TabIndex = 20;
         this.ekleButonu.Text = "Ekle";
         this.ekleButonu.Click += new System.EventHandler(this.ekleButonu_Tikla);
         
         this.girisMetinKutusu.Location = new System.Drawing.Point(171, 29);
         this.girisMetinKutusu.Name = "girisMetinKutusu";
         this.girisMetinKutusu.Size = new System.Drawing.Size(100, 23);
         this.girisMetinKutusu.TabIndex = 19;
         
         this.goruntuListeKutusu.FormattingEnabled = true;
         this.goruntuListeKutusu.ItemHeight = 15;
         this.goruntuListeKutusu.Location = new System.Drawing.Point(35, 29);
         this.goruntuListeKutusu.Name = "goruntuListeKutusu";
         this.goruntuListeKutusu.Size = new System.Drawing.Size(119, 244);
         this.goruntuListeKutusu.TabIndex = 18;
         
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(307, 302);
         this.Controls.Add(this.cikisButonu);
         this.Controls.Add(this.temizleButonu);
         this.Controls.Add(this.silButonu);
         this.Controls.Add(this.ekleButonu);
         this.Controls.Add(this.girisMetinKutusu);
         this.Controls.Add(this.goruntuListeKutusu);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "ListeKutusuTestFormu";
         this.Text = "Liste Kutusu Testi";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.Button cikisButonu;
      internal System.Windows.Forms.Button temizleButonu;
      internal System.Windows.Forms.Button silButonu;
      internal System.Windows.Forms.Button ekleButonu;
      internal System.Windows.Forms.TextBox girisMetinKutusu;
      internal System.Windows.Forms.ListBox goruntuListeKutusu;

   }
}